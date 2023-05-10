using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlkanMobilBankaDb
{
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("server=DESKTOP-M2A9413\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select*from musteriler", connect);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable musteritablo = new DataTable();
            da.Fill(musteritablo);
            dataGridView1.DataSource = musteritablo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select*from musteriler where  adSoyad like '" + textBox1.Text+"%'", connect);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable musteritablo = new DataTable();
            da.Fill(musteritablo);
            dataGridView1.DataSource = musteritablo;
        }
    }
}
