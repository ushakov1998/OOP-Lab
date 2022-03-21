using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Класс: Почасовая оплата
    /// </summary>
    public class HourPayment : IPayable
    {
        private int _hoursWorked;

        /// <summary>
        /// Отработанные часы
        /// </summary>
        public int HoursWorked
        {
            get => _hoursWorked;
            set
            {
                Validation.ValidIntNumber(value);
                _hoursWorked = value;
            }
        }

        private decimal _costPerHour;

        /// <summary>
        /// Стоимость работы за час
        /// </summary>
        public decimal CostPerHour
        {
            get => _costPerHour;
            set
            {
                Validation.ValidDecimalNumber(value);
                _costPerHour = value;
            }
        }

        /// <summary>
        /// Зарплата
        /// </summary>
        public decimal Salary => HoursWorked * CostPerHour * 0.87m;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <param name="costPerHour"></param>
        public HourPayment(int hoursWorked, decimal costPerHour)
        {
            HoursWorked = hoursWorked;
            CostPerHour = costPerHour;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HourPayment() : this(1, 1) {}
    }
}
