using System;
using System.Collections.Generic;
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

            firstListOfPerson.AddArrayOfPeople(firstArray);
            secondListOfPerson.AddArrayOfPeople(secondArray);

            Console.WriteLine("2. Displaying the contents");
            ShowLists(firstListOfPerson, secondListOfPerson);
            Console.WriteLine();

            Console.WriteLine("3. Add a new person to the first list");
            firstListOfPerson.AddPerson(new Person("Gretta", "Tumberg", 96, Gender.Female));
            ShowLists(firstListOfPerson, secondListOfPerson);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("4. Copy the second person from the first list" + 
                              " to the end of the second list");
            secondListOfPerson.AddPerson(firstListOfPerson.FindByIndex(1));
            ShowLists(firstListOfPerson, secondListOfPerson);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("5. Delete the second person from the first list!");
            firstListOfPerson.DeleteByIndex(1);
            ShowLists(firstListOfPerson, secondListOfPerson);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("6. Clear the first list");
            firstListOfPerson.DeleteAllPerson();
            ShowLists(firstListOfPerson, secondListOfPerson);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("7. Add new person to the first list " +
                              "from keyboard");
            Console.WriteLine();
            firstListOfPerson.AddPerson(ConsoleAddPerson.ReadPerson());
            ShowLists(firstListOfPerson, secondListOfPerson);
            Console.WriteLine();
            Console.ReadKey();





            //Console.WriteLine();
            //secondListOfPerson.AddPerson(ConsoleAddPerson.ReadPerson());
            //ShowLists(firstListOfPerson,secondListOfPerson);



        }

        /// <summary>
        /// Вывод списка персон
        /// </summary>
        /// <param name="listsOfPerson">Массив списков</param>
        public static void ShowLists(params PersonList[] listsOfPerson)
        {
            Console.ReadKey();
            for (int i = 0; i < listsOfPerson.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"List {i + 1}");
                Console.WriteLine();

                for (int j = 0; j < listsOfPerson[i].NumberOfPersons; j++)
                {
                    Console.WriteLine(listsOfPerson[i].FindByIndex(j).Info);
                }
            }
            Console.ReadKey();
        }
    }
}

