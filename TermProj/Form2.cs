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
        public string form_heading { set; get; }
        public string form_content { set; get; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = this.form_heading.ToString();
            this.label1.Text = this.form_content.ToString();
        }
    }
}
