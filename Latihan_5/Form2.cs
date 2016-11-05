using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5
{
    public partial class Form2 : Form
    {
        Form1 parentform;
        public Form2(Form1 form)
        {
            InitializeComponent();
            parentform = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            foreach (KnownColor warna in Enum.GetValues(typeof(KnownColor)))
            {
                comboBox1.Items.Add(warna);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background Color")
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parentform.textboxparent = Color.FromName(comboBox1.SelectedItem.ToString());
        }
    }
}
