using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testa
{
    public partial class Form1 : Form
    {
        DateTime a = new DateTime(2016, 1, 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 7; i++)
            {
                a = a.AddDays(i);
                if (a.DayOfWeek == DayOfWeek.Saturday || a.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(a);
                }
                else
                {
                    a.AddDays(7);
                }
            }
            comboBox2.Items.Add("Januari");
            comboBox2.Items.Add("Februari");
            comboBox2.Items.Add("Maret");
            comboBox2.Items.Add("April");
            comboBox2.Items.Add("Mei");
            comboBox2.Items.Add("Juni");
            comboBox2.Items.Add("Juli");
            comboBox2.Items.Add("Agustus");
            comboBox2.Items.Add("September");
            comboBox2.Items.Add("Oktober");
            comboBox2.Items.Add("November");
            comboBox2.Items.Add("Desember");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int y;
            if (comboBox2.Text == "Januari" || comboBox2.Text == "Maret" || comboBox2.Text == "Mei" || comboBox2.Text == "Juli" || comboBox2.Text == "Agustus" || comboBox2.Text == "Oktober" || comboBox2.Text == "Desember")
            {
                comboBox1.MaxLength = 31;
                y = comboBox1.MaxLength;
            }
            else if (comboBox2.Text == "b")
            {
                comboBox1.MaxLength = 29;
                y = comboBox1.MaxLength;
            }
            else
            {
                comboBox2.MaxLength = 30;
                y = comboBox1.MaxLength;
            }
            for (int i = 1; i <= y; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
