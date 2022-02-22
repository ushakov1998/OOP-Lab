using System;

namespace Model
{
    /// <summary>
    /// Класc Рандомная персона
    /// </summary>
    public static class RandomPerson
    {
        /// <summary>
        /// Генератор случайного человека
        /// </summary>
        /// <returns> Человек со случайными данными</returns>
        public static Person GetRandomPerson()
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
            var gender = (Gender) random.Next(0, 2);
            switch (gender)
            {
                case Gender.Male:
                    name = maleName[random.Next(maleName.Length)];
                    break;
                case Gender.Female:
                    name = femaleName[random.Next(femaleName.Length)];
                    break;
                default:
                    return new Person("Ivan", "Ivanovich", 0, Gender.Male);
            }

            var surname = allSurname[random.Next(allSurname.Length)];
            var age = random.Next(0, Person.MaxAge);
            return new Person(name, surname, age, gender);
        }
    }
}
