using System;

namespace Model
{
    /// <summary>
    /// Класс: список персон
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список людей
        /// </summary>
        private Person[] _personArray = new Person[0];

        /// <summary>
        /// Количество всех персон
        /// </summary>
        public int NumberOfPersons
        {
            get
            { 
                return _personArray.Length;
            }
            
        }

        /// <summary>
        /// Добавление человека в список
        /// </summary>
        /// <param name="person">Экземпляр класса персона</param>
        public void AddPerson(Person person)
        {
            var tempArray = _personArray;
            _personArray = new Person[tempArray.Length + 1];
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                _personArray[i] = tempArray[i];
            }

            _personArray[tempArray.Length] = person;

        }

        /// <summary>
        /// Очищение списка
        /// </summary>
        public void DeleteAllPerson()
        {
            Array.Resize(ref _personArray,0);
        }

        /// <summary>
        /// Удаляет персону по индексу
        /// </summary>
        /// <param name="index">индекс</param>
        public void DeleteByIndex(int index)
        {
            if (index < 0 || index > _personArray.Length - 1)
            {
                throw new Exception(" You entered an invalid index!");
            }

            var tempArray = _personArray;
            var tempIndex = 0;

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (i != index)
                {
                    _personArray[tempIndex] = tempArray[i];
                    tempIndex++;
                }
            }

        }

        /// <summary>
        /// Поиск элемента по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Значение по указанному индексу</returns>
        public Person FindByIndex(int index)
        {
            if (index >= 0 && index < _personArray.Length)
            {
                return _personArray[index];
            }
            else
            {
                throw new Exception("The index doesn't exist!");
            }
        }

        
        public void AddPersonsArray(Person[] persons)
        {
            foreach (Person person in persons)
            {
                AddPerson(person);
            }
        }




    }
}
