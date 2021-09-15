using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            string operand = optTxt.Text;
            if ((operand == "+" || operand == "-" || operand == "/" || operand == "*")&&(Decimal.TryParse(opd1Txt.Text,out num1))&& (Decimal.TryParse(opd2Txt.Text, out num2)))
            {
                resTxt.Text = Calculate(num1, num2, operand).ToString();
            }
            else
                MessageBox.Show("Cannot calculate due to invalid input!", "ERROR");
            opd1Txt.Focus();
        }

        private decimal Calculate(decimal op1, decimal op2, String op)
        {
            decimal result;
            if (op == "+")
                result = op1 + op2;
            else if (op == "-")
                result = op1 - op2;
            else if (op == "/")
                result = op1 / op2;
            else
                result = op1 * op2;

            return Math.Round(result,4);
        }

        private void opd1Txt_TextChanged(object sender, EventArgs e)
        {
            resTxt.Text = "";
        }
    }
}
