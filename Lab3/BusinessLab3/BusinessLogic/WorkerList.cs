using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class WorkerList
    {
        /// <summary>
        /// Список работяг
        /// </summary>
        private WorkerBase[] _workersArray = new WorkerBase[0];

        /// <summary>
        /// Добавление работяги в список
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(WorkerBase person)
        {
            var tempArray = _workersArray;
            _workersArray = new WorkerBase[tempArray.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                _workersArray[i] = tempArray[i];
            }

            _workersArray[tempArray.Length] = person;
        }

        /// <summary>
        /// Количество всех персон
        /// </summary>
        public int NumberOfPersons => _workersArray.Length;

        /// <summary>
        /// Поиск элемента по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Значение по указанному индексу</returns>
        public WorkerBase FindByIndex(int index)
        {
            return _workersArray[index];
        }
    }
}
