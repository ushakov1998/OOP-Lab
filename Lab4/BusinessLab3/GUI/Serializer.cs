using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using BusinessLogic;

namespace GUI
{
    /// <summary>
    /// Класс для сериализации и десериализации
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Сериалайзер
        /// </summary>
        private static readonly XmlSerializer _xmlSerializer = new XmlSerializer(typeof(BindingList<WorkerBase>));

        /// <summary>
        /// Сохранение листа в файл
        /// </summary>
        /// <param name="workerList">Лист</param>
        /// <param name="path">Путь к файлу</param>
        public static void SaveFile(BindingList<WorkerBase> _workerList, string path)
        {
            using var file = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            _xmlSerializer.Serialize(file, _workerList);
        }

        /// <summary>
        /// Извлечение листа из файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static BindingList<WorkerBase> OpenFile(string path)
        {
            FileStream file = null;
            try
            {
                file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
                using TextReader textReader = new StreamReader(file);
                try
                {
                    return (BindingList<WorkerBase>) _xmlSerializer.Deserialize(file);
                }
                catch
                {
                    throw new Exception("Файл поврежден :(");
                }
            }
            finally
            {
                file?.Dispose();
            }
            
        }

    }
}
