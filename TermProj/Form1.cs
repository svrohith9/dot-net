using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TermProj
{
    public partial class Game : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        bool isPaused = true;
        public Game()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isPaused = false;
            gameMatrix();
        }

           private void resetTimer()
        {
            tbTimer.Text = string.Format("00:00:00");
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                tbTimer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
               // Console.WriteLine(tbTimer.Text.ToString());
            }
        }

        private void gameMatrix()
        {
            //Game Matrix Display

            for(int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    //Button btn = new Button();
                    TextBox tb = new TextBox();
                    tb.Font=new Font("Microsoft Sans Serif", 18F);
                    tb.Size = new Size(35, 35);
                    tb.Text = j.ToString();
                    tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
                    flowLayoutPanel1.Controls.Add(tb);
                }
            }
        }

        private void tbTimer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
