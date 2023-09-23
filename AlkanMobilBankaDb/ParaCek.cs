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
    public partial class ParaCek : Form
    {
        public ParaCek()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            double bakiye = AnaEkran.mBakiye;

            float sayi = float.Parse(txtTutar.Text);

            if (sayi > bakiye)
            {
                MessageBox.Show("Yetersiz bakiye ", "Para Cekme İslemi");


            }

            else
            {
                try
                {
                    // Müşterinin bakiyesini güncelle
                    string updateQuery = "UPDATE musteriler SET bakiye = bakiye - @p1 WHERE ID = @p2";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connect);
                    updateCommand.Parameters.AddWithValue("@p1", sayi);
                    updateCommand.Parameters.AddWithValue("@p2", AnaEkran.musteriId);
                    connect.Open();
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    connect.Close();

                    // Müşterinin güncel bakiyesini sorgula
                    string selectQuery = "SELECT bakiye FROM musteriler WHERE ID = @p1";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connect);
                    selectCommand.Parameters.AddWithValue("@p1", AnaEkran.musteriId);
                    connect.Open();
                    bakiye = Convert.ToDouble(selectCommand.ExecuteScalar());
                    connect.Close();

                    string message = txtTutar.Text + " TL Çekim İşlemi Başarılı. Güncel Bakiye: " + bakiye.ToString();
                    MessageBox.Show(message, "Para Çekme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AnaEkran.mBakiye -= sayi;

                    HareketKaydet.Kaydet(AnaEkran.musteriId, (sayi + "TL Para Çekildi"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtTutar.Text = "";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTutar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
