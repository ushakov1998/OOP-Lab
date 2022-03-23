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
    public class RatePayment : WorkerBase, IPayable
    {
        /// <summary>
        /// Отработано дней
        /// </summary>
        private int _daysWorked;

        /// <summary>
        /// Отработано дней
        /// </summary>
        public int DaysWorked
        {
            get => _daysWorked;
            set => _daysWorked = value;
        }

        private double _costPerDay;

        /// <summary>
        /// Стоимость дня работы
        /// </summary>
        public double CostPerDay
        {
            get => _costPerDay;
            set => _costPerDay = value;
        }

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="daysWorked">Кол-во отработанных дней</param>
        /// <param name="costPerDay">Стоимость дня</param>
        public RatePayment(int daysWorked, double costPerDay)
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
        public override double Salary() => SalaryAccount += DaysWorked * CostPerDay * 0.87;

    }
}
