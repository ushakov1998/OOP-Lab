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
            string[] maleName = new string[]
            {
                "Hidan", "Isaac", "Deidara", "Morty",
                "Harry", "Itachi", "Nagato", "Pain"
            };

            string[] femaleName = new string[]
            {
                "Anna", "Helga", "Germiona", "Mira",
                "Konan", "Anastasia", "Ellen", "Eliza"
            };

            string[] allSurname = new string[]
            {
                "Uciha", "Granger", "Potaki", "Riddle",
                "Newton", "Potter", "Uzumaki", "Hanzo"
            };

            Random random = new Random();
            string name;
            Gender gender = (Gender) random.Next(0, 2);
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

            string surname = allSurname[random.Next(allSurname.Length)];
            int age = random.Next(0, Person.MaxAge);
            return new Person(name, surname, age, gender);
        }
    }
}
