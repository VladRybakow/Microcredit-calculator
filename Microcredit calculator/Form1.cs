using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microcredit_calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double Sum =  Convert.ToDouble(Amount.Text);
            int days = Convert.ToInt32(Days.Text);
            string percents = Convert.ToString(Percent);

            double[] SumPer = Percent.Text.Split(' ').Select(x => double.Parse(x)).ToArray();
            var SumPersent = percents.Where(x => char.IsDigit(x)).Sum(x => char.GetNumericValue(x));
            SumPersent = SumPersent / 10 / days;

            if (Sum > 500000)
            {
                MessageBox.Show("Сумма превышает возможную выдачу микрокретида");
                Application.Restart();
            }

            if (days > 0 || days > 365)
            {
                MessageBox.Show("Количество дней не соответсвует правилам нашей компании");
                Application.Restart();
            }

            foreach (var sub in SumPer)
            {
                TotalPayout.Text = Convert.ToString((Sum / 100) * SumPersent * days + Sum);
                InterestAmount.Text = Convert.ToString(((Sum / 100) * SumPersent * days + Sum) - Sum);
            }
        }

        private void Percent_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalPayout_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void InterestAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
