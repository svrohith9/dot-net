using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermQ1
{
    public partial class MidtermQ1 : Form
    {
        public MidtermQ1()
        {
            InitializeComponent();
        }

        private static readonly Random random = new Random();

        public int randomNum;
 
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbMin.Text, out int a) && int.TryParse(tbMax.Text, out int b) && (a < b) && (a >= -10) && (b <= 10))
            {
                randomNum = random.Next(a, b + 1);
                lbRandomNum.Text = Convert.ToString(randomNum);
            }
            else
                MessageBox.Show("ERROR", "Invalid input");
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lbRandomNum.Text, out int x))
            {
                lbRandomNum.Text = Convert.ToString(x + 1);
            }
        }

        /*
         * Reset the Generated random num with the generated one.
         */

        private void button3_Click(object sender, EventArgs e)
        {
            lbRandomNum.Text = Convert.ToString(randomNum);
        }
    }
}
