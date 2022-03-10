using System;
using System.Xml;

namespace Model
{
    /// <summary>
    /// Класc Рандомная персона
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Экзмепляр класса Random
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Массив: Мужчинские имена
        /// </summary>
        private static string[] _maleName = new string[]
        {
            "Hidan", "Isaac", "Deidara", "Morty",
            "Harry", "Itachi", "Nagato", "Pain"
        };

        /// <summary>
        /// Массив: Женские имена
        /// </summary>
        private static string[] _femaleName = new string[]
        {
            "Anna", "Helga", "Germiona", "Mira",
            "Konan", "Anastasia", "Ellen", "Eliza"
        };

        /// <summary>
        /// Массив: Фамилии
        /// </summary>
        private static string[] _allSurname = new string[]
        {
            "Uciha", "Granger", "Potaki", "Riddle",
            "Newton", "Potter", "Uzumaki", "Hanzo"
        };

        /// <summary>
        /// Рандом.генерация номера паспорта
        /// </summary>
        /// <param name="adult">Взрослый чел</param>
        private static void PassportNumber(Adult adult)
        {
            var _passport = _random.Next(100000000, 999999999).ToString();
            adult.Passport = _passport;
        }
        /// <summary>
        /// Рандомный ребенок
        /// </summary>
        /// <returns></returns>
        public static Child CreateChild()
        {
            Child randomChild = new Child();
            return randomChild;
        }
        /// <summary>
        /// Рандомный старина
        /// </summary>
        /// <returns></returns>
        public static Adult CreateAdult()
        {
            Adult randomAdult = new Adult();
            return randomAdult;
        }


        /*public static PersonBase GetRandomPerson()
        {
            var maleName = new string[]
            {
                "Hidan", "Isaac", "Deidara", "Morty",
                "Harry", "Itachi", "Nagato", "Pain"
            };

            var femaleName = new string[]
            {
                "Anna", "Helga", "Germiona", "Mira",
                "Konan", "Anastasia", "Ellen", "Eliza"
            };

            var allSurname = new string[]
            {
                "Uciha", "Granger", "Potaki", "Riddle",
                "Newton", "Potter", "Uzumaki", "Hanzo"
            };

            var random = new Random();
            string name;
            var gender = (Gender)random.Next(0, 2);
            switch (gender)
            {
                case Gender.Male:
                    name = maleName[random.Next(maleName.Length)];
                    break;
                case Gender.Female:
                    name = femaleName[random.Next(femaleName.Length)];
                    break;
                default:
                    return new PersonBase("Ivan", "Ivanovich", 0, Gender.Male);
            }

            var surname = allSurname[random.Next(allSurname.Length)];
            var age = random.Next(0, PersonBase.MaxAge);
            return new PersonBase(name, surname, age, gender);
        }*/
    }
}
