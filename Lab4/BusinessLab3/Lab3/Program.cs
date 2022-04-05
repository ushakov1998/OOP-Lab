using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            var listOfWorkers = new List<WorkerBase>
            {
                RandomWorker.GetRandomHourWorker(),
                RandomWorker.GetRandomRateWorker(),
                RandomWorker.GetRandomTariffWorker()
            };

            List<WorkerBase>[] lists = {listOfWorkers};

            Console.WriteLine("Создадим лист с 3-мя видами работяг");
            ShowListOfWorkers(lists);

            foreach (var worker in listOfWorkers)
            {
                worker.Salary();
            }

            Console.WriteLine("Начислим их $ и посмотрим список :)");
            ShowListOfWorkers(lists);
            
            static void ShowListOfWorkers(List<WorkerBase>[] lists)
            {
                for (var i = 0; i < lists.Length; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"List {i + 1}");
                    Console.WriteLine();
                    for (var j = 0; j < lists[i].Count; j++)
                    {
                        Console.WriteLine(lists[i][j].Info());
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}