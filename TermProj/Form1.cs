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
        string solutions_src_path = @"C:\Users\svroh\Desktop\myUSF\Advanced objected programming\apps\dot-net-win-forms\TermProj\GameSolutions\";
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
            //var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            string[] lines = System.IO.File.ReadAllLines(solutions_src_path + sol_path);
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
                    //showSol = getSolution("TextFile1.txt");
                    showSol = new int[5, 5] { { 1, 16, 15, 14, 13 },
                                          { 2, 17, 18, 19, 12 },
                                          { 3, 24, 25, 20, 11 },
                                          { 4, 23, 22, 21, 10 },
                                          { 5, 6, 7, 8, 9 } };
                }
                if (initial_x == 0 && initial_y == 1)
                {
                    //showSol = getSolution("TextFile2.txt");
                    showSol = new int[5, 5] { { 16, 1, 2, 3, 4 },
                                              { 15, 17, 18, 19, 5 },
                                              { 14, 24, 25, 20, 6 },
                                              { 13, 23, 22, 21, 7 },
                                              { 12, 11, 10, 9, 8 } };
                }
                if (initial_x == 0 && initial_y == 2)
                {
                    //showSol = getSolution("TextFile3.txt");
                    showSol = new int[5, 5] { { 15, 16, 1, 2, 3 },
                                              { 14, 17, 24, 23, 4 },
                                              { 13, 18, 25, 22, 5 },
                                              { 12, 19, 20, 21, 6 },
                                              { 11, 10, 9, 8, 7 } };
                }
                if (initial_x == 0 && initial_y == 3)
                {
                    //showSol = getSolution("TextFile4.txt");
                    showSol = new int[5, 5] { { 14, 15, 16, 1, 2 },
                                              { 13, 17, 24, 23, 3 },
                                              { 12, 18, 25, 22, 4 },
                                              { 11, 19, 20, 21, 5 },
                                              { 10, 9, 8, 7, 6 } };
                }
                if (initial_x == 0 && initial_y == 4)
                {
                    //showSol = getSolution("TextFile5.txt");
                    showSol = new int[5, 5] { { 14, 15, 16, 2, 1 },
                                              { 13, 17, 24, 23, 3 },
                                              { 12, 18, 25, 22, 4 },
                                              { 11, 19, 20, 21, 5 },
                                              { 10, 9, 8, 7, 6 } };
                }
                if (initial_x == 1 && initial_y == 0)
                {
                    //showSol = getSolution("TextFile6.txt");
                    showSol = new int[5, 5] { { 2, 3, 4, 5, 6 },
                                              { 1, 17, 18, 19, 7 },
                                              { 16, 24, 25, 20, 8 },
                                              { 15, 23, 22, 21, 9 },
                                              { 14, 13, 12, 11, 10 } };
                }
                if (initial_x == 1 && initial_y == 1)
                {
                    //showSol = getSolution("TextFile7.txt");
                    showSol = new int[5, 5] { { 25, 2, 3, 4, 5 },
                                              { 24, 1, 14, 13, 6 },
                                              { 23, 22, 15, 12, 7 },
                                              { 21, 20, 16, 11, 8 },
                                              { 19, 18, 17, 10, 9 } };
                }
                if (initial_x == 1 && initial_y == 2)
                {
                    //showSol = getSolution("TextFile8.txt");
                    showSol = new int[5, 5] { { 21, 20, 2, 3, 4 },
                                              { 22, 19, 1, 5, 6 },
                                              { 23, 18, 17, 8, 7 },
                                              { 24, 16, 15, 10, 9 },
                                              { 25, 14, 13, 12, 11 } };
                }
                if (initial_x == 1 && initial_y == 3)
                {
                    //showSol = getSolution("TextFile9.txt");
                    showSol = new int[5, 5] { { 25, 16, 15, 2, 3 },
                                              { 24, 17, 14, 1, 4 },
                                              { 24, 18, 13, 6, 5 },
                                              { 22, 19, 12, 8, 7 },
                                              { 21, 20, 11, 10, 9 } };
                }
                if (initial_x == 1 && initial_y == 4)
                {
                    //showSol = getSolution("TextFile10.txt");
                    showSol = new int[5, 5] { { 12, 13, 14, 15, 16 },
                                              { 11, 23, 22, 17, 1 },
                                              { 10, 24, 23, 18, 2 },
                                              { 9, 25, 20, 19, 3 },
                                              { 8, 7, 6, 5, 4 } };
                }
                if (initial_x == 2 && initial_y == 0)
                {
                    //showSol = getSolution("TextFile11.txt");
                    showSol = new int[5, 5] { { 3, 4, 5, 6, 7 },
                                              { 2, 23, 22, 21, 8 },
                                              { 1, 24, 25, 20, 9 },
                                              { 16, 17, 18, 19, 10 },
                                              { 15, 14, 13, 12, 11 } };
                }
                if (initial_x == 2 && initial_y == 1)
                {
                    //showSol = getSolution("TextFile12.txt");
                    showSol = new int[5, 5] { { 25, 3, 4, 5, 6 },
                                              { 24, 2, 15, 14, 7 },
                                              { 23, 1, 16, 13, 8 },
                                              { 22, 20, 17, 12, 9 },
                                              { 21, 19, 18, 11, 10 } };
                }
                if (initial_x == 2 && initial_y == 2)
                {
                    //showSol = getSolution("TextFile13.txt");
                    showSol = new int[5, 5] { { 21, 20, 3, 4, 5 },
                                              { 22, 19, 2, 8, 6 },
                                              { 23, 18, 1, 9, 7 },
                                              { 24, 17, 15, 11, 10 },
                                              { 25, 16, 14, 13, 12 } };
                }
                if (initial_x == 2 && initial_y == 3)
                {
                    //showSol = getSolution("TextFile14.txt");
                    showSol = new int[5, 5] { { 25, 16, 15, 3, 4 },
                                              { 24, 17, 14, 2, 5 },
                                              { 23, 18, 13, 1, 6 },
                                              { 22, 19, 12, 9, 7 },
                                              { 21, 20, 11, 10, 8 } };
                }
                if (initial_x == 2 && initial_y == 4)
                {
                    //showSol = getSolution("TextFile15.txt");
                    showSol = new int[5, 5] { { 13, 12, 11, 10, 8 },
                                              { 14, 23, 22, 9, 7 },
                                              { 15, 24, 21, 6, 1 },
                                              { 16, 25, 20, 5, 2 },
                                              { 17, 18, 19, 4, 3 } };
                }
                if (initial_x == 3 && initial_y == 0)
                {
                    //showSol = getSolution("TextFile16.txt");
                    showSol = new int[5, 5] { { 4, 5, 6, 7, 8 },
                                              { 3, 23, 22, 21, 9 },
                                              { 2, 24, 25, 20, 10 },
                                              { 1, 17, 18, 19, 11 },
                                              { 16, 15, 14, 13, 12 } };
                }
                if (initial_x == 3 && initial_y == 1)
                {
                    //showSol = getSolution("TextFile17.txt");
                    showSol = new int[5, 5] { { 5, 4, 15, 16, 17 },
                                              { 6, 3, 14, 19, 18 },
                                              { 7, 2, 13, 21, 20 },
                                              { 8, 1, 12, 23, 22 },
                                              { 9, 10, 11, 25, 24 } };
                }
                if (initial_x == 3 && initial_y == 2)
                {
                    //showSol = getSolution("TextFile18.txt");
                    showSol = new int[5, 5] { { 21, 20, 4, 5, 6 },
                                              { 22, 19, 3, 7, 8 },
                                              { 23, 18, 2, 10, 9 },
                                              { 24, 17, 1, 12, 11 },
                                              { 25, 16, 15, 14, 13 } };
                }
                if (initial_x == 3 && initial_y == 3)
                {
                    //showSol = getSolution("TextFile19.txt");
                    showSol = new int[5, 5] { { 11, 12, 13, 14, 15 },
                                              { 10, 22, 23, 24, 16 },
                                              { 9, 21, 25, 18, 17 },
                                              { 8, 20, 19, 1, 2 },
                                              { 7, 6, 5, 4, 3 } };
                }
                if (initial_x == 3 && initial_y == 4)
                {
                    //showSol = getSolution("TextFile20.txt");
                    showSol = new int[5, 5] { { 10, 11, 12, 13, 14 },
                                              { 9, 21, 22, 23, 15 },
                                              { 8, 20, 25, 24, 16 },
                                              { 7, 19, 18, 17, 1 },
                                              { 6, 5, 4, 3, 2 } };
                }
                if (initial_x == 4 && initial_y == 0)
                {
                    //showSol = getSolution("TextFile21.txt");
                    showSol = new int[5, 5] { { 5, 6, 7, 8, 9 },
                                              { 4, 19, 20, 21, 10 },
                                              { 3, 18, 25, 22, 11 },
                                              { 2, 17, 24, 23, 12 },
                                              { 1, 16, 15, 14, 13 } };
                }
                if (initial_x == 4 && initial_y == 1)
                {
                    //showSol = getSolution("TextFile22.txt");
                    showSol = new int[5, 5] { { 12, 11, 10, 9, 8 },
                                              { 13, 23, 22, 21, 7 },
                                              { 14, 24, 25, 20, 6 },
                                              { 15, 17, 18, 19, 5 },
                                              { 16, 1, 2, 3, 4 } };
                }
                if (initial_x == 4 && initial_y == 2)
                {
                    //showSol = getSolution("TextFile23.txt");
                    showSol = new int[5, 5] { { 11, 10, 9, 8, 7 },
                                              { 12, 23, 22, 21, 6 },
                                              { 13, 24, 25, 20, 5 },
                                              { 13, 17, 18, 19, 4 },
                                              { 15, 16, 1, 2, 3 } };
                }
                if (initial_x == 4 && initial_y == 3)
                {
                    //showSol = getSolution("TextFile24.txt");
                    showSol = new int[5, 5] { { 10, 9, 8, 7, 6 },
                                              { 11, 21, 20, 19, 5 },
                                              { 12, 22, 25, 18, 4 },
                                              { 13, 23, 24, 17, 3 },
                                              { 14, 15, 16, 1, 2 } };
                }
                if (initial_x == 4 && initial_y == 4)
                {
                    //showSol = getSolution("TextFile25.txt");
                    showSol = new int[5, 5] { { 9, 8, 7, 6, 5 },
                                              { 10, 21, 21, 19, 4 },
                                              { 11, 22, 25, 18, 3 },
                                              { 12, 23, 24, 17, 2 },
                                              { 13, 14, 15, 16, 1 } };
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
