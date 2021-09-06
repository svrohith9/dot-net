using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class frmCalculateScores : Form
    {
        ///global varibles 
        double score_total = 0;
        int score_count = 0;
        double average = 0;

        public frmCalculateScores()
        {
            InitializeComponent();
 
        }

        private void frmCalculateScores_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Calculation logic

            int score = Int32.Parse(txtScore.Text);
            score_count += 1;
            score_total += score;
            average = score_total / score_count;
            txtTotal.Text = score_total.ToString();
            txtAverage.Text = average.ToString();
            txtCount.Text = score_count.ToString();

            txtScore.Focus();
            txtScore.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset whole screen to inital view by manually placing empty strings in text windows

            score_count = 0;
            score_total = 0;
            average = 0;
            txtScore.Text = "";
            txtTotal.Text = "";
            txtAverage.Text = "";
            txtCount.Text = "";
        }

    }
}
