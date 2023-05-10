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
    public partial class MusteriGuncelleme : Form
    {
        public MusteriGuncelleme()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("server=DESKTOP-M2A9413\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from  musteriler where ID= @p1 or tckimlikNo= @p2  ", connect);
            command.Parameters.AddWithValue("@p1", txtVerilenBilgi.Text);
            command.Parameters.AddWithValue("@p2", txtVerilenBilgi.Text);


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

                txtBakiye.Text = dr["bakiye"].ToString();
            }
            else
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update musteriler set adSoyad= @p1 ,adres=@p2,telefon=@p3 where ID= @p4 or tckimlikNo= @p5  ", connect);
            command.Parameters.AddWithValue("@p4", txtVerilenBilgi.Text);
            command.Parameters.AddWithValue("@p5", txtVerilenBilgi.Text);
            command.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            command.Parameters.AddWithValue("@p2", txtAdres.Text);
            command.Parameters.AddWithValue("@p3", txtTelefon.Text);


            connect.Open();
            int guncelsonuc=command.ExecuteNonQuery();
            if (guncelsonuc==1)
            {
                MessageBox.Show(txtVerilenBilgi.Text+" Numaralı Kişinin" + " Güncellemesi Yapıldı ", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(txtVerilenBilgi.Text+" Numaralı Kişinin" + " Güncellemesi Yapılmadı !", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
