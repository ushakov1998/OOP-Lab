using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Оплата по окладу
    /// </summary>
    public class TariffPayment : WorkerBase, ISalaryble
    {
        private int _daysWorked;

        /// <summary>
        /// Количество отработанных дней
        /// </summary>
        public int DaysWorked
        {
            get => _daysWorked;
            set
            {
                ValidDaysWorked(value, WorkingDaysInMonth);
                _daysWorked = value;
            }
        }
        /// <summary>
        /// Количество рабочих дней в месяце
        /// </summary>
        public int WorkingDaysInMonth { get; set; }

        /// <summary>
        /// Оклад
        /// </summary>
        public double Tariff { get; set; } 
        
        /// <summary>
        /// Конструктор класс
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="salaryAccount">Зарплатный счет</param>
        /// <param name="tariff">Оклад</param>
        /// <param name="workingDaysInMonth">Рабочих дней в месяце</param>
        /// <param name="daysWorked">Отработано дней</param>
        public TariffPayment(string name, string surname, double salaryAccount, 
            double tariff, int workingDaysInMonth, int daysWorked) : base(name, surname, salaryAccount)
        {
            Tariff = tariff;
            WorkingDaysInMonth = workingDaysInMonth;
            DaysWorked = daysWorked;
        }

        /// <summary>
        /// Расчет тарифной зарплаты
        /// </summary>
        public override double Salary() => SalaryAccount += DaysWorked * Tariff / WorkingDaysInMonth * 0.87;

        public override string Info()
        {
            return $"{InfoBase()}, Tariff: {Tariff}, WorkingDaysInMonth: {WorkingDaysInMonth}, DaysWorked: {DaysWorked}";
        }

        /// <summary>
        /// Проверка количества отработанных дней
        /// </summary>
        /// <param name="daysWorked">Дней отработано</param>
        /// <param name="workingDaysInMonth">Всего рабочих дней в месяце</param>
        private static void ValidDaysWorked(int daysWorked, int workingDaysInMonth)
        {
            if (daysWorked > workingDaysInMonth)
            {
                throw new ArgumentException("Рабочих дней больше, " +
                                            "чем рабочих дней в месяце!");
            }
        }
    }
}
