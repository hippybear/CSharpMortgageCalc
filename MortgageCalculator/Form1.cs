//-----------------------------------------------------------------
//   Description:    Simple mortgage calculator
//   Author:         @hippybear     Date: 7/17/17
//   Notes:          More features coming feel free to email me
//                   to request more...
//
//   Payments = Loan ( intRate(1 + intRate)^months ) / ( (1 + intRate)^months - 1 )
// 
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//   Payments = Loan ( intRate(1 + intRate)^months ) / ( (1 + intRate)^months - 1 )
            var loan = 0;
            var loanAmount = int.TryParse(textBox1.Text, out loan);

            var years = 0;
            var monthsText = int.TryParse(textBox2.Text, out years);

            var interestRate = 0;
            var interestRateText = int.TryParse(textBox3.Text, out interestRate);
            var months = years / 12.0;

            var payments = (interestRate * Math.Pow((1 + interestRate), months)) / (Math.Pow((1 + interestRate), months) - 1);

            textBox4.Text = payments.ToString();
        }
    }
}
