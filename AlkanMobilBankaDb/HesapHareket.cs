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
    public partial class HesapHareket : Form
    {
        public HesapHareket()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");

        private void HesapHareket_Load(object sender, EventArgs e)
        {
            //Datalarımızı tabloya getimek için veritabanı bağlantısı ve sorguları yapıldı
            SqlCommand command = new SqlCommand("select* from hareketler where musteriID =@p1", connect);
            command.Parameters.AddWithValue("p1", AnaEkran.musteriId);
            //Data çekmek için nesne oluşturuldu
            SqlDataAdapter datagetir = new SqlDataAdapter(command);
            DataTable hareketTablo = new DataTable();
            //Dataları tabloya yerleştirdik
            datagetir.Fill(hareketTablo);
            dataGridView1.DataSource = hareketTablo;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
