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
    public partial class HourPaymentForm : Form
    {
        private HourPayment _hourPayment;
        public HourPaymentForm(HourPayment hourPayment)
        {
            _hourPayment = hourPayment;
            InitializeComponent();
            NextButtonHour.Enabled = false;
            HoursWorkedBox.TextChanged += ButtonEnabler_TextChanged;
            CostPerHourBox.TextChanged += ButtonEnabler_TextChanged;
        }

        private void NextButtonHour_Click(object sender, EventArgs e)
        {
            _hourPayment.HoursWorked = Int32.Parse(HoursWorkedBox.Text);
            _hourPayment.CostPerHour = Double.Parse(CostPerHourBox.Text);
        }

        private void ButtonEnabler_TextChanged(object sender, EventArgs e)
        {
            NextButtonHour.Enabled = HoursWorkedBox.Text.Length > 0
                                     && CostPerHourBox.Text.Length > 0;

        }
    }
}
