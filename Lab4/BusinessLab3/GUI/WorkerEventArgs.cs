using System;
using BusinessLogic;

namespace GUI
{
    /// <summary>
    /// Аргумент передачи данных в событиях
    /// </summary>
    public class WorkerEventArgs : EventArgs
    {
        /// <summary>
        /// Worker для передачи
        /// </summary>
        public WorkerBase SendingWorker { get; }

        /// <summary>
        /// Конструктор для передачи Worker
        /// </summary>
        /// <param name="sendingWorker">Работяга</param>
        public WorkerEventArgs(WorkerBase sendingWorker)
        {
            SendingWorker = sendingWorker ?? throw new Exception("Null!!!!!");
        }

    }
}