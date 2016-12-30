namespace Database_POS
{
    partial class Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cek_supplier = new System.Windows.Forms.Button();
            this.string_supplier = new System.Windows.Forms.Label();
            this.string_barang = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.simpan = new System.Windows.Forms.Button();
            this.hargatotal_pembelian = new System.Windows.Forms.TextBox();
            this.hargabeli_pembelian = new System.Windows.Forms.TextBox();
            this.kuantiti_pembelian = new System.Windows.Forms.TextBox();
            this.kodesupplier_pembelian = new System.Windows.Forms.TextBox();
            this.kodebarang_pembelian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.views_penjualan = new System.Windows.Forms.DataGridView();
            this.cekcustomer_jual = new System.Windows.Forms.Button();
            this.string_customer_jual = new System.Windows.Forms.Label();
            this.string_barang_jual = new System.Windows.Forms.Label();
            this.cekbarang_jual = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.hargatotal_penjualan = new System.Windows.Forms.TextBox();
            this.hargajual_penjualan = new System.Windows.Forms.TextBox();
            this.kuantiti_penjualan = new System.Windows.Forms.TextBox();
            this.idcostumer_penjualan = new System.Windows.Forms.TextBox();
            this.kode_penjualan = new System.Windows.Forms.TextBox();
            this.kode_barang_penjualan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.views_data = new System.Windows.Forms.DataGridView();
            this.kode_pembelian = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_penjualan)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_data)).BeginInit();
            this.SuspendLayout();
            // 
            // cek_supplier
            // 
            this.cek_supplier.Location = new System.Drawing.Point(357, 80);
            this.cek_supplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cek_supplier.Name = "cek_supplier";
            this.cek_supplier.Size = new System.Drawing.Size(67, 28);
            this.cek_supplier.TabIndex = 34;
            this.cek_supplier.Text = "Cek Supplier";
            this.cek_supplier.UseVisualStyleBackColor = true;
            this.cek_supplier.Click += new System.EventHandler(this.cek_supplier_Click);
            // 
            // string_supplier
            // 
            this.string_supplier.AutoSize = true;
            this.string_supplier.Location = new System.Drawing.Point(354, 86);
            this.string_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.string_supplier.Name = "string_supplier";
            this.string_supplier.Size = new System.Drawing.Size(70, 17);
            this.string_supplier.TabIndex = 33;
            this.string_supplier.Text = "(Supplier)";
            // 
            // string_barang
            // 
            this.string_barang.AutoSize = true;
            this.string_barang.Location = new System.Drawing.Point(538, 557);
            this.string_barang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.string_barang.Name = "string_barang";
            this.string_barang.Size = new System.Drawing.Size(64, 17);
            this.string_barang.TabIndex = 32;
            this.string_barang.Text = "(Barang)";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(353, 47);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 28);
            this.button5.TabIndex = 30;
            this.button5.Text = "Cek Barang";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(215, 211);
            this.simpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(111, 42);
            this.simpan.TabIndex = 29;
            this.simpan.Text = "Tambah";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // hargatotal_pembelian
            // 
            this.hargatotal_pembelian.Location = new System.Drawing.Point(292, 181);
            this.hargatotal_pembelian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hargatotal_pembelian.Name = "hargatotal_pembelian";
            this.hargatotal_pembelian.ReadOnly = true;
            this.hargatotal_pembelian.Size = new System.Drawing.Size(152, 22);
            this.hargatotal_pembelian.TabIndex = 24;
            // 
            // hargabeli_pembelian
            // 
            this.hargabeli_pembelian.Location = new System.Drawing.Point(292, 150);
            this.hargabeli_pembelian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hargabeli_pembelian.Name = "hargabeli_pembelian";
            this.hargabeli_pembelian.ReadOnly = true;
            this.hargabeli_pembelian.Size = new System.Drawing.Size(152, 22);
            this.hargabeli_pembelian.TabIndex = 25;
            // 
            // kuantiti_pembelian
            // 
            this.kuantiti_pembelian.Location = new System.Drawing.Point(292, 117);
            this.kuantiti_pembelian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kuantiti_pembelian.Name = "kuantiti_pembelian";
            this.kuantiti_pembelian.ReadOnly = true;
            this.kuantiti_pembelian.Size = new System.Drawing.Size(53, 22);
            this.kuantiti_pembelian.TabIndex = 26;
            this.kuantiti_pembelian.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kuantiti_pembelian_KeyUp);
            // 
            // kodesupplier_pembelian
            // 
            this.kodesupplier_pembelian.Location = new System.Drawing.Point(292, 83);
            this.kodesupplier_pembelian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kodesupplier_pembelian.Name = "kodesupplier_pembelian";
            this.kodesupplier_pembelian.ReadOnly = true;
            this.kodesupplier_pembelian.Size = new System.Drawing.Size(53, 22);
            this.kodesupplier_pembelian.TabIndex = 27;
            // 
            // kodebarang_pembelian
            // 
            this.kodebarang_pembelian.Location = new System.Drawing.Point(292, 48);
            this.kodebarang_pembelian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kodebarang_pembelian.Name = "kodebarang_pembelian";
            this.kodebarang_pembelian.Size = new System.Drawing.Size(53, 22);
            this.kodebarang_pembelian.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Harga Beli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kode Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kuantiti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kode Barang";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.views_penjualan);
            this.tabPage2.Controls.Add(this.cekcustomer_jual);
            this.tabPage2.Controls.Add(this.string_customer_jual);
            this.tabPage2.Controls.Add(this.string_barang_jual);
            this.tabPage2.Controls.Add(this.cekbarang_jual);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.hargatotal_penjualan);
            this.tabPage2.Controls.Add(this.hargajual_penjualan);
            this.tabPage2.Controls.Add(this.kuantiti_penjualan);
            this.tabPage2.Controls.Add(this.idcostumer_penjualan);
            this.tabPage2.Controls.Add(this.kode_penjualan);
            this.tabPage2.Controls.Add(this.kode_barang_penjualan);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(519, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Penjualan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // views_penjualan
            // 
            this.views_penjualan.AllowUserToAddRows = false;
            this.views_penjualan.AllowUserToDeleteRows = false;
            this.views_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.views_penjualan.Location = new System.Drawing.Point(10, 270);
            this.views_penjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.views_penjualan.Name = "views_penjualan";
            this.views_penjualan.Size = new System.Drawing.Size(502, 213);
            this.views_penjualan.TabIndex = 55;
            // 
            // cekcustomer_jual
            // 
            this.cekcustomer_jual.Location = new System.Drawing.Point(329, 85);
            this.cekcustomer_jual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cekcustomer_jual.Name = "cekcustomer_jual";
            this.cekcustomer_jual.Size = new System.Drawing.Size(66, 28);
            this.cekcustomer_jual.TabIndex = 54;
            this.cekcustomer_jual.Text = "Cek Customer";
            this.cekcustomer_jual.UseVisualStyleBackColor = true;
            this.cekcustomer_jual.Click += new System.EventHandler(this.cekcustomer_jual_Click);
            // 
            // string_customer_jual
            // 
            this.string_customer_jual.AutoSize = true;
            this.string_customer_jual.Location = new System.Drawing.Point(213, 466);
            this.string_customer_jual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.string_customer_jual.Name = "string_customer_jual";
            this.string_customer_jual.Size = new System.Drawing.Size(78, 17);
            this.string_customer_jual.TabIndex = 53;
            this.string_customer_jual.Text = "(Customer)";
            // 
            // string_barang_jual
            // 
            this.string_barang_jual.AutoSize = true;
            this.string_barang_jual.Location = new System.Drawing.Point(422, 433);
            this.string_barang_jual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.string_barang_jual.Name = "string_barang_jual";
            this.string_barang_jual.Size = new System.Drawing.Size(64, 17);
            this.string_barang_jual.TabIndex = 52;
            this.string_barang_jual.Text = "(Barang)";
            // 
            // cekbarang_jual
            // 
            this.cekbarang_jual.Location = new System.Drawing.Point(329, 51);
            this.cekbarang_jual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cekbarang_jual.Name = "cekbarang_jual";
            this.cekbarang_jual.Size = new System.Drawing.Size(66, 28);
            this.cekbarang_jual.TabIndex = 50;
            this.cekbarang_jual.Text = "Cek Barang";
            this.cekbarang_jual.UseVisualStyleBackColor = true;
            this.cekbarang_jual.Click += new System.EventHandler(this.cekbarang_jual_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(216, 217);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 45);
            this.button6.TabIndex = 49;
            this.button6.Text = "Tambah";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // hargatotal_penjualan
            // 
            this.hargatotal_penjualan.Location = new System.Drawing.Point(268, 187);
            this.hargatotal_penjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hargatotal_penjualan.Name = "hargatotal_penjualan";
            this.hargatotal_penjualan.ReadOnly = true;
            this.hargatotal_penjualan.Size = new System.Drawing.Size(152, 22);
            this.hargatotal_penjualan.TabIndex = 43;
            // 
            // hargajual_penjualan
            // 
            this.hargajual_penjualan.Location = new System.Drawing.Point(268, 156);
            this.hargajual_penjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hargajual_penjualan.Name = "hargajual_penjualan";
            this.hargajual_penjualan.ReadOnly = true;
            this.hargajual_penjualan.Size = new System.Drawing.Size(152, 22);
            this.hargajual_penjualan.TabIndex = 44;
            // 
            // kuantiti_penjualan
            // 
            this.kuantiti_penjualan.Location = new System.Drawing.Point(268, 123);
            this.kuantiti_penjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kuantiti_penjualan.Name = "kuantiti_penjualan";
            this.kuantiti_penjualan.ReadOnly = true;
            this.kuantiti_penjualan.Size = new System.Drawing.Size(53, 22);
            this.kuantiti_penjualan.TabIndex = 45;
            this.kuantiti_penjualan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kuantiti_penjualan_KeyUp);
            // 
            // idcostumer_penjualan
            // 
            this.idcostumer_penjualan.Location = new System.Drawing.Point(268, 88);
            this.idcostumer_penjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idcostumer_penjualan.Name = "idcostumer_penjualan";
            this.idcostumer_penjualan.ReadOnly = true;
            this.idcostumer_penjualan.Size = new System.Drawing.Size(53, 22);
            this.idcostumer_penjualan.TabIndex = 46;
            // 
            // kode_penjualan
            // 
            this.kode_penjualan.Location = new System.Drawing.Point(268, 19);
            this.kode_penjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kode_penjualan.Name = "kode_penjualan";
            this.kode_penjualan.Size = new System.Drawing.Size(53, 22);
            this.kode_penjualan.TabIndex = 47;
            // 
            // kode_barang_penjualan
            // 
            this.kode_barang_penjualan.Location = new System.Drawing.Point(268, 54);
            this.kode_barang_penjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kode_barang_penjualan.Name = "kode_barang_penjualan";
            this.kode_barang_penjualan.Size = new System.Drawing.Size(53, 22);
            this.kode_barang_penjualan.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Sub Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Harga Jual";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Kuantiti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(91, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "ID Customer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Kode Penjualan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(91, 54);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "Kode Barang";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 520);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.views_data);
            this.tabPage1.Controls.Add(this.cek_supplier);
            this.tabPage1.Controls.Add(this.string_supplier);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.simpan);
            this.tabPage1.Controls.Add(this.hargatotal_pembelian);
            this.tabPage1.Controls.Add(this.hargabeli_pembelian);
            this.tabPage1.Controls.Add(this.kuantiti_pembelian);
            this.tabPage1.Controls.Add(this.kodesupplier_pembelian);
            this.tabPage1.Controls.Add(this.kode_pembelian);
            this.tabPage1.Controls.Add(this.kodebarang_pembelian);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(519, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pembelian";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // views_data
            // 
            this.views_data.AllowUserToAddRows = false;
            this.views_data.AllowUserToDeleteRows = false;
            this.views_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.views_data.Location = new System.Drawing.Point(8, 261);
            this.views_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.views_data.Name = "views_data";
            this.views_data.Size = new System.Drawing.Size(503, 213);
            this.views_data.TabIndex = 35;
            this.views_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.views_data_CellContentClick);
            // 
            // kode_pembelian
            // 
            this.kode_pembelian.Location = new System.Drawing.Point(292, 14);
            this.kode_pembelian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kode_pembelian.Name = "kode_pembelian";
            this.kode_pembelian.Size = new System.Drawing.Size(53, 22);
            this.kode_pembelian.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Kode Pembelian";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 525);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.string_barang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_penjualan)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cek_supplier;
        private System.Windows.Forms.Label string_supplier;
        private System.Windows.Forms.Label string_barang;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.TextBox hargatotal_pembelian;
        private System.Windows.Forms.TextBox hargabeli_pembelian;
        private System.Windows.Forms.TextBox kuantiti_pembelian;
        private System.Windows.Forms.TextBox kodesupplier_pembelian;
        private System.Windows.Forms.TextBox kodebarang_pembelian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView views_data;
        private System.Windows.Forms.TextBox kode_pembelian;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView views_penjualan;
        private System.Windows.Forms.Button cekcustomer_jual;
        private System.Windows.Forms.Label string_customer_jual;
        private System.Windows.Forms.Label string_barang_jual;
        private System.Windows.Forms.Button cekbarang_jual;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox hargatotal_penjualan;
        private System.Windows.Forms.TextBox hargajual_penjualan;
        private System.Windows.Forms.TextBox kuantiti_penjualan;
        private System.Windows.Forms.TextBox idcostumer_penjualan;
        private System.Windows.Forms.TextBox kode_penjualan;
        private System.Windows.Forms.TextBox kode_barang_penjualan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;

    }
}