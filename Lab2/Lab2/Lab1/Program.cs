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
            //BUG: system. encoding
            Console.WriteLine("Попробуй нажать любую кнопку...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Генерация 7 рандомных персон :)");
            Console.WriteLine();
            Console.ReadKey();

            var listOfPersons = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                listOfPersons.AddPerson(RandomPerson.CreateRandomPerson());
            }

            Console.WriteLine("Список успешно создан!");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Рандомный лист персон:\n");

            for (int i = 0; i < listOfPersons.NumberOfPersons; i++)
            {
                Console.ReadKey();
                Console.WriteLine(listOfPersons.FindByIndex(i).Info);
                Console.WriteLine();
            }

        }

    }
}

