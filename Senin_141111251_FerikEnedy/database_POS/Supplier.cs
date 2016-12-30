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
    public partial class Supplier : Form
    {

        // Database Connection
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=db_framework;Uid=root;Pwd=");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand query;
        public string ID_supplier;

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

        public Supplier()
        {
            InitializeComponent();
            this.view_supplier();
        }

        private void update_supllier_Click(object sender, EventArgs e)
        {
            string kode = this.Ekodesupllier.Text;
            string nama = this.Enamasupllier.Text;
            string alamat = this.Ealamatsupllier.Text;
            string nohp = this.Enosupllier.Text;
            string kota = this.Ekotasupllier.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("UPDATE supplier SET Nama=@nama, Alamat=@alamat, Kota=@kota, Contact=@nohp, Edit_at=@dateupdate WHERE ID=@id", con);
            query.Parameters.AddWithValue("@id", this.ID_supplier);
            query.Parameters.AddWithValue("@kode", kode);
            query.Parameters.AddWithValue("@nama", nama);
            query.Parameters.AddWithValue("@alamat", alamat);
            query.Parameters.AddWithValue("@kota", kota);
            query.Parameters.AddWithValue("@nohp", nohp);
            query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Edit Supplier");
                con.Close();
                view_supplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void view_supplier()
        {
            query = new MySqlCommand("select * from supplier", con);
            DA = new MySqlDataAdapter(query);
            DT = new DataTable();
            DA.Fill(DT);
            supplier_views.DataSource = DT;
        }

        private void simpan_supplier_Click(object sender, EventArgs e)
        {
            string kode = this.kodesupllier.Text;
            string nama = this.namasupllier.Text;
            string alamat = this.alamatsupllier.Text;
            string nohp = this.nosupllier.Text;
            string kota = this.kotasupllier.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("INSERT INTO supplier VALUES(@id,@kode, @nama,@alamat, @kota, @nohp,  @dateinsert, @datejoin, @dateupdate)", con);
            query.Parameters.AddWithValue("@id", null);
            query.Parameters.AddWithValue("@kode", kode);
            query.Parameters.AddWithValue("@nama", nama);
            query.Parameters.AddWithValue("@alamat", alamat);
            query.Parameters.AddWithValue("@kota", kota);
            query.Parameters.AddWithValue("@nohp", nohp);
            query.Parameters.AddWithValue("@dateinsert", datenow);
            query.Parameters.AddWithValue("@datejoin", datenow);
            query.Parameters.AddWithValue("@dateupdate", null);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Supplier");
                con.Close();
                view_supplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void cek_supllier_Click(object sender, EventArgs e)
        {
            con.Open();
            string kode_param = this.Ekodesupllier.Text;
            query = new MySqlCommand("SELECT * FROM supplier WHERE kode=@kode", con);
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
                this.ID_supplier = Reader["id"].ToString();
                this.Enamasupllier.Text = Reader["nama"].ToString();
                this.Ealamatsupllier.Text = Reader["alamat"].ToString();
                this.Enosupllier.Text = Reader["contact"].ToString();
                this.Ekotasupllier.Text = Reader["kota"].ToString();
            }
            Reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            query = new MySqlCommand("DELETE FROM supplier WHERE ID=@id", con);
            query.Parameters.AddWithValue("@id", this.ID_supplier);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                this.Enamasupllier.Text = null;
                this.Ekodesupllier.Text = null;
                this.Ealamatsupllier.Text = null;
                this.Enosupllier.Text = null;
                this.Ekotasupllier.Text = null;
                MessageBox.Show("Data Berhasil di Hapus");
                con.Close();
                view_supplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
