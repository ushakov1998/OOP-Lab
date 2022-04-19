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
        public WorkerBase SendingWorker { get; private set; }

        /// <summary>
        /// Конструктор для передачи Worker
        /// </summary>
        /// <param name="sendingWorker">Работяга</param>
        public WorkerEventArgs(WorkerBase sendingWorker)
        {
            if (sendingWorker != null)
            {
                this.SendingWorker = sendingWorker;
            }
        }

    }
}