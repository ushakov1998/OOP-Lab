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
    public partial class TariffPaymentForm : Form
    {
        private TariffPayment _tariffPayment;
        public TariffPaymentForm(TariffPayment tariffPayment)
        {
            _tariffPayment = tariffPayment;
            InitializeComponent();
            NextButtonTariff.Enabled = false;
            DaysWorked.TextChanged += ButtonEnabler_TextChanged;
            WorkingDaysInMonth.TextChanged += ButtonEnabler_TextChanged;
            Tariff.TextChanged += ButtonEnabler_TextChanged;
        }

        private void NextButtonTariff_Click(object sender, EventArgs e)
        {
            _tariffPayment.DaysWorked = Int32.Parse(DaysWorked.Text);
            _tariffPayment.WorkingDaysInMonth = Int32.Parse(WorkingDaysInMonth.Text);
            _tariffPayment.Tariff = Double.Parse(Tariff.Text);
        }

        private void ButtonEnabler_TextChanged(object sender, EventArgs e)
        {
            NextButtonTariff.Enabled = DaysWorked.Text.Length > 0
                                     && WorkingDaysInMonth.Text.Length > 0 
                                     && Tariff.Text.Length > 0;
        }
    }
}
