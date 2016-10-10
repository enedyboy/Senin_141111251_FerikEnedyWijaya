using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = vScrollBar1.Value.ToString();
            int a = vScrollBar1.Value;
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-a);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = vScrollBar2.Value.ToString();

            int b = vScrollBar2.Value;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(b);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
