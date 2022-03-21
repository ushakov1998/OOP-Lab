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

        //TODO: XML
        public string School { get; set; }

        //BUG:
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
                        $"Упс...,кажется возраст не в диапозоне ({ChildMinAge};{ChildMaxAge}]");
                }
                _age = value;
            }
        }
        /// <summary>
        /// Информация о ребенке
        /// </summary>
        ///<returns>Информация о ребенке</returns>
        public override string Info
        {
            get
            {
                var personInfo = base.Info;
                if (AncestorOne != null)
                {
                    personInfo += $"\nПервый родитель:" +
                                  $" {AncestorOne.Name} {AncestorOne.Surname} ";
                }
                if (AncestorOne != null)
                {
                    personInfo += $"\nВторой родитель:" +
                                  $" {AncestorTwo.Name} {AncestorTwo.Surname} ";
                }
                if (AncestorOne == null && AncestorTwo == null)
                {
                    personInfo += "\nСирота";
                }

                if (School != null)
                {
                    personInfo += $"\nШкола: {School}";
                }
                return personInfo;
            }
        }
    }
}
