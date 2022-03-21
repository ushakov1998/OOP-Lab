using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Класс для проверки введенных значений
    /// </summary>
    public static class Validation
    {
        /// <summary>
        /// Проверка десячтичных чисел
        /// </summary>
        /// <param name="value"></param>
        public static void ValidDecimalNumber(decimal value)
        {
            const int lowerLimit = 0;
            if (value < lowerLimit)
            {
                ExceptionGenerator(lowerLimit);
            }
        }

        /// <summary>
        /// Метод для проверки натуральных чисел
        /// </summary>
        /// <param name="value"></param>
        public static void ValidIntNumber(int value)
        {
            const int lowerLimit = 1;
            if (value < lowerLimit)
            {
                ExceptionGenerator(lowerLimit);
            }
        }

        /// <summary>
        /// Генератор исключений
        /// </summary>
        /// <param name="lowerLimit">Параметр для отображения границы</param>
        /// <returns></returns>
        public static Exception ExceptionGenerator(int lowerLimit)
        {
            throw new ArgumentException($"Значение не может быть меньше {lowerLimit}!");
        }
    }
}
