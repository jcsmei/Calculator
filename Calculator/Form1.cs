using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        double number1 = 0;
        double number2 = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) && double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 + number2).ToString();
                lblOperator.Text = "+";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1)  && double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 - number2).ToString();
                lblOperator.Text = "-";
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1)  && double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 * number2).ToString();
                lblOperator.Text = "*";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) && double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 / number2).ToString();
                lblOperator.Text = "/";
            }
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) && double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 % number2).ToString();
                lblOperator.Text = "%";
            }
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) && double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = Math.Pow(number1, number2).ToString();
                lblOperator.Text = "^";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblOperator.Text = "";
            lblSolution.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
