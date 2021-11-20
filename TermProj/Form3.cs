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
    public partial class Form3 : Form
    {
        string data = "";

        public Form3()
        {
            InitializeComponent();
        }
        public void SetLabel(string s)
        {
            this.label1.Text = s;
        }
        public void SetFormHeading(string s)
        {
            this.Text = s;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btnCLicked = (Button)sender;
            this.data = btnCLicked.Text.ToString();
            this.Close();
        }
        
        public string getData()
        {
            return data;
        }

    }
}
