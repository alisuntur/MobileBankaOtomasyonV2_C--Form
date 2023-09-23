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
    public partial class MusteriPasiflestir : Form
    {
        public MusteriPasiflestir()
        {
            InitializeComponent();
            txtVerilenBilgi.KeyPress += txtVerilenBilgi_KeyPress;
        }

        private void txtVerilenBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
            if (string.IsNullOrWhiteSpace(txtVerilenBilgi.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz müşterinin numarasını veya TC kimlik numarasını giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand command = new SqlCommand("SELECT * FROM musteriler WHERE ID = @p1 OR tckimlikNo = @p2", connect);
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

                DialogResult cevap = MessageBox.Show("Müşteri kaydını silmek istediğinize emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    dr.Close();
                    command = new SqlCommand("UPDATE musteriler SET durum = @p1 WHERE ID = @p2 OR tckimlikNo = @p3", connect);
                    command.Parameters.AddWithValue("@p1", "0");
                    command.Parameters.AddWithValue("@p2", txtID.Text);
                    command.Parameters.AddWithValue("@p3", txtTcKimlikNo.Text);
                    int silmeSonuc = command.ExecuteNonQuery();

                    if (silmeSonuc == 1)
                    {
                        MessageBox.Show("Müşteri silme işlemi başarıyla tamamlandı.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri kaydı daha önce silinmiş veya pasif hesaba geçirilmiş. İşleminiz yapılamadı.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(txtVerilenBilgi.Text + " numaralı veya TC kimlik numaralı kayıt bulunamadı.", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextBoxes();
            }

            connect.Close();
        }

        private void ClearTextBoxes()
        {
            txtVerilenBilgi.Text = "";
            txtTcKimlikNo.Text = "";
            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtBakiye.Text = "";
            txtDurum.Text = "";
            txtTelefon.Text = "";
            txtID.Text = "";
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

    }
}
