using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProj
{
    public partial class Form2 : Form
    {
        public List<string> form_content { set; get; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string s in form_content)
                this.listBox1.Items.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
