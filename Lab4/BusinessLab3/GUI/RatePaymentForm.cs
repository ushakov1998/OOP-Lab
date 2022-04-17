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
    public partial class RatePaymentForm : Form
    {
        public RatePaymentForm()
        {
            InitializeComponent();
            NextButtonRate.Enabled = false;
            DaysWorkedBox.TextChanged += ButtonEnabler_TextChanged;
            CostPerDayBox.TextChanged += ButtonEnabler_TextChanged;
        }
        /// <summary>
        /// ???
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonRate_Click(object sender, EventArgs e)
        {
            var Salary = new RatePayment()
            {
                DaysWorked = Int32.Parse(DaysWorkedBox.Text),
                CostPerDay = Double.Parse(CostPerDayBox.Text)
            };

        }

        private void ButtonEnabler_TextChanged(object sender, EventArgs e)
        {
            NextButtonRate.Enabled = DaysWorkedBox.Text.Length > 0
                                     && CostPerDayBox.Text.Length > 0;

        }
    }
}
