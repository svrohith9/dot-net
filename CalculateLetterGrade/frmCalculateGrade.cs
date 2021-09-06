using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numGrade = int.Parse(txtInput.Text);
            if (numGrade >= 90 && numGrade <= 100)
                txtOuput.Text = "A";
            else if(numGrade<90 && numGrade>=80)
                txtOuput.Text = "B";
            else if (numGrade < 80 && numGrade >= 70)
                txtOuput.Text = "C";
            else if (numGrade < 70 && numGrade >= 60)
                txtOuput.Text = "D";
            else if (numGrade < 60 && numGrade >= 0)
                txtOuput.Text = "F";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
