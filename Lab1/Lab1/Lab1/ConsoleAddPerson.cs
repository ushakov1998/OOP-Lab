using System;
using System.Collections.Generic;
using Model;

namespace View
{
    /// <summary>
    /// Класс для добавления персоны
    /// </summary>
    public static class ConsoleAddPerson
    {
        /// <summary>
        /// Консольное добавление персоны
        /// </summary>
        /// <returns>Новая персона</returns>
        public static Person ReadPerson()
        {
            Person newPerson = new Person("Ivan", "Ivanovich", 45, Gender.Female);
            List<Action> actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Name: ");
                    newPerson.Name = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("Surname: ");
                    newPerson.Surname = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("Age: ");
                    string ageString = Console.ReadLine();
                    if (!Int32.TryParse(ageString, out int age))
                    {
                        throw new ArgumentException("The age must be an " +
                                                    "integer value!");
                    }

                    newPerson.Age = age;
                }),
                new Action(() =>
                {
                    Console.Write("Gender (0 - Male, 1 - Female): ");
                    int gender = Int32.Parse(Console.ReadLine());
                    Person.ChekingGender(gender);
                    newPerson.Gender = (Gender) Enum.Parse(
                        typeof(Gender), Convert.ToString(gender));
                }),
            };
            actions.ForEach(SetValue);
            return newPerson;
        }

        //TODO: XML
        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
