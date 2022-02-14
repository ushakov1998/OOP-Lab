using System;
using Model;
namespace View
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Two list of person. Each contains three persons.");
            Console.WriteLine();
            Console.ReadKey();

            var firstListOfPerson = new PersonList();
            var secondListOfPerson = new PersonList();

            var firstArray = new Person[]
            {
                new Person("Dominik", "Toretto", 30, Gender.Male),
                new Person("Jessy", "Jhones",55, Gender.Female),
                new Person("Alexander", "Ushakov", 23, Gender.Male),

            };
            var secondArray = new Person[]
            {
                new Person("Madara", "Uchiha", 30, Gender.Male),
                new Person("anna-maria", "Tyson", 55, Gender.Female),
                new Person("Uzumaki", "Naruto", 23, Gender.Male),
            };

            firstListOfPerson.AddPersonsArray(firstArray);
            secondListOfPerson.AddPersonsArray(secondArray);

            Console.WriteLine("2. Displaying the contents");
            ShowLists(firstListOfPerson,secondListOfPerson);
            Console.WriteLine();

            Console.WriteLine("N. Test ConsoleAdd");
           
            Console.WriteLine();
            secondListOfPerson.AddPerson(ConsoleAddPerson.ReadPerson());
            ShowLists(firstListOfPerson,secondListOfPerson);



        }

        public static void ShowLists(PersonList firstListOfPerson, PersonList secondListOfPerson)
        {
            var personLists = new PersonList[]
            {
                firstListOfPerson,
                secondListOfPerson
            };
            Console.ReadKey();
            for (int i = 0; i < personLists.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"List {i + 1}");
                Console.WriteLine();

                for (int j = 0; j < personLists[i].NumberOfPersons; j++)
                {
                    Console.WriteLine(personLists[i].FindByIndex(j).Info);
                }
            }
            Console.ReadKey();
        }
    }
}

