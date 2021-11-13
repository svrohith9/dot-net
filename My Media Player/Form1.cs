using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Media_Player
{
    public partial class Form1 : Form
    {
        string path = @"C:\Media\";
        Dictionary<string, string> mediaFiles = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPath.Text.ToString() != "")
                    path += tbPath.Text.ToString();
                else
                    throw new Exception("No file name is entered");
                if (radioButton1.Checked == true && radioButton2.Checked == false && radioButton3.Checked == false)
                    path += ".avi";
                else if (radioButton1.Checked == false && radioButton2.Checked == true && radioButton3.Checked == false)
                    path += ".mp4";
                else if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == true)
                    path += ".wmv";
                else
                    throw new Exception("None of the three radio buttons is selected.");

                if (mediaFiles.ContainsKey(tbPath.Text.ToString()))
                    throw new Exception("Duplicate value entered");

                mediaFiles.Add(tbPath.Text.ToString(), path);
                this.listBox1.Items.Add(tbPath.Text.ToString());
                tbPath.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                path = @"C:\Media\";
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), "Error");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = "";
            try
            {
                if (listBox1.SelectedIndex == -1)
                    throw new Exception("No file is selected");
                else
                {
                    Console.WriteLine(listBox1.SelectedItem);
                    this.mediaFiles.Remove(listBox1.SelectedItem.ToString());
                    this.listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), "Error");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Add("Cartoon");
            this.listBox1.Items.Add("Wildlife");

            this.mediaFiles.Add("Cartoon", @"C:\Media\Cartoon.avi");
            this.mediaFiles.Add("Wildlife", @"C:\Media\Wildlife.wmv");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex == -1)
                    throw new Exception("No file is selected");
                else
                {
                    if (this.mediaFiles.TryGetValue(this.listBox1.SelectedItem.ToString(), out string url))
                        axWindowsMediaPlayer1.URL = url;
                    else
                        throw new Exception("No File Found");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), "Error");
            }

        }
    }
}
