using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Класс: Оплата по ставке
    /// </summary>
    public class RatePayment : IPayable
    {

        private int _daysWorked;

        /// <summary>
        /// Отработано дней
        /// </summary>
        public int DaysWorked
        {
            get => _daysWorked;
            set
            {
                Validation.ValidIntNumber(value);
                _daysWorked = value;
            }
        }

        private decimal _costPerDay;

        /// <summary>
        /// Стоимость дня работы
        /// </summary>
        public decimal CostPerDay
        {
            get => _costPerDay;
            set
            {
                Validation.ValidDecimalNumber(value);
                _costPerDay = value;
            }
        }

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="daysWorked">Кол-во отработанных дней</param>
        /// <param name="costPerDay">Стоимость дня</param>
        public RatePayment(int daysWorked, decimal costPerDay)
        {
            DaysWorked = daysWorked;
            CostPerDay = costPerDay;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public RatePayment(): this(1,1) {}

        /// <summary>
        /// Зарплата
        /// </summary>
        public decimal Salary => DaysWorked * CostPerDay * 0.87m;
    }
}
