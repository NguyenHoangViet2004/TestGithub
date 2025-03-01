using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double soa = Double.Parse(textBox1.Text);
            double sob = Double.Parse(textBox2.Text);
            label4.Text = (soa + sob).ToString();
            int a = 0;
        }
    }
}
