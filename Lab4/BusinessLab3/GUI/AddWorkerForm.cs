using System;
using System.Text.RegularExpressions;
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
            //BUG
            switch (TypeOfSalaryBox.Text)
            {
                case _hourlyPaymentItem:
                    WorkerSending = new HourPayment(NameBox.Text, SurnameBox.Text, 0,
                        Convert.ToInt32(HoursWorkedBox.Text) , 
                        Convert.ToDouble(CostPerHourBox.Text));
                    break;
                case _ratePaymentItem:
                    WorkerSending = new RatePayment(NameBox.Text, SurnameBox.Text, 0,+
                        Convert.ToInt32(WorkedDaysRateNumeric.Text),
                        Convert.ToDouble(CostPerDayBox.Text));
                    break;
                case _tariffPaymentItem:
                    WorkerSending = new TariffPayment(NameBox.Text, SurnameBox.Text, 0,
                        Convert.ToDouble(TariffBox.Text), 
                        Convert.ToInt32(MonthWorkedDaysNumeric.Text), 
                        Convert.ToInt32(DaysWorkedTariffNumeric.Text));
                    break;
            }
            WorkerSending.Salary();
            
            SendDataFromFormEvent?.Invoke(this,new WorkerEventArgs(WorkerSending));
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
        
        /// <summary>
        /// Вввод имени и фамилии только на РУССКОМ!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// Выбор типа оплаты в боксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Проверка полей на ввод
        /// только целочисленных значений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckTextBoxInt(object sender, KeyPressEventArgs e)
        {
            char numberInt = e.KeyChar;
            if (!Char.IsDigit(numberInt) && numberInt != 8)
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// Ограничение по текстбоксу на ввод цифр c запятой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckTextBox(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            var eKey = (KeyPressEventArgs)e;

            if (char.IsNumber(eKey.KeyChar))
            {
                if (textBox.Text.Length == 1)
                {
                    if (textBox.Text.Contains("0") && eKey.KeyChar != ',')
                    {
                        eKey.Handled = true;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            if (char.IsControl(eKey.KeyChar) ||
                !string.IsNullOrEmpty(textBox.Text) && eKey.KeyChar == ',' && !textBox.Text.Contains(","))
            {
                return;
            }
            eKey.Handled = true;
        }

        /// <summary>
        /// Событие добавления рандом работяги на клик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllRandomButton_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var chosePayment = rnd.Next(3);

            WorkerSending = chosePayment switch
            {
                0 => RandomWorker.GetRandomHourWorker(),
                1 => RandomWorker.GetRandomRateWorker(),
                2 => RandomWorker.GetRandomTariffWorker(),
                _ => WorkerSending
            };
            WorkerSending.Salary();
            SendDataFromFormEvent?.Invoke(this, new WorkerEventArgs(WorkerSending));
        }
    }
}
