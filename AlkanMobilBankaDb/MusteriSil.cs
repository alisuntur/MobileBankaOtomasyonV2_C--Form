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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
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

            command.Parameters.AddWithValue("@p1", "0");
            command.Parameters.AddWithValue("@p2", txtID.Text);
            command.Parameters.AddWithValue("@p3", txtTcKimlikNo.Text);

            if (txtVerilenBilgi.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girişi ! Lütfen Silmek İstediginiz Kişinin Numarası / TcNo giriniz !", "Eksik Kayıt Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult cevap = MessageBox.Show("Müşteri Kaydını Silmek İstediğinize Emin Misiniz ?", "Kayıt Silme Seçim", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cevap == DialogResult.No)
                {
                    MessageBox.Show("Silme İşleminiz İptal Edildi");

                }
                else
                {
                    connect.Open();

                    int silmesonuc = command.ExecuteNonQuery();
                    connect.Close();
                    if (silmesonuc == 1)
                        MessageBox.Show("Müşteri silme işlemi başarıyla tamamlandı .", "Müşteri Kayıt Silme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Müsteri kaydı daha önce silinmiş veya Pasif hesaba geçirilmiş İşleminiz Yapılamadı", "Müşteri Kayıt Silme ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void txtDurum_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void txtVerilenBilgi_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void txtBakiye_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTcKimlikNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
