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
            txtTcKimlikNo.KeyPress += txtTcKimlikNo_KeyPress;
            txtAdSoyad.KeyPress += txtAdSoyad_KeyPress;
            txtAdres.KeyPress += txtAdres_KeyPress;
            txtTelefon.KeyPress += txtTelefon_KeyPress;
            txtBakiye.KeyPress += txtBakiye_KeyPress;
        }

        SqlConnection connect = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");

        private void txtTcKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece harf girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece harf girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı ve ondalık nokta girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Sadece bir ondalık nokta girişine izin ver
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // SQL Veri tabanından tablo bilgilerini çekip her bir parametreyi bir değişkene atadık 
            SqlCommand command = new SqlCommand("insert into musteriler(tckimlikNo,adSoyad,adres,telefon,sifre,bakiye,durum) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connect);
            command.Parameters.AddWithValue("@p1", txtTcKimlikNo.Text);
            command.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            command.Parameters.AddWithValue("@p3", txtAdres.Text);
            command.Parameters.AddWithValue("@p4", txtTelefon.Text);
            command.Parameters.AddWithValue("@p5", txtTcKimlikNo.Text);
            command.Parameters.AddWithValue("@p6", txtBakiye.Text);
            command.Parameters.AddWithValue("@p7", 1);

            // Hata Önlemi İçin( Boş giriş )
            if (txtTcKimlikNo.Text == "" || txtAdSoyad.Text == "" || txtBakiye.Text == "" || txtAdres.Text == "" || txtTelefon.Text == "")
            {
                MessageBox.Show("Yeni kayıt yapılamadı. Bilgiler Eksik", "Müsteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Sql bağlantısını sağla ve command ile çalıştır 
                connect.Open();
                int musterisonuc = command.ExecuteNonQuery();
                connect.Close();
                if (musterisonuc == 1)
                    MessageBox.Show("Yeni Müsteri Kaydınız Tamamlandı", "Müsteri Kaydı");
                else
                    MessageBox.Show("Yeni Kayıt Yapılamadı !", "Müsteri Kaydı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Textboxları boşalttık
            txtTcKimlikNo.Text = "";
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            txtTelefon.Text = "";
            txtBakiye.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
