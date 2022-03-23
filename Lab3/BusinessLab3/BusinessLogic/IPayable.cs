namespace BusinessLogic
{
    /// <summary>
    /// Интерфейс начисления копеек
    /// </summary>
    public interface IPayable
    {
        /// <summary>
        /// Метод начисления зарплаты
        /// </summary>
        double Salary();
    }
}