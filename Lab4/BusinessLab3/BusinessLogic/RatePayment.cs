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
    public class RatePayment : WorkerBase, ISalaryble
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

        /// <summary>
        /// Стоимость дня работы
        /// </summary>
        public double CostPerDay { get; set; }

        /// <summary>
        /// Конструктор класа
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="salaryAccount">Зарплатный счет</param>
        /// <param name="daysWorked">Отработанные дни</param>
        /// <param name="costPerDay">Стоимость дня</param>
        public RatePayment(string name, string surname, double salaryAccount,
            int daysWorked, double costPerDay) : base(name, surname, salaryAccount)
        {
            DaysWorked = daysWorked;
            CostPerDay = costPerDay;
        }

        /// <summary>
        /// XML конструктор
        /// </summary>
        public RatePayment()
        {

        }
        /// <summary>
        /// Зарплата
        /// </summary>
        public override double Salary() => SalaryAccount += DaysWorked * CostPerDay * 0.87;

        /// <inheritdoc/>
        public override string Info()
        {
            return $"{InfoBase()},  CostPerDay: {CostPerDay}, DaysWorked: {DaysWorked}";
        }
    }
}
