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
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("server=DESKTOP-M2A9413\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            //Verilen bilgilere göre veritabanında arama yapıyoruz
            SqlCommand command = new SqlCommand("select * from  musteriler where ID= @p1 or tckimlikNo= @p2  ", connect);
            command.Parameters.AddWithValue("@p1", txtVerilenBilgi.Text);
            command.Parameters.AddWithValue("@p2", txtVerilenBilgi.Text);


            //Girdiğimiz bilgilere göre veritabanından alınan değerleri okutuyoruz okutma için yeni bir dr nesnesi tanımladık fonksiyonu çağırmak için
            connect.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                txtID.Text = dr["ID"].ToString();
                txtTcKimlikNo.Text = dr["tckimlikNo"].ToString();
                txtAdSoyad.Text = dr["adSoyad"].ToString();
                txtAdres.Text = dr["adres"].ToString();
                txtTelefon.Text = dr["telefon"].ToString();
                txtDurum.Text = dr["durum"].ToString();
                txtbakiye2.Text = dr["bakiye"].ToString();
                txtBakiye.Text = dr["bakiye"].ToString();
            }
            else
            {
                //Veri bulunamazsa hata ekranı ve sıfırlama işlemi
                MessageBox.Show(txtVerilenBilgi.Text + " Numaralı Kayıt Bulunamadı !", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVerilenBilgi.Text = "";
                txtTcKimlikNo.Text = "";
                txtAdres.Text = "";
                txtAdSoyad.Text = "";
                txtBakiye.Text = "";
                txtDurum.Text = "";
                txtTelefon.Text = "";
                txtID.Text = "";

            }
            connect.Close();
        }
    }
}
