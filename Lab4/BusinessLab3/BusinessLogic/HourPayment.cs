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
    public class HourPayment : WorkerBase, ISalaryble
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
            set => _hoursWorked = value;
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
        
        /// <inheritdoc/>
        public override string Info()
        {
            return $"{InfoBase()},  CostPerHour: {CostPerHour}, Worked: {HoursWorked}";
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="salaryAccount">Зарплатный счет</param>
        /// <param name="hoursWorked">Отработанные часы</param>
        /// <param name="costPerHour">Стоимость часа</param>
        public HourPayment(string name, string surname, double salaryAccount, 
            int hoursWorked , double costPerHour) : base(name, surname, salaryAccount)
        {
            HoursWorked = hoursWorked;
            CostPerHour = costPerHour;
        }

    }
}
