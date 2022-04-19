﻿using System;
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
        public event EventHandler<WorkerEventArgs> SendDataFromFormEvent; 

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


        private Dictionary<string, Func<WorkerBase, Form>> _paymentFormDictionary =
            new Dictionary<string, Func<WorkerBase, Form>>()
            {
                { _hourlyPaymentItem, (workerBase) => new HourPaymentForm((HourPayment) workerBase) },
                { _ratePaymentItem, (workerBase) => new RatePaymentForm((RatePayment) workerBase) },
                { _tariffPaymentItem, (workerBase) => new TariffPaymentForm((TariffPayment) workerBase)}
            };

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

            ButtonEnabler_TextChanged(this, EventArgs.Empty);
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
            var tmpFormFunc = _paymentFormDictionary[TypeOfSalaryBox.Text];
            var workerRate = new RatePayment("a", "b", 1.0, 0, 0);
            var workerTariff = new TariffPayment("a", "b",0, 0, 0, 0);
            var workerHour = new HourPayment("a", "b", 1.0, 0, 0);
            ///? Несколько Invoke
            var tmpFormRate = tmpFormFunc.Invoke(workerRate);


            tmpFormRate.ShowDialog();
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
    }
}