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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("server=DESKTOP-M2A9413\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL Veri tabanından tablo bilgilerini çekip her bir parametreyi bir değişkene atadık 
            SqlCommand command = new SqlCommand("insert into musteriler(tckimlikNo,adSoyad,adres,telefon,sifre,bakiye,durum) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connect);
            command.Parameters.AddWithValue("@p1",txtTcKimlikNo.Text);
            command.Parameters.AddWithValue("@p2",txtAdSoyad.Text);
            command.Parameters.AddWithValue("@p3",txtAdres.Text);
            command.Parameters.AddWithValue("@p4",txtTelefon.Text);
            command.Parameters.AddWithValue("@p5",txtTcKimlikNo.Text);
            command.Parameters.AddWithValue("@p6",txtBakiye.Text);
            command.Parameters.AddWithValue("@p7",1);

            //Hata Önlemi İçin( Boş giriş )
            if (txtTcKimlikNo.Text =="" ||txtAdSoyad.Text == "" ||txtBakiye.Text == "" ||txtAdres.Text == "" ||txtTelefon.Text == "")
            {
                MessageBox.Show("Yeni kayıt yapılamadı.Bilgiler Eksik","Musteri Kayıt Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //Sql bağlantısını sağla ve command ile çalıştır 
                connect.Open();
                int musterisonuc= command.ExecuteNonQuery();
                connect.Close();
                if (musterisonuc == 1)
                    MessageBox.Show("Yeni Müsteri Kaydınız Tamamlandı", "Müsteri Kaydı");
                else
                    MessageBox.Show("Yeni Kayıt Yapılamadı !", "Müsteri Kaydı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            //Sql bağlantısını sağla ve command ile çalıştır 
            connect.Open();
            int sonuc = command.ExecuteNonQuery();
            connect.Close();
            if (sonuc == 1)
                MessageBox.Show("Yeni Müsteri Kaydınız Tamamlandı", "Müsteri Kaydı");
            else 
                MessageBox.Show("Yeni Kayıt Yapılamadı !","Müsteri Kaydı Hatası",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //Textboxları boşalttık
            txtTcKimlikNo.Text="";
            txtAdSoyad.Text="";
            txtAdres.Text="";
            txtTelefon.Text = "";
            txtBakiye.Text = "";
        }
    }
}
