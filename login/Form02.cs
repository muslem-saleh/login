using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form02 : Form
    {
        public Form02()
        {
            InitializeComponent();
        }

        private void Form02_Load(object sender, EventArgs e)
        {
            textBox1.Text = fomLogin.str_name;
        }
    }
}
