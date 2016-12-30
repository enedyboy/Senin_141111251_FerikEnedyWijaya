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
    public partial class Costumer : Form
    {
        // Database Connection
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=db_framework;Uid=root;Pwd=");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand query;
        public string ID_costumer;

        public Costumer()
        {
            InitializeComponent();
            this.view_customer();
        }

        private void Costumer_Load(object sender, EventArgs e)
        {

        
        }

        public void view_customer()
        {
            query = new MySqlCommand("select * from customer", con);
            DA = new MySqlDataAdapter(query);
            DT = new DataTable();
            DA.Fill(DT);
            barang_views.DataSource = DT;
        }

        private void barang_views_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_barang_button_Click(object sender, EventArgs e)
        {
            string nama = this.namakostumer.Text;
            string alamat = this.alamatkostumer.Text;
            string nohp = this.nokostumer.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("INSERT INTO customer VALUES(@id,@nama,@alamat, @nohp, @gender, @dateinsert, @dateupdate)", con);
            query.Parameters.AddWithValue("@id", null);
            query.Parameters.AddWithValue("@nama", nama);
            query.Parameters.AddWithValue("@alamat", alamat);
            query.Parameters.AddWithValue("@nohp", nama);
            query.Parameters.AddWithValue("@gender", null);
            query.Parameters.AddWithValue("@dateinsert", datenow);
            query.Parameters.AddWithValue("@dateupdate", null);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Costumer");
                con.Close();
                this.view_customer();
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

        private void cek_costumer_Click(object sender, EventArgs e)
        {
            con.Open();
            string id_param = this.Eidkostumer.Text;
            //MessageBox.Show(id_param);
            query = new MySqlCommand("SELECT * FROM customer WHERE ID=@kode", con);
            query.Parameters.AddWithValue("@kode", id_param);
            MySqlDataReader Reader = query.ExecuteReader();

            if (!Reader.HasRows)
            {
                con.Close();
                MessageBox.Show("Data Tidak Ditemukan");
                return;
            }
            if (Reader.Read())
            {
                this.ID_costumer = Reader["id"].ToString();
                this.Enamakostumer.Text = Reader["Nama"].ToString();
                this.Ealamatkostumer.Text = Reader["Alamat"].ToString();
                this.Enokostumer.Text = Reader["NoHp"].ToString();
            }
            Reader.Close();
            con.Close();
            //MessageBox.Show(DA..ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = this.Enamakostumer.Text;
            this.ID_costumer = this.Eidkostumer.Text;
            string alamat = this.Ealamatkostumer.Text;
            string nohp = this.Enokostumer.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("UPDATE customer SET Nama=@nama, Alamat=@alamat, NoHp=@nohp, Editied_at=@dateupdate WHERE ID=@id", con);
            query.Parameters.AddWithValue("@id", this.ID_costumer);
            query.Parameters.AddWithValue("@nama", nama);
            query.Parameters.AddWithValue("@alamat", alamat);
            query.Parameters.AddWithValue("@nohp", nohp);
            query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Costumer");
                con.Close();
                this.view_customer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            query = new MySqlCommand("DELETE FROM customer WHERE ID=@id", con);
            query.Parameters.AddWithValue("@id", this.ID_costumer);
            try
            {
                con.Open();
                query.ExecuteNonQuery();
                this.Eidkostumer.Text = null;
                this.Enamakostumer.Text = null;
                this.Ealamatkostumer.Text = null;
                this.Enokostumer.Text = null;
                MessageBox.Show("Data Berhasil di Hapus");
                con.Close();
                this.view_customer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
