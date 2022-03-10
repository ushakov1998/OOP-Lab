using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Балбес(ребенок)
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Родитель ребенка №1
        /// </summary>
        public Adult AncestorOne { get; set; }

        /// <summary>
        /// Родитель ребенка №2
        /// </summary>
        public Adult AncestorTwo { get; set; }

        public string School { get; set; }

        /// <summary>
        /// Макс.возраст ребенка
        /// </summary>
        public const int ChildMaxAge = 125;

        /// <summary>
        /// Мин.возраст ребенка
        /// </summary>
        public const int ChildMinAge = 18;

        /// <summary>
        /// Возраст
        /// </summary>
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > ChildMaxAge && value <= ChildMinAge)
                {
                    throw new ArgumentOutOfRangeException(
                        "Упс...,кажется возраст не в диапозоне (0;17]");
                }
                _age = value;
            }
        }
    }
}
