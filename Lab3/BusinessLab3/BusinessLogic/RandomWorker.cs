using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Класс: Рандомный работяга
    /// </summary>
    public class RandomWorker
    {
        /// <summary>
        /// Экземпляр класса Random
        /// </summary>
        private static Random _random = new Random(DateTime.Now.Second);

        /// <summary>
        /// Массив: Имена
        /// </summary>
        private static string[] _names = new string[]
        {
            "Hidan", "Isaac", "Deidara", "Morty",
            "Harry", "Itachi", "Nagato", "Pain"
        };

        /// <summary>
        /// Массив: Фамилии
        /// </summary>
        private static string[] _surnames = new string[]
        {
            "Uciha", "Granger", "Potaki", "Riddle",
            "Newton", "Potter", "Uzumaki", "Hanzo"
        };

        /// <summary>
        /// Создание рандомного работяги
        /// с почасовой оплатой
        /// </summary>
        /// <returns></returns>
        public static HourPayment GetRandomHourWorker()
        {
            var random = new Random();
            HourPayment randomHourWorker = new HourPayment(
                _names[random.Next(_names.Length)],
                _surnames[random.Next(_surnames.Length)],
                random.Next(0, 5),
                random.Next(1, 50), 
                random.Next(100, 250));

            return randomHourWorker;
        }

        /// <summary>
        /// Создание рандомного работяги
        /// со ставкой
        /// </summary>
        /// <returns>Работяга со ставкой</returns>
        public static RatePayment GetRandomRateWorker()
        {
            var random = new Random();
            RatePayment randomRateWorker = new RatePayment(
                _names[random.Next(_names.Length)],
                _surnames[random.Next(_surnames.Length)],
                random.Next(0, 5),
                random.Next(25, 50), 
                random.Next(1, 5));

            return randomRateWorker;
        }

        /// <summary>
        /// Создание рандомного работяги с окладом
        /// </summary>
        /// <returns>Работяга с окладом</returns>
        public static TariffPayment GetRandomTariffWorker()
        {
            var random = new Random();
            TariffPayment randomTariffWorker = new TariffPayment(
                _names[random.Next(_names.Length)],
                _surnames[random.Next(_surnames.Length)],
                _random.Next(0, 5),
                random.Next(10000, 60000),
                random.Next(23, 25),
                random.Next(20, 22));

            return randomTariffWorker;
        }

    }
}
