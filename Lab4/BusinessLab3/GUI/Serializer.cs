﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private static readonly XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<WorkerBase>));

        /// <summary>
        /// Сохранение листа в файл
        /// </summary>
        /// <param name="wokerList">Лист</param>
        /// <param name="path">Путь к файлу</param>
        public static void SaveFile(List<WorkerBase> workerList, string path)
        {
            using var file = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            _xmlSerializer.Serialize(file,workerList);
        }

        /// <summary>
        /// Извлечение листа из файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<WorkerBase> OpenFile(string path)
        {
            FileStream file = null;
            try
            {
                file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
                using TextReader textReader = new StreamReader(file);
                try
                {
                    return (List<WorkerBase>)_xmlSerializer.Deserialize(file);
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