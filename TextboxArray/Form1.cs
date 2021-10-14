using System;
using System.Windows.Forms;

namespace TextboxArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox[,] tbarray;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int boxesWithNumber = 0;
            int? sumOfBoxes = 0;
            decimal? avg = 0.0m;
            int? maxBox = Int32.MinValue;
            int? minBox = Int32.MaxValue;

            tbarray = new TextBox[,] { { this.textBox00, this.textBox01, this.textBox02 },
                                       { this.textBox10, this.textBox11, this.textBox12 },
                                       { this.textBox20, this.textBox21, this.textBox22 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        if (tbarray[i, j].Text != "")
                        {
                            int currentNumber = Int32.Parse(tbarray[i, j].Text);
                            sumOfBoxes += currentNumber;
                            boxesWithNumber += 1;
                            if (currentNumber >= maxBox)
                                maxBox = currentNumber;
                            if (currentNumber <= minBox)
                                minBox = currentNumber;
                        }
                    }
                    catch (FormatException exp)
                    {
                        tbarray[i, j].Text = "";
                        //Passing current Textbox Obj to Focus it
                        FocusTextBox(tbarray[i, j], e);

                        Console.WriteLine(exp.Message.ToString());
                    }

                    /*
                     * Handling divide-by-zero exception
                     */
                    try
                    {
                        avg = Math.Round(Decimal.Divide((decimal)sumOfBoxes, boxesWithNumber) * 1.00m, 2);
                    }
                    catch (Exception exp)
                    {
                        tbarray[i, j].Text = "";
                        Console.WriteLine(exp.Message.ToString());
                    }
                    if (boxesWithNumber != 0)
                    {
                        this.labelZeros.Text = boxesWithNumber.ToString();
                        this.labelMin.Text = minBox.ToString();
                        this.labelMax.Text = maxBox.ToString();
                    }
                    else
                    {
                        this.labelZeros.Text = boxesWithNumber.ToString();
                        this.labelMin.Text = "0";
                        this.labelMax.Text = "0";
                    }
                    this.labelSum.Text = sumOfBoxes.ToString();
                    this.labelAvg.Text = avg.ToString();
                }
            }
        }

        private void FocusTextBox(Object sender, EventArgs e)
        {
            TextBox btnCLicked = (TextBox)sender;
            btnCLicked.Focus();

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBox00.Text = "";
            this.textBox01.Text = "";
            this.textBox02.Text = "";
            this.textBox10.Text = "";
            this.textBox11.Text = "";
            this.textBox12.Text = "";
            this.textBox20.Text = "";
            this.textBox21.Text = "";
            this.textBox22.Text = "";

            this.labelZeros.Text = "0";
            this.labelMin.Text = "?";
            this.labelMax.Text = "?";
            this.labelSum.Text = "?";
            this.labelAvg.Text = "?";

            this.textBox00.Focus();
        }
    }
}

