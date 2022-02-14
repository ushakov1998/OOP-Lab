using System;

namespace Model
{
    //TODO: XML
    public class RandomPerson
    {
        /// <summary>
        /// Генератор случайного человека
        /// </summary>
        /// <returns> Человек со случайными данными</returns>
        public static Person GetRandomPerson()
        {
            //TODO: RSDN
            string[] _maleName = new string[]
            {
                "Hidan", "Isaac", "Deidara", "Morty",
                "Harry", "Itachi", "Nagato", "Pain"
            };

            string[] _femaleName = new string[]
            {
                "Anna", "Helga", "Germiona", "Mira",
                "Konan", "Anastasia", "Ellen", "Eliza"
            };

            string[] _allSurname = new string[]
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
                    name = _maleName[random.Next(_maleName.Length)];
                    break;
                case Gender.Female:
                    name = _femaleName[random.Next(_femaleName.Length)];
                    break;
                default:
                    return new Person("Ivan", "Ivanovich", 0, Gender.Male);
            }

            string surname = _allSurname[random.Next(_allSurname.Length)];
            int age = random.Next(0, Person.MaxAge);
            return new Person(name, surname, age, gender);
        }
    }
}
