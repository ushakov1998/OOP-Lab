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
        private PersonBase[] _personArray = new PersonBase[0];

        /// <summary>
        /// Количество всех персон
        /// </summary>
        public int NumberOfPersons => _personArray.Length;

        /// <summary>
        /// Добавление человека в список
        /// </summary>
        /// <param name="person">Экземпляр класса персона</param>
        public void AddPerson(PersonBase person)
        {
            var tempArray = _personArray;
            _personArray = new PersonBase[tempArray.Length + 1];
            
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
            if (CheckRangeOfIndex(index))
            {
                var tempArray = _personArray;
                var tempIndex = 0;
                _personArray = new PersonBase[tempArray.Length - 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (i == index) continue;

                    _personArray[tempIndex] = tempArray[i];
                    tempIndex++;
                }

            };
            
        }
        /// <summary>
        /// Проверка на валидность индекса
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckRangeOfIndex(int index)
        {
            if (index < 0 || index >= _personArray.Length)
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }

            return true;
        }

        /// <summary>
        /// Поиск элемента по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Значение по указанному индексу</returns>
        public PersonBase FindByIndex(int index)
        {
            CheckRangeOfIndex(index);
            return _personArray[index];
        }
        
        /// <summary>
        /// Добавление нескольких персон
        /// </summary>
        /// <param name="persons">Массив людей</param>
        public void AddArrayOfPeople(PersonBase[] persons)
        {
            foreach (PersonBase person in persons)
            {
                AddPerson(person);
            }
        }
    }
}
