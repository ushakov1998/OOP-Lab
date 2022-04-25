using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace GUI
{
    public partial class AddWorkerForm : Form
    {
        /// <summary>
        /// Событие для передачи данных
        /// </summary>
        public EventHandler<WorkerEventArgs> SendDataFromFormEvent; 

        /// <summary>
        /// Почасовая оплата
        /// </summary>
        private const string _hourlyPaymentItem = "Почасовая";

        /// <summary>
        /// Оплата по ставке
        /// </summary>
        private const string _ratePaymentItem = "Ставка";

        /// <summary>
        /// Оплата по окладу
        /// </summary>
        private const string _tariffPaymentItem = "Оклад";

        private WorkerBase WorkerSending { get; set; }


        /// <summary>
        /// Конструктор формы
        /// </summary>
        public AddWorkerForm()
        {
            InitializeComponent();
            TypeOfSalaryBox.Items.Add(_hourlyPaymentItem);
            TypeOfSalaryBox.Items.Add(_ratePaymentItem);
            TypeOfSalaryBox.Items.Add(_tariffPaymentItem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            PerHourGroupBox.Visible = false;
            TariffGroupBox.Visible = false;
            RateGroupBox.Visible = false;

            
            NameBox.TextChanged += ButtonEnabler_TextChanged;
            SurnameBox.TextChanged += ButtonEnabler_TextChanged;
            TypeOfSalaryBox.SelectedIndexChanged += ButtonEnabler_TextChanged;

        }

        /// <summary>
        /// Кнопка далее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            switch (TypeOfSalaryBox.Text)
            {
                case _hourlyPaymentItem:
                    WorkerSending = new HourPayment(NameBox.Text, SurnameBox.Text, 0,
                        Convert.ToInt32(HoursWorkedBox.Text) , Convert.ToDouble(CostPerHourBox.Text));
                    break;
                case _ratePaymentItem:
                    WorkerSending = new RatePayment(NameBox.Text, SurnameBox.Text, 0,+
                        Convert.ToInt32(WorkedDaysRateNumeric.Text), Convert.ToDouble(CostPerDayBox));
                    break;
                case _tariffPaymentItem:
                    WorkerSending = new TariffPayment(NameBox.Text, SurnameBox.Text, 0,
                        Convert.ToDouble(TariffBox.Text), Convert.ToInt32(MonthWorkedDaysNumeric.Text), 
                        Convert.ToInt32(DaysWorkedTariffNumeric.Text));
                    break;
            }
            WorkerSending.Salary();
            SendDataFromFormEvent.Invoke(this,new WorkerEventArgs(WorkerSending));
        }

        /// <summary>
        /// Делает кнопку активной при заполнение полней
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnabler_TextChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = NameBox.Text.Length > 0 
                                 && SurnameBox.Text.Length > 0 
                                 && TypeOfSalaryBox.SelectedIndex >= 0;
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string letterPattern = @"[^а-я^ё^А-Я^Ё^-]";
            const string hyphenPattern = @"-";
            Regex letterRegex = new Regex(letterPattern);
            Regex hyphenRegex = new Regex(hyphenPattern);
            if (hyphenRegex.Matches(NameBox.Text).Count < 1)
            {
                if (letterRegex.IsMatch(e.KeyChar.ToString())
                    && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((letterRegex.IsMatch(e.KeyChar.ToString())
                     || hyphenRegex.IsMatch(e.KeyChar.ToString()))
                    && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void TypeOfSalaryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeOfSalaryBox.Text)
            {
                case _hourlyPaymentItem:
                    PerHourGroupBox.Visible = true;
                    RateGroupBox.Visible = false;
                    TariffGroupBox.Visible = false;
                    break;
                case _ratePaymentItem:
                    RateGroupBox.Visible = true;
                    TariffGroupBox.Visible = false;
                    PerHourGroupBox.Visible = false;
                    break;
                case _tariffPaymentItem:
                    TariffGroupBox.Visible = true;
                    RateGroupBox.Visible = false;
                    PerHourGroupBox.Visible = false;
                    break;
            }
        }

        private void CheckTextBox(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && e.KeyChar != (char) Keys.Back && e.KeyChar != 44)
            {
                e.Handled = true;
            }

        }
    }
}
