using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TermProj
{

    public partial class Game : Form
    {
        Form2 form2;
        Form3 form3;
        Form4 form4;
        string game_history_path = @"c:\gamedata\history.txt";
        //path for the solutions
        //string solutions_src_path = @"c:\Users\svroh\Desktop\myUSF\Advanced objected programming\apps\dot-net-win-forms\TermProj\GameSolutions\";
        string currentDirectory = System.IO.Directory.GetCurrentDirectory();
        int initial_x = -1, initial_y = -1;
        List<string> gamedata = new List<string>();
        int gameid = 0;
        string starttime = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
        Button[,] btnarray;
        int[,] showSol = new int[5, 5];
        System.Timers.Timer t;
        int h, m, s;
        bool isPaused = true;
        bool isStarted = false;
        string currentSavedTime = "";
        //      btn number counter
        int counter = 1;
        List<String> scores_list = new List<string>();
        Button currentButton;

        public Game()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearScreen()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    btnarray[i, j].Text = "";
                    btnarray[i, j].Enabled = true;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (initial_x >= 0 && initial_y >= 0)
                clearScreen();
            isPaused = false;
            isStarted = true;
            btnStart.Enabled = false;
            gameid++;
            starttime = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
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
            initial_x = x;
            initial_y = y;
            this.btnarray[x, y].Text = "1";
            counter = 1;
            this.btnarray[x, y].Enabled = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int[,] getSolution(string sol_path)
        {
            string[] dir = currentDirectory.Split(new String[] { "TermProj" }, StringSplitOptions.None);
            string[] lines = System.IO.File.ReadAllLines(dir[0]+ @"TermProj\GameSolutions\" + sol_path);
            int[,] result = new int[5, 5];

            string[] arr = lines[0].Split(',');
            int[] xyz = Array.ConvertAll(arr, x => int.Parse(x));
            int t = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    result[i, j] = xyz[t++];
                }
            }
            return result;
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            if (initial_x >= 0 && initial_y >= 0 && btnarray[initial_x, initial_y].Text == "1")
            {
                if (initial_x == 0 && initial_y == 0)
                {
                    showSol = getSolution("TextFile1.txt");

                }
                if (initial_x == 0 && initial_y == 1)
                {
                    showSol = getSolution("TextFile2.txt");

                }
                if (initial_x == 0 && initial_y == 2)
                {
                    showSol = getSolution("TextFile3.txt");

                }
                if (initial_x == 0 && initial_y == 3)
                {
                    showSol = getSolution("TextFile4.txt");

                }
                if (initial_x == 0 && initial_y == 4)
                {
                    showSol = getSolution("TextFile5.txt");

                }
                if (initial_x == 1 && initial_y == 0)
                {
                    showSol = getSolution("TextFile6.txt");

                }
                if (initial_x == 1 && initial_y == 1)
                {
                    showSol = getSolution("TextFile7.txt");

                }
                if (initial_x == 1 && initial_y == 2)
                {
                    showSol = getSolution("TextFile8.txt");

                }
                if (initial_x == 1 && initial_y == 3)
                {
                    showSol = getSolution("TextFile9.txt");

                }
                if (initial_x == 1 && initial_y == 4)
                {
                    showSol = getSolution("TextFile10.txt");

                }
                if (initial_x == 2 && initial_y == 0)
                {
                    showSol = getSolution("TextFile11.txt");

                }
                if (initial_x == 2 && initial_y == 1)
                {
                    showSol = getSolution("TextFile12.txt");

                }
                if (initial_x == 2 && initial_y == 2)
                {
                    showSol = getSolution("TextFile13.txt");

                }
                if (initial_x == 2 && initial_y == 3)
                {
                    showSol = getSolution("TextFile14.txt");

                }
                if (initial_x == 2 && initial_y == 4)
                {
                    showSol = getSolution("TextFile15.txt");

                }
                if (initial_x == 3 && initial_y == 0)
                {
                    showSol = getSolution("TextFile16.txt");

                }
                if (initial_x == 3 && initial_y == 1)
                {
                    showSol = getSolution("TextFile17.txt");

                }
                if (initial_x == 3 && initial_y == 2)
                {
                    showSol = getSolution("TextFile18.txt");

                }
                if (initial_x == 3 && initial_y == 3)
                {
                    showSol = getSolution("TextFile19.txt");

                }
                if (initial_x == 3 && initial_y == 4)
                {
                    showSol = getSolution("TextFile20.txt");

                }
                if (initial_x == 4 && initial_y == 0)
                {
                    showSol = getSolution("TextFile21.txt");

                }
                if (initial_x == 4 && initial_y == 1)
                {
                    showSol = getSolution("TextFile22.txt");

                }
                if (initial_x == 4 && initial_y == 2)
                {
                    showSol = getSolution("TextFile23.txt");

                }
                if (initial_x == 4 && initial_y == 3)
                {
                    showSol = getSolution("TextFile24.txt");

                }
                if (initial_x == 4 && initial_y == 4)
                {
                    showSol = getSolution("TextFile25.txt");

                }
                gamedata.Add("  Game Exited    " + starttime + "   " + tbTimer.Text.ToString());

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        btnarray[i, j].Text = showSol[i, j].ToString();
                    }
                }
            }
            isPaused = true;
            this.btnStart.Enabled = true;
            s = m = h = 0;
            this.resetTimer();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            //save game data and show dialog
            if (tbTimer.Text != "00:00:00")
                gamedata.Add("  Game Aborted  " + starttime + "   " + tbTimer.Text.ToString());
            if (initial_x >= 0 && initial_y >= 0)
            {
                isPaused = true;
                s = m = h = 0;
                resetTimer();
                clearScreen();
                btnStart.Enabled = true;
                btnarray[initial_y, initial_y].Enabled = true;
            }
            return;

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            TextWriter tw = null;
            List<string> strs = new List<string>();

            string path = game_history_path;
            if (!File.Exists(path))
            {
                File.Create(path);
                tw = new StreamWriter(path);
            }
            else if (File.Exists(path))
            {
                tw = new StreamWriter(path, true);
            }

            foreach (string s in gamedata)
            {
                tw.WriteLine("Game#" + generateID() + "" + s);
            }
            gamedata.Clear();
            tw.Close();

            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (string line in lines)
            {
                strs.Add(line);
            }

            tw.Close();
            form2.form_content = strs;
            form2.ShowDialog();
        }

        public string generateID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 5);
        }

        private FileStream FileStream(string path, FileMode openOrCreate)
        {
            throw new NotImplementedException();
        }

        private void btn_click(Object sender, EventArgs e)
        {
            Button btnCLicked = (Button)sender;
            try
            {
                if (isStarted)
                {
                    if (counter != 0 && counter != 25 && tbTimer.Text != "00:00:00")
                        isPaused = false;
                    //                  test button clicks
                    //                  btnCLicked.Text = "X";

                    if (int.TryParse(btnCLicked.Text.ToString(), out int ctBtn) && ctBtn == counter && ctBtn > 1 && ctBtn < 25)
                    {
                        counter = counter - 1;
                        btnCLicked.Text = "".ToString();
                    }
                    else
                    {


                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (int.TryParse(btnarray[i, j].Text, out int x) && x == counter)
                                {
                                    currentButton = btnCLicked;
                                    if (i == 0 && j == 0)
                                    {
                                        if (btnCLicked.Text == "" && (btnCLicked == btnarray[i, j + 1]) || (btnCLicked == btnarray[i + 1, j]) || (btnCLicked == btnarray[i + 1, j + 1]))
                                        {
                                            btnCLicked.Text = (++counter).ToString();
                                            break;
                                        }
                                        //MessageBox.Show(Text = (i.ToString() + "," + j.ToString()));
                                    }
                                    else if (i == 4 && j == 4 && btnCLicked.Text == "")
                                    {
                                        if ((btnCLicked == btnarray[i - 1, j - 1]) || (btnCLicked == btnarray[i - 1, j]) || (btnCLicked == btnarray[i, j - 1]))
                                        {
                                            btnCLicked.Text = (++counter).ToString();
                                            break;
                                        }
                                    }
                                    else if (j == 4 && i > 0 && btnCLicked.Text == "")
                                    {
                                        if ((btnCLicked == btnarray[i - 1, j - 1]) || (btnCLicked == btnarray[i - 1, j]) ||
                                            (btnCLicked == btnarray[i, j - 1]) ||
                                            (btnCLicked == btnarray[i + 1, j]) || (btnCLicked == btnarray[i + 1, j - 1]))

                                        {
                                            btnCLicked.Text = (++counter).ToString();
                                            break;
                                        }
                                    }
                                    else if (i == 4 && j > 0 && btnCLicked.Text == "")
                                    {
                                        if ((btnCLicked == btnarray[i - 1, j - 1]) ||
                                            (btnCLicked == btnarray[i, j - 1]) ||
                                            (btnCLicked == btnarray[i - 1, j]) ||
                                            (btnCLicked == btnarray[i - 1, j + 1]) ||
                                            (btnCLicked == btnarray[i, j + 1]))
                                        {
                                            btnCLicked.Text = (++counter).ToString();
                                            break;
                                        }
                                    }
                                    else if (i == 0 && j > 0 && btnCLicked.Text == "")
                                    {
                                        if (j == 4)
                                        {
                                            if ((btnCLicked == btnarray[i, j - 1]) || (btnCLicked == btnarray[i + 1, j]) || (btnCLicked == btnarray[i + 1, j - 1]))
                                            {
                                                btnCLicked.Text = (++counter).ToString();
                                                break;
                                            }
                                        }
                                        else if ((btnCLicked == btnarray[i, j - 1]) || (btnCLicked == btnarray[i + 1, j]) || (btnCLicked == btnarray[i + 1, j - 1]) || (btnCLicked == btnarray[i, j + 1]) || (btnCLicked == btnarray[i + 1, j + 1])
                                            )
                                        {
                                            btnCLicked.Text = (++counter).ToString();
                                            break;
                                        }
                                    }
                                    else if (i > 0 && j == 0 && btnCLicked.Text == "")
                                    {
                                        if (i == 4)
                                        {
                                            if ((btnCLicked == btnarray[i - 1, j]) || (btnCLicked == btnarray[i - 1, j + 1]) || (btnCLicked == btnarray[i, j + 1]))
                                            {
                                                btnCLicked.Text = (++counter).ToString();
                                                break;
                                            }
                                        }
                                        else if ((btnCLicked == btnarray[i - 1, j + 1]) ||
                                            (btnCLicked == btnarray[i, j + 1]) ||
                                            (btnCLicked == btnarray[i + 1, j]) ||
                                            (btnCLicked == btnarray[i + 1, j + 1]) || (btnCLicked == btnarray[i - 1, j]))
                                        {
                                            btnCLicked.Text = (++counter).ToString();
                                            break;
                                        }

                                    }
                                    else if (i > 0 && j > 0 && i < 4 && j < 4 && btnCLicked.Text == "")
                                    {
                                        if ((btnCLicked == btnarray[i - 1, j - 1]) || (btnCLicked == btnarray[i - 1, j]) || (btnCLicked == btnarray[i - 1, j + 1]) ||
                                            (btnCLicked == btnarray[i, j - 1]) || (btnCLicked == btnarray[i, j + 1]) ||
                                            (btnCLicked == btnarray[i + 1, j - 1]) || (btnCLicked == btnarray[i + 1, j]) || (btnCLicked == btnarray[i + 1, j + 1]))
                                        {
                                            btnCLicked.Text = (++counter).ToString();
                                            break;
                                        }
                                    }
                                }
                                if (counter == 25)
                                {
                                    currentSavedTime = tbTimer.Text.ToString();
                                    Console.WriteLine("::::::TIME TO FINISH::::::", currentSavedTime);
                                    isPaused = true;
                                    btnStart.Enabled = true;
                                    counter = 0;
                                    gamedata.Add("  Game Won      " + starttime + "   " + tbTimer.Text.ToString());
                                    //MessageBox.Show("You Won!", "Congratulations");
                                    form3 = new Form3();
                                    form3.SetFormHeading("Congratulations");
                                    form3.SetLabel("You Won!");
                                    form3.ShowDialog();

                                    clearScreen();
                                    s = m = h = 0;
                                    resetTimer();

                                    if (form3.getData() == "Quit")
                                    {
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        btnStart_Click(sender, e);
                                    }


                                }
                            }
                        }
                    }
                    if (!IsNotLockedSituation(btnCLicked) && counter > 1 && counter < 25)
                    {
                        currentSavedTime = tbTimer.Text.ToString();
                        Console.WriteLine("::::::TIME TO FINISH::::::", currentSavedTime);
                        isPaused = true;
                        btnStart.Enabled = true;
                        counter = 0;
                        gamedata.Add("  Game Lost       " + starttime + "   " + tbTimer.Text.ToString());
                        //MessageBox.Show("You Lost!", "Game Over");
                        clearScreen();
                        s = m = h = 0;
                        resetTimer();

                        form3 = new Form3();
                        form3.SetFormHeading("Game Over");
                        form3.SetLabel("You Lost!");
                        form3.ShowDialog();


                        if (form3.getData() == "Quit")
                        {
                            Application.Exit();
                        }
                        else
                        {
                            btnStart_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message.ToString());
                MessageBox.Show("Cannot calculate due to invalid operation!", "ERROR");
            }
            if (isStarted && !isPaused)
            {
                isPaused = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
        }

        private bool IsNotLockedSituation(Button btn)
        {
            bool res = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (btn == btnarray[i, j])
                    {
                        if (i > 0 && j > 0 && btnarray[i - 1, j - 1].Text == "")
                            res = true;
                        else if (i > 0 && btnarray[i - 1, j].Text == "")
                            res = true;
                        else if (i > 0 && j < 4 && btnarray[i - 1, j + 1].Text == "")
                            res = true;
                        else if (j > 0 && btnarray[i, j - 1].Text == "")
                            res = true;
                        else if (j < 4 && btnarray[i, j + 1].Text == "")
                            res = true;
                        else if (i < 4 && j > 0 && btnarray[i + 1, j - 1].Text == "")
                            res = true;
                        else if (i < 4 && btnarray[i + 1, j].Text == "")
                            res = true;
                        else if (i < 4 && j < 4 && btnarray[i + 1, j + 1].Text == "")
                            res = true;
                    }
                }
            }
            return res;

            //Console.WriteLine(counter + "::::" + i + "," + j);
        }

        private void tbTimer_TextChanged(object sender, EventArgs e)
        {

        }

        public static readonly Random random = new Random();
    }
}
