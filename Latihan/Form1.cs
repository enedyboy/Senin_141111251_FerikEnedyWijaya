using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer form_customer = new Customer();
            form_customer.MdiParent = this;
            form_customer.Show();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaksi form_transaksi = new Transaksi();
            form_transaksi.MdiParent = this;
            form_transaksi.Show();
        }

    }
}
