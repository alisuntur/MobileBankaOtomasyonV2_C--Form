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
    public partial class PasifHesapAc : Form
    {
        public PasifHesapAc()
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



        private void btnSil_Click(object sender, EventArgs e)
        {


            //SqlCommand command = new SqlCommand("delete musteriler where ID= @p1  ", connect);//
            SqlCommand command = new SqlCommand("UPDATE musteriler SET durum=@p1 WHERE ID= @p2 OR tckimlikNo=@p3", connect);

            command.Parameters.AddWithValue("@p1", "1");
            command.Parameters.AddWithValue("@p2", txtID.Text);
            command.Parameters.AddWithValue("@p3", txtTcKimlikNo.Text);

            if (txtVerilenBilgi.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girişi ! Lütfen Müşteri Hesap Aktifleştirmesi Yapmak  İstediginiz Kişinin Numarası / TcNo giriniz !", "Eksik Kayıt Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult cevap = MessageBox.Show("Müşteri Hesap Aktifleştirme İşlemini Yapmak İstediğinize Emin Misiniz ?", "Müşteri Hesap Aktifleştirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cevap == DialogResult.No)
                {
                    MessageBox.Show("Müşteri Hesap Aktifleştirme İşlemi İptal Edildi");

                }
                else
                {
                    connect.Open();

                    int silmesonuc = command.ExecuteNonQuery();
                    connect.Close();
                    if (silmesonuc == 1)
                        MessageBox.Show("Müşteri Hesap Aktifleştirme işlemi başarıyla tamamlandı .", "Müşteri Hesap Aktifleştirme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Müsteri kaydı halihazırda  Aktif Hesap Olduğu İçin  İşleminiz Yapılamadı", "Müşteri Hesap Aktifleştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }


    }
}
