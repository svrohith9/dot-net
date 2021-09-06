using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiftyRansoms
{
    public partial class frm50Randoms : Form
    {
        int press_count = 0;
        public frm50Randoms()
        {
            InitializeComponent();
        }

        private void frm50Randoms_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // "?" should be removed after the getRandom click
            if (press_count == 0)
            {
                 labRandoms.Text = "";
            }
            //limiting getRandom button click to 5 times
            if (press_count < 5)
            {
                labRandoms.Text = labRandoms.Text + generate_randoms() + "\n";
                press_count += 1;
            }
            else
            {
                labErr.Text = "Sorry, no more than 50 randoms!\nPress Clear for another round.";
            }
            
        }

        /// <summary>
        /// Generating random numbers(10 in count) with double spaces in between
        /// </summary>
        /// <returns>String </returns>
        private String generate_randoms()
        {
            string result = "";
            int[] x = {-9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int random_number = (x[(new Random()).Next(19)]);
            for (int i = 0; i < 10; i++)
            {
                int curr_random_number = (x[(new Random()).Next(19)]);
                Boolean b = true;
                //identify the repeated value and generate new random
                while(b){
                    if (random_number != curr_random_number)
                    {
                        result += Convert.ToString(curr_random_number) + "  ";
                        random_number = curr_random_number;
                        b = false;
                    }
                    else
                    {
                        random_number = curr_random_number;
                        curr_random_number = (x[(new Random()).Next(19)]);
                    }
                }
            }
            Console.WriteLine(result);
            return result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labRandoms.Text = "?";
            press_count = 0;
            labErr.Text = "";

        }
    }
}
