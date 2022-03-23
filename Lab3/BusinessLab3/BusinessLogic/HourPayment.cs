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
    public class HourPayment : WorkerBase, IPayable
    {
        /// <summary>
        /// Отработанные часы
        /// </summary>
        private int _hoursWorked;

        /// <summary>
        /// Отработанные часы
        /// </summary>
        public int HoursWorked
        {
            get => _hoursWorked;
            set
            {
                _hoursWorked = value;
            }
        }

        /// <summary>
        /// Стоимость часа
        /// </summary>
        private double _costPerHour;

        /// <summary>
        /// Стоимость работы за час
        /// </summary>
        public double CostPerHour
        {
            get => _costPerHour;
            set => _costPerHour = value;
        }

        /// <summary>
        /// Зарплата
        /// </summary>
        public override double Salary() => SalaryAccount += HoursWorked * CostPerHour * 0.87;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <param name="costPerHour"></param>
        public HourPayment(int hoursWorked, double costPerHour)
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
