using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class Transaksi : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=db_framework;Uid=root;Pwd=");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand query;

        //Pembelian
        public string kd_pembelian;
        public string id_barang_pembelian;
        public string id_supplier_pembelian;
        public int kuantiti;
        public double hasil;

        //Pejualan
        public string kd_penjualan;
        public string id_barang_pejualan;
        public string id_customer_penjualan;
        public int kuantiti_jual;
        public double hasil_penjualan;



        

    }
}
