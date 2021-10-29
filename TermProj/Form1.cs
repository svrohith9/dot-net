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
        Button[,] btnarray;
        System.Timers.Timer t;
        int h, m, s;
        bool isPaused = true;
        bool isStarted = false;
        int counter = 1;

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
            isStarted = true;
            btnStart.Enabled = false;
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
            //            Game Matrix Display
            btnarray = new Button[,] { {this.btn11,this.btn12,this.btn13,this.btn14,this.btn15},
                                       {this.btn21,this.btn22,this.btn23,this.btn24,this.btn25},
                                       {this.btn31,this.btn32,this.btn33,this.btn34,this.btn35},
                                       {this.btn41,this.btn42,this.btn43,this.btn44,this.btn45},
                                       {this.btn51,this.btn52,this.btn53,this.btn54,this.btn55}};
            int x = random.Next(0, 5);
            int y = random.Next(0, 5);
            this.btnarray[x, y].Text = "1";
            this.btnarray[x, y].Enabled = false;

        }

        private void btn_click(Object sender, EventArgs e)
        {
            Button btnCLicked = (Button)sender;
            try
            {
                if (isStarted)
                {
                    isPaused = false;
                    //                  test button clicks
                    //                  btnCLicked.Text = "X";


                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (btnCLicked == btnarray[i, j])
                            {
                                MessageBox.Show(Text = (i.ToString() + "," + j.ToString()));
                            }

                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message.ToString());
                MessageBox.Show("Cannot calculate due to invalid input!", "ERROR");
            }
            if (isStarted && !isPaused)
            {
                isPaused = false;
            }
        }

        private void tbTimer_TextChanged(object sender, EventArgs e)
        {

        }


        public static readonly Random random = new Random();

    }
}
