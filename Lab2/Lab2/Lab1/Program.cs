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
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            //BUG: system. encoding+
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

            Console.ReadKey();
            Console.WriteLine("Четвертая персона это....?");

            switch (listOfPersons.FindByIndex(3))
            {
                case Adult adult:
                {
                    Console.WriteLine(adult.LowBackPain());
                    break;
                }

                case Child child:
                {
                    Console.WriteLine(child.LoveGachi());
                    break;
                }
            }

            Console.ReadKey();
            Console.WriteLine();
        }

    }
}

