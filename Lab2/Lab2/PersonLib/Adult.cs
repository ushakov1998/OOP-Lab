using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Взрослый ребенок
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Поле для паспорта
        /// </summary>
        private string _passport;

        /// <summary>
        /// Паспорт
        /// </summary>
        public string Passport
        {
            get => _passport;
            set
            {
                Regex regex = new Regex(@"\D");
                if (regex.IsMatch(value.ToString()) == true || value.Length != 9)
                {
                    throw new ArgumentException("Вроде как 9 цифр в пасспорте....");
                }
                _passport = value;
            }
        }

        /// <summary>
        /// Семейное положение
        /// </summary>
        public MaritalStatus MaritalStatus { get; set; }

        /// <summary>
        /// Макс.возраст взрослого
        /// </summary>
        public const int AdultMaxAge = 125;

        /// <summary>
        /// Мин.возраст взрослого
        /// </summary>
        public const int AdultMinAge = 18;

        /// <summary>
        /// Возраст
        /// </summary>
        public override int Age
        {
            get => _age;
            set
            {
                if (value > AdultMaxAge && value <= AdultMinAge)
                {
                    throw new ArgumentOutOfRangeException(
                        $"Упс...,кажется возраст не в диапозоне ({AdultMinAge};{AdultMaxAge}]");
                }
                _age = value;
            }
        }


    }
}
