namespace Database_POS
{
    partial class Costumer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.simpan_barang = new System.Windows.Forms.Button();
            this.nokostumer = new System.Windows.Forms.TextBox();
            this.alamatkostumer = new System.Windows.Forms.TextBox();
            this.namakostumer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Eidkostumer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cek_costumer = new System.Windows.Forms.Button();
            this.Update_Kostumer = new System.Windows.Forms.Button();
            this.Enokostumer = new System.Windows.Forms.TextBox();
            this.Ealamatkostumer = new System.Windows.Forms.TextBox();
            this.Enamakostumer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.barang_views = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barang_views)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 292);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.simpan_barang);
            this.tabPage1.Controls.Add(this.nokostumer);
            this.tabPage1.Controls.Add(this.alamatkostumer);
            this.tabPage1.Controls.Add(this.namakostumer);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(508, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tambah Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // simpan_barang
            // 
            this.simpan_barang.Location = new System.Drawing.Point(189, 194);
            this.simpan_barang.Margin = new System.Windows.Forms.Padding(4);
            this.simpan_barang.Name = "simpan_barang";
            this.simpan_barang.Size = new System.Drawing.Size(124, 50);
            this.simpan_barang.TabIndex = 3;
            this.simpan_barang.Text = "Tambahkan";
            this.simpan_barang.UseVisualStyleBackColor = true;
            this.simpan_barang.Click += new System.EventHandler(this.save_barang_button_Click);
            // 
            // nokostumer
            // 
            this.nokostumer.Location = new System.Drawing.Point(242, 146);
            this.nokostumer.Margin = new System.Windows.Forms.Padding(4);
            this.nokostumer.Name = "nokostumer";
            this.nokostumer.Size = new System.Drawing.Size(152, 22);
            this.nokostumer.TabIndex = 2;
            // 
            // alamatkostumer
            // 
            this.alamatkostumer.Location = new System.Drawing.Point(242, 101);
            this.alamatkostumer.Margin = new System.Windows.Forms.Padding(4);
            this.alamatkostumer.Name = "alamatkostumer";
            this.alamatkostumer.Size = new System.Drawing.Size(152, 22);
            this.alamatkostumer.TabIndex = 2;
            // 
            // namakostumer
            // 
            this.namakostumer.Location = new System.Drawing.Point(242, 53);
            this.namakostumer.Margin = new System.Windows.Forms.Padding(4);
            this.namakostumer.Name = "namakostumer";
            this.namakostumer.Size = new System.Drawing.Size(152, 22);
            this.namakostumer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "No HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Cust";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Eidkostumer);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cek_costumer);
            this.tabPage2.Controls.Add(this.Update_Kostumer);
            this.tabPage2.Controls.Add(this.Enokostumer);
            this.tabPage2.Controls.Add(this.Ealamatkostumer);
            this.tabPage2.Controls.Add(this.Enamakostumer);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(508, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Costumer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Eidkostumer
            // 
            this.Eidkostumer.Location = new System.Drawing.Point(248, 18);
            this.Eidkostumer.Margin = new System.Windows.Forms.Padding(4);
            this.Eidkostumer.Name = "Eidkostumer";
            this.Eidkostumer.Size = new System.Drawing.Size(152, 22);
            this.Eidkostumer.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "ID Costumer";
            // 
            // cek_costumer
            // 
            this.cek_costumer.Location = new System.Drawing.Point(408, 18);
            this.cek_costumer.Margin = new System.Windows.Forms.Padding(4);
            this.cek_costumer.Name = "cek_costumer";
            this.cek_costumer.Size = new System.Drawing.Size(77, 25);
            this.cek_costumer.TabIndex = 11;
            this.cek_costumer.Text = "Cek";
            this.cek_costumer.UseVisualStyleBackColor = true;
            this.cek_costumer.Click += new System.EventHandler(this.cek_costumer_Click);
            // 
            // Update_Kostumer
            // 
            this.Update_Kostumer.Location = new System.Drawing.Point(276, 202);
            this.Update_Kostumer.Margin = new System.Windows.Forms.Padding(4);
            this.Update_Kostumer.Name = "Update_Kostumer";
            this.Update_Kostumer.Size = new System.Drawing.Size(124, 50);
            this.Update_Kostumer.TabIndex = 11;
            this.Update_Kostumer.Text = "Simpan";
            this.Update_Kostumer.UseVisualStyleBackColor = true;
            this.Update_Kostumer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Enokostumer
            // 
            this.Enokostumer.Location = new System.Drawing.Point(248, 156);
            this.Enokostumer.Margin = new System.Windows.Forms.Padding(4);
            this.Enokostumer.Name = "Enokostumer";
            this.Enokostumer.Size = new System.Drawing.Size(152, 22);
            this.Enokostumer.TabIndex = 8;
            // 
            // Ealamatkostumer
            // 
            this.Ealamatkostumer.Location = new System.Drawing.Point(248, 110);
            this.Ealamatkostumer.Margin = new System.Windows.Forms.Padding(4);
            this.Ealamatkostumer.Name = "Ealamatkostumer";
            this.Ealamatkostumer.Size = new System.Drawing.Size(152, 22);
            this.Ealamatkostumer.TabIndex = 9;
            // 
            // Enamakostumer
            // 
            this.Enamakostumer.Location = new System.Drawing.Point(248, 62);
            this.Enamakostumer.Margin = new System.Windows.Forms.Padding(4);
            this.Enamakostumer.Name = "Enamakostumer";
            this.Enamakostumer.Size = new System.Drawing.Size(152, 22);
            this.Enamakostumer.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nomor HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nama Lengkap";
            // 
            // barang_views
            // 
            this.barang_views.AllowUserToAddRows = false;
            this.barang_views.AllowUserToDeleteRows = false;
            this.barang_views.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barang_views.Location = new System.Drawing.Point(11, 314);
            this.barang_views.Margin = new System.Windows.Forms.Padding(4);
            this.barang_views.Name = "barang_views";
            this.barang_views.Size = new System.Drawing.Size(512, 245);
            this.barang_views.TabIndex = 3;
            this.barang_views.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barang_views_CellContentClick);
            // 
            // Costumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 564);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.barang_views);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Costumer";
            this.Text = "Costumer";
            this.Load += new System.EventHandler(this.Costumer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barang_views)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button simpan_barang;
        private System.Windows.Forms.TextBox nokostumer;
        private System.Windows.Forms.TextBox alamatkostumer;
        private System.Windows.Forms.TextBox namakostumer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView barang_views;
        private System.Windows.Forms.TextBox Eidkostumer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cek_costumer;
        private System.Windows.Forms.Button Update_Kostumer;
        private System.Windows.Forms.TextBox Enokostumer;
        private System.Windows.Forms.TextBox Ealamatkostumer;
        private System.Windows.Forms.TextBox Enamakostumer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}