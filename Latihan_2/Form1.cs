using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2
{
    public partial class Form1 : Form
    {
        int bln;
        //DateTime a = new DateTime(2016, 1, 1);
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
//            monthCalendar1.FirstDayOfWeek Monday;
            //DateTime a = new DateTime(2016, 1, 1);
            for (DateTime a = new DateTime(2016,1,1); a.Year < 2017; a = a.AddDays(1))
            {

                if (a.DayOfWeek == DayOfWeek.Saturday || a.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(a);
                }
            }
            monthCalendar1.UpdateBoldedDates();
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, 03, 11));

            domainUpDown1.Items.Add("Januari");
            domainUpDown1.Items.Add("Februari");
            domainUpDown1.Items.Add("Maret");
            domainUpDown1.Items.Add("April");
            domainUpDown1.Items.Add("Mei");
            domainUpDown1.Items.Add("Juni");
            domainUpDown1.Items.Add("Juli");
            domainUpDown1.Items.Add("Agustus");
            domainUpDown1.Items.Add("September");
            domainUpDown1.Items.Add("Oktober");
            domainUpDown1.Items.Add("November");
            domainUpDown1.Items.Add("Desember");
            domainUpDown1.Text = "Bulan";
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if(domainUpDown1.Text == "Januari")
            {
                numericUpDown1.Maximum = 31;
                bln = 1;
            }
            else if (domainUpDown1.Text == "Februari")
            {
                numericUpDown1.Maximum = 29;
                bln = 2;
            }
            else if (domainUpDown1.Text == "Maret")
            {
                numericUpDown1.Maximum = 31;
                bln = 3;
            }
            else if (domainUpDown1.Text == "April")
            {
                numericUpDown1.Maximum = 30;
                bln = 4;
            }
            else if (domainUpDown1.Text == "Mei")
            {
                numericUpDown1.Maximum = 31;
                bln = 5;
            }
            else if (domainUpDown1.Text == "Juni")
            {
                numericUpDown1.Maximum = 30;
                bln = 6;
            }
            else if (domainUpDown1.Text == "Juli")
            {
                numericUpDown1.Maximum = 31;
                bln = 7;
            }
            else if (domainUpDown1.Text == "Agustus")
            {
                numericUpDown1.Maximum = 31;
                bln = 8;
            }
            else if (domainUpDown1.Text == "September")
            {
                numericUpDown1.Maximum = 30;
                bln = 9;
            }
            else if (domainUpDown1.Text == "Oktober")
            {
                numericUpDown1.Maximum = 31;
                bln = 10;
            }
            else if (domainUpDown1.Text == "November")
            {
                numericUpDown1.Maximum = 30;
                bln = 11;
            }
            else if (domainUpDown1.Text == "Desember")
            {
                numericUpDown1.Maximum = 31;
                bln = 12;
            }


            button1.Text = "Tambah";
            button2.Text = "Buang";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2017, bln, Convert.ToInt32(numericUpDown1.Value)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2017, bln, Convert.ToInt32(numericUpDown1.Value)));
        }
    }
}
