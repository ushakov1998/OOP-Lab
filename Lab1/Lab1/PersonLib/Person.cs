using System;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс: Человек 
    /// Включает в себя поля,свойства и методы класса
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя 
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия 
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст 
        /// </summary>
        private int _age;

        /// <summary>
        /// Имя 
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                CheckNameAndSurname(value);
                _name = ConvertToCorrectRegister(value);
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
                _surname = ConvertToCorrectRegister(value);
            }
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
                throw new Exception("Name or surname have to contain " + 
                                    " only Cyrillic or Latin symbols!");
            }
            else
            {
                return value;
            }
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
        /// Проверка регистра и (двойных имен - еще не сделал)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string ConvertToCorrectRegister(string value)
        {
            //TODO:
            string FirstLetterToUpper(string name)
            {
                return name.Substring(0, 1).ToUpper() +
                       name.Substring(1, name.Length - 1).ToLower();
            }

            return FirstLetterToUpper(value);
        }
        /// <summary>
        /// Максимальный возраст человека
        /// </summary>
        public const int MaxAge = 125;

        /// <summary>
        /// Возраст 
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                CheckingAge(value);
                _age = value;
            }
        }
        
        /// <summary>
        /// Проверка для ввода возраста
        /// </summary>
        /// <param name="number">Возраст для проверки</param>
        /// <returns>Корректный возраст</returns>
        public static int CheckingAge(int number)
        {
            if (number < 0 || number > MaxAge)
            {
                throw new ArgumentException(
                    $"The age must between 0 and {MaxAge} years!");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Пол 
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        
        //TODO: вынести
        /// <summary>
        /// Проверка ввода пола
        /// </summary>
        /// <param name="number">Цифра пола</param>
        /// <returns></returns>
        public static int CheсkGender(int number)
        {
            if (number < 0 || number > 1)
            {
                throw new ArgumentException("Enter 0 or 1. 0 - Male, 1 - Female");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Информация о человеке
        /// </summary>
        public string Info => $"{Name} {Surname}, Age: {Age}, Gender: {Gender}";
    }
}
