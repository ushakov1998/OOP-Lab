﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Оплата по окладу
    /// </summary>
    public class TariffPayment : IPayable
    {
        private int _daysWorked;
        private int _workingDaysInMonth;
        
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
        public int WorkingDaysInMonth
        {
            get => _workingDaysInMonth;
            set
            {
                Validation.ValidIntNumber(value);
                _workingDaysInMonth = value;
            }
        }

        private decimal _tariff;

        /// <summary>
        /// Оклад
        /// </summary>
        public decimal Tariff
        {
            get => _tariff;
            set
            {
                Validation.ValidDecimalNumber(value);
                _tariff = value;
            }
        }

        /// <summary>
        /// Конструтор класса
        /// </summary>
        /// <param name="tariff">Тарифная ставка</param>
        /// <param name="workingDaysInMonth">Кол-во рабочих дней в месяце</param>
        /// <param name="daysWorked">Дней отработано</param>
        public TariffPayment(decimal tariff, int workingDaysInMonth, int daysWorked)
        {
            Tariff = tariff;
            WorkingDaysInMonth = workingDaysInMonth;
            DaysWorked = daysWorked;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TariffPayment() : this(1, 1, 1) {}

        /// <summary>
        /// Расчет тарифной зарплаты
        /// </summary>
        public decimal Salary => DaysWorked * Tariff / WorkingDaysInMonth * 0.87m;


        /// <summary>
        /// Проверка количества отработанных дней
        /// </summary>
        /// <param name="daysWorked">Дней отработано</param>
        /// <param name="workingDaysInMonth">Всего рабочих дней в месяце</param>
        private static void ValidDaysWorked(int daysWorked, int workingDaysInMonth)
        {
            Validation.ValidIntNumber(daysWorked);
            if (daysWorked > workingDaysInMonth)
            {
                throw new ArgumentException("Рабочих дней больше, " +
                                            "чем рабочих дней в месяце!");
            }
        }
    }
}
