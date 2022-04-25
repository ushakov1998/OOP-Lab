using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace GUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Лист работников
        /// </summary>
        private BindingList<WorkerBase> _workersList = new BindingList<WorkerBase>();

        /// <summary>
        /// Текст для запроса
        /// </summary>
        private string _searchBoxDefaultText = "Введите запрос...";

        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DataGridWorkers.DataSource = _workersList;
        }
        ///
        private void AddWorker_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm();
            addWorkerForm.SendDataFromFormEvent += (O, Args) =>
            {
                _workersList.Add(Args.SendingWorker);
            };
            addWorkerForm.ShowDialog();
        }


        /// <summary>
        /// Вывод листа в DataGrid
        /// </summary>
        private void ShowList()
        {
            DataGridWorkers.DataSource = null;
            DataGridWorkers.DataSource = _workersList;
        }

        /// <summary>
        /// Кнопнка - удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveWorker_Click(object sender, EventArgs e)
        {
            if (!(DataGridWorkers.CurrentRow is null))
            {
                var workerToRemove = DataGridWorkers.CurrentRow.DataBoundItem;
                _workersList.Remove((WorkerBase) workerToRemove);
                ShowList();
            }
        }

        /// <summary>
        /// Событие при активном поле поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text != _searchBoxDefaultText) return;

            SearchBox.Text = "";
            SearchBox.ForeColor = Color.Black;
        }

        /// <summary>
        /// Событие при не активном поле поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text != "") return;
            SearchBox.Text = _searchBoxDefaultText;
            SearchBox.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Клик по сохранению
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files(*.xml)|*.xml|All files(*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                try
                {
                    /*Serializer.SaveFile(_workersList, path);*/
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception.Message}");
                }
            }
        }

        /// <summary>
        /// Клик по загрузке файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new SaveFileDialog
            {
                Filter = "Text files(*.xml)|*.xml|All files(*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName.ToString();
                try
                {
                    /*_workersList = Serializer.OpenFile(path);*/
                    ShowList();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception.Message}");
                }
            }

        }
    }
}
