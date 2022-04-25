using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    /// <summary>
    /// Абстрактный класс рабочего
    /// </summary>
    public abstract class WorkerBase : ISalaryble
    {
        /// <summary>
        /// Метод начисления ЗП
        /// </summary>
        /// <returns></returns>
        public virtual double Salary() => SalaryAccount;

        /// <summary>
        /// Имя 
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия 
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя 
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                CheckNameAndSurname(value);
                _name = ConvertToRightForm(value);
            }
        }

        /// <summary>
        /// Фамилия 
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                CheckNameAndSurname(value);
                if (LocalizationCheck(value))
                {
                    _surname = ConvertToRightForm(value);
                }

            }
        }

        /// <summary>
        /// Зарплатный счет
        /// </summary>
        private double _salaryAccount;

        /// <summary>
        /// Зарплатный счет
        /// </summary>
        public double SalaryAccount
        {
            get => _salaryAccount;
            set => _salaryAccount = System.Math.Round(value,1);
        }

        

        /// <summary>
        /// Проверка имени и фамилии
        /// </summary>
        /// <param name="value">Имя или фамилия для проверки</param>
        /// <returns>Корректная строка</returns>
        public static string CheckNameAndSurname(string value)
        {
            if (value == string.Empty)
            {
                throw new Exception("Expression is empty!");
            }
            else if (!IsNameAndSurnameCorrect(value))
            {
                throw new Exception("Name or surname have to contain" +
                                    " only Cyrillic or Latin symbols!");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Проверка локали имени и фамилии
        /// </summary>
        /// <param name="value">Имя,Фамилия</param>
        /// <returns>Локаль имени и фамилии</returns>
        private Localization CheckLanguage(string value)
        {
            var languageDictionary = new Dictionary<Localization, string>()
            {
                {Localization.Russian, @"(^[а-я]+[-]?[а-я]+$)|(^[а-я]$)"},
                {Localization.English, @"(^[a-z]+[-]?[a-z]+$)|(^[a-z]$)"}
            };

            foreach (var item in languageDictionary)
            {
                var language = Regex.IsMatch(value.ToLower(),
                    languageDictionary[item.Key]);
                if (language)
                {
                    return item.Key;
                }
            }
            throw new ArgumentException
                ("Other language.");
        }

        /// <summary>
        /// Проверка имени и фамилии на корректность ввода
        /// </summary>
        /// <param name="value">Имя или фамилия для проверки</param>
        /// <returns>Верно/неверно в зависимости от результата
        /// проверки</returns>
        private static bool IsNameAndSurnameCorrect(string value)
        {
            var regex = new Regex("^([A-Za-z]|[А-Яа-я])+(((-| )?([A-Za-z]|" +
                                  "[А-Яа-я])+))?$");


            return regex.IsMatch(value);
        }

        /// <summary>
        /// Проверка регистра
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string ConvertToRightForm(string value)
        {
            string FirstLetterToUpper(string name)
            {
                return name.Substring(0, 1).ToUpper() +
                       name.Substring(1, name.Length - 1).ToLower();
            }

            var symbols = new[] { "-", " " };
            foreach (var symbol in symbols)
            {
                if (value.Contains(symbol))
                {
                    int indexOfSymbol = value.IndexOf(symbol);
                    return value.Substring(0, 1).ToUpper()
                           + value.Substring(1, indexOfSymbol - 1).ToLower()
                           + symbol
                           + value.Substring(indexOfSymbol + 1, 1).ToUpper()
                           + value.Substring(indexOfSymbol + 2).ToLower();
                }

            }
            return FirstLetterToUpper(value);
        }

        /// <summary>
        /// Проверка локали имени и фамилии
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool LocalizationCheck(string value)
        {
            if (((CheckLanguage(value) != CheckLanguage(_name))))
            {
                throw new ArgumentException
                    ("Please enter Surname and Name in same language");
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="salaryAccount">Зарплатный счет</param>
        protected WorkerBase(string name, string surname, double salaryAccount)
        {
            Name = name;
            Surname = surname;
            SalaryAccount = salaryAccount;
        }

        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        protected WorkerBase() : this("Alex", "Kent",  0) { }

        /// <summary>
        /// Информация о работяге
        /// </summary>
        /// <returns></returns>
        public abstract string Info();

        /// <summary>
        /// Информация о работяге
        /// </summary>
        /// <returns></returns>
        protected string InfoBase()
        {
            return $"{Name} {Surname}, Account: {SalaryAccount} $";
        }

    }
}

