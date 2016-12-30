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

namespace Database_POS
{
    public partial class Barang : Form
    {
        // Database Connection
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=db_framework;Uid=root;Pwd=");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand query;
        public string id_barang;
        public Barang()
        {
            InitializeComponent();
            this.view_barang();
        }

        private void Barang_Load(object sender, EventArgs e)
        {

        }

        public void view_barang()
        {
            query = new MySqlCommand("select * from barang", con);
            DA = new MySqlDataAdapter(query);
            DT = new DataTable();
            DA.Fill(DT);
            barang_views.DataSource = DT;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string kodebarang = this.barang_kode.Text;
            string namabarang = this.barang_nama.Text;
            string stockbarang = this.barang_stock.Text;
            string hbelibarang = this.barang_hargabeli.Text;
            string hjualbarang = this.barang_hargajual.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("INSERT INTO barang VALUES(@id,@kode,@nama,@jstok,@hargabeli,@hargajual,@dateinsert,@dateupdate)", con);
            query.Parameters.AddWithValue("@id", null);
            query.Parameters.AddWithValue("@kode", kodebarang);
            query.Parameters.AddWithValue("@nama", namabarang);
            query.Parameters.AddWithValue("@jstok", stockbarang);
            query.Parameters.AddWithValue("@hargabeli", hbelibarang);
            query.Parameters.AddWithValue("@hargajual", hjualbarang);
            query.Parameters.AddWithValue("@dateinsert", datenow);
            query.Parameters.AddWithValue("@dateupdate", null);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Barang");
                con.Close();
                this.view_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        public static DateTime getdatetime()
        {
            DateTime getdatetime = DateTime.UtcNow;
            int year = getdatetime.Year;
            int month = getdatetime.Month;
            int day = getdatetime.Day;
            int hour = getdatetime.Hour;
            int min = getdatetime.Minute;
            int sec = getdatetime.Second;
            DateTime datetime = new DateTime(year, month, day, hour, min, sec);
            return datetime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string kode_param = this.Ekodebarang.Text;
            query = new MySqlCommand("select * from barang where kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kode_param);
            MySqlDataReader Reader = query.ExecuteReader();

            if (!Reader.HasRows)
            {
                con.Close();
                MessageBox.Show("Data Tidak Ditemukan");
                return;
            }
            if (Reader.Read())
            {
                this.id_barang = Reader["id"].ToString();
                this.Enamabarang.Text = Reader["nama"].ToString();
                this.Estockbarang.Text = Reader["stock"].ToString();
                this.Ehargabeli.Text = Reader["harga_beli"].ToString();
                this.Ehargajual.Text = Reader["harga_jual"].ToString();
            }
            Reader.Close();
            con.Close();
            //MessageBox.Show(DA..ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kodebarang = this.Ekodebarang.Text;
            string namabarang = this.Enamabarang.Text;
            string stockbarang = this.Estockbarang.Text;
            string hbelibarang = this.Ehargabeli.Text;
            string hjualbarang = this.Ehargajual.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("UPDATE barang SET Nama=@nama, Stock=@jstok, Harga_Beli=@hargabeli, Harga_Jual=@hargajual WHERE Kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kodebarang);
            query.Parameters.AddWithValue("@nama", namabarang);
            query.Parameters.AddWithValue("@jstok", stockbarang);
            query.Parameters.AddWithValue("@hargabeli", hbelibarang);
            query.Parameters.AddWithValue("@hargajual", hjualbarang);
            query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Edit Barang");
                con.Close();
                this.view_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            query = new MySqlCommand("DELETE FROM barang WHERE ID=@id", con);
            query.Parameters.AddWithValue("@id", this.id_barang);
            try
            {
                con.Open();
                query.ExecuteNonQuery();
                this.Enamabarang.Text = null;
                this.Estockbarang.Text = null;
                this.Ehargabeli.Text = null;
                this.Ehargajual.Text = null;
                MessageBox.Show("Data Berhasil di Hapus");
                con.Close();
                this.view_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kodebarang = this.Ekodebarang.Text;
            string namabarang = this.Enamabarang.Text;
            string stockbarang = this.Estockbarang.Text;
            string hbelibarang = this.Ehargabeli.Text;
            string hjualbarang = this.Ehargajual.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("UPDATE barang SET Nama=@nama, Stock=@jstok, Harga_Beli=@hargabeli, Harga_Jual=@hargajual WHERE Kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kodebarang);
            query.Parameters.AddWithValue("@nama", namabarang);
            query.Parameters.AddWithValue("@jstok", stockbarang);
            query.Parameters.AddWithValue("@hargabeli", hbelibarang);
            query.Parameters.AddWithValue("@hargajual", hjualbarang);
            query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Edit Barang");
                con.Close();
                this.view_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void barang_views_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
