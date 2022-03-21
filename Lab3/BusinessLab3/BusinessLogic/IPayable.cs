namespace BusinessLogic
{
    /// <summary>
    /// Интерфейс начисления копеек
    /// </summary>
    public interface IPayable
    {
        /// <summary>
        /// Зарплата
        /// </summary>
        decimal Salary { get; }
    }
}