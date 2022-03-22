using System;

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
        
        /// <summary>
        /// Школа ребенка
        /// </summary>
        public string School { get; set; }
        
        /// <summary>
        /// Макс.возраст ребенка
        /// </summary>
        public const int ChildMaxAge = 18;

        /// <summary>
        /// Мин.возраст ребенка
        /// </summary>
        public const int ChildMinAge = 0;

        /// <summary>
        /// Возраст
        /// </summary>
        public override int Age
        {
            get => _age;
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
                if (AncestorTwo != null)
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
        /// <summary>
        /// Ребенок - гачист
        /// </summary>
        /// <returns>Счастливый ребенок</returns>
        public string LoveGachi()
        {
            return $"{ShortInfo},который слушает Gachimuchi " +
                   "и пытается понять смысл жизни...";
        }
    }
}
