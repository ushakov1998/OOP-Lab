using System;
using BusinessLogic;

namespace GUI
{
    /// <summary>
    /// Аргумент передачи данных в событиях
    /// </summary>
    public class WorkerEventArgs : EventArgs
    {

        private WorkerBase _sendingWorker;

        /// <summary>
        /// Worker для передачи
        /// </summary>
        public WorkerBase SendingWorker
        {
            get => _sendingWorker;
            private set
            {
                _sendingWorker = value;
            }
        }

        /// <summary>
        /// Конструктор для передачи Worker
        /// </summary>
        /// <param name="sendingWorker">Работяга</param>
        public WorkerEventArgs(WorkerBase sendingWorker)
        {
            SendingWorker = sendingWorker;
        }

    }
}