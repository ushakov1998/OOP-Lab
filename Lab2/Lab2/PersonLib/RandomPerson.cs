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
        private static Random _random = new Random(DateTime.Now.Second);

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
        /// Генерация взрослого/ребенка
        /// </summary>
        /// <returns></returns>
        public static PersonBase CreateRandomPerson()
        {
            if (_random.Next(0, 5) != 0)
            {
                return CreateAdult();
            }
            else
            {
                return CreateChild();
            }
        }
        /// <summary>
        /// Генерация случайного ребенка/взрослого
        /// </summary>
        /// <param name="person">Человек</param>
        public static void GetRandomPerson(PersonBase person)
        {
            var gender = _random.Next(0, 2);
            switch (gender)
            {
                case 0:
                {
                    person.Gender = Gender.Male;
                    person.Name = _maleName[_random.Next(_maleName.Length)];
                    break;
                }
                case 1:
                {
                    person.Gender = Gender.Female;
                    person.Name = _maleName[_random.Next(_femaleName.Length)];
                    break;
                }
            }
            person.Surname = _allSurname[_random.Next(_allSurname.Length)];
        }

        /// <summary>
        /// Рандомный старина
        /// </summary>
        /// <param name="married">Статус семейного положения</param>
        /// <param name="partner">Супруг</param>
        /// <returns>Рандомного взрослого чела</returns>
        public static Adult CreateAdult(bool married = false, Adult partner = null)
        {
            Adult randomAdult = new Adult();
            GetRandomPerson(randomAdult);
            randomAdult.Age = _random.Next(Adult.AdultMinAge, Adult.AdultMaxAge);
            if (!married)
            {
                randomAdult.MaritalStatus = (MaritalStatus)_random.Next(0, 3);
                if (randomAdult.MaritalStatus == MaritalStatus.Married)
                {
                    randomAdult.Partner = CreateAdult(true, randomAdult);
                }
            }
            else
            {
                randomAdult.MaritalStatus = MaritalStatus.Married;
                randomAdult.Partner = partner;
            }

            string[] jobs = new string[]
            {
                "Грустный завод", "Шахта", "Лопаты и кирки",
                "KFC", "Кремелевский бот", "Любитель лесных квестов"
            };

            randomAdult.Job = jobs[_random.Next(0, jobs.Length)];
            PassportNumber(randomAdult);
            return randomAdult;
        }


        /// <summary>
        /// Создание ребенка
        /// </summary>
        /// <returns>Рандомный ребенок</returns>
        public static Child CreateChild()
        {
            Child randomChild = new Child();
            GetRandomPerson(randomChild);
            randomChild.Age = _random.Next(Child.ChildMinAge, Child.ChildMaxAge);

            bool hasMother = _random.Next(0, 2) != 0;

            if (hasMother)
            {
                randomChild.AncestorOne = CreateAdult();
            }

            bool hasFather = _random.Next(0, 2) != 0;

            if (hasFather)
            {
                randomChild.AncestorTwo = CreateAdult();
            }

            string[] schools = new string[]
            {
                "#13","TikTok-Школа","Лицей при ТПУ",
                "Шарага №5","Школа Гачи-Мучи","Хогвартс"
            };

            randomChild.School = schools[_random.Next(0, schools.Length)];
            return randomChild;
        }

    }
}
