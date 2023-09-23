using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace AlkanMobilBankaDb
{
    public partial class ParaGonder : Form
    {
        private readonly string connectionString = "server=EXCALIBUR\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True";

        public ParaGonder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bakiye = AnaEkran.mBakiye;
            int alıcıId = int.Parse(txtAlıcıHesap.Text);
            double sayi = double.Parse(txtTutarGonderilen.Text);
            bool alıcıdogrulamadurum = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();



                    // Alıcının varlığı doğrulanıyor
                    // Alıcının varlığı doğrulanıyor
                    if (alıcıId == AnaEkran.musteriId)
                    {
                        MessageBox.Show("Kendi hesabınıza para gönderemezsiniz", "Para Gönderme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("SELECT * FROM musteriler WHERE ID=@id", connection);
                        command.Parameters.AddWithValue("@id", alıcıId);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            alıcıdogrulamadurum = true;
                        }

                        reader.Close();

                        if (!alıcıdogrulamadurum)
                        {
                            MessageBox.Show("Alıcı Hesap Bulunamadı ", "Para Gönderme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (sayi > bakiye)
                        {
                            MessageBox.Show("Yetersiz bakiye ", "Para Gönderme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Para gönderimi gerçekleştiriliyor
                            //BeginTransaction methodu ile veritabanı işlemleri yapmak için yardımcı method çağırdık 
                            SqlTransaction transaction = connection.BeginTransaction();
                            try
                            {
                                SqlCommand updateCommand = new SqlCommand("UPDATE musteriler SET bakiye = bakiye - @p1 WHERE ID = @p2", connection, transaction);
                                updateCommand.Parameters.AddWithValue("@p1", sayi);
                                updateCommand.Parameters.AddWithValue("@p2", AnaEkran.musteriId);

                                SqlCommand alıcıGuncel = new SqlCommand("UPDATE musteriler SET bakiye = bakiye + @p3 WHERE ID = @p4", connection, transaction);
                                alıcıGuncel.Parameters.AddWithValue("@p3", sayi);
                                alıcıGuncel.Parameters.AddWithValue("@p4", alıcıId);

                                updateCommand.ExecuteNonQuery();
                                alıcıGuncel.ExecuteNonQuery();
                                //Veritabanı işlemi kaydedildi
                                transaction.Commit();

                                // Yeni bakiye hesaplanıyor
                                SqlCommand selectCommand = new SqlCommand("SELECT bakiye FROM musteriler WHERE ID = @p1", connection);
                                selectCommand.Parameters.AddWithValue("@p1", AnaEkran.musteriId);
                                bakiye = Convert.ToDouble(selectCommand.ExecuteScalar());

                                AnaEkran.mBakiye = bakiye;

                                string message = txtTutarGonderilen.Text + " TL Gönderim İşlemi Başarılı. Güncel Bakiye: " + bakiye.ToString();
                                MessageBox.Show(message, "Para Gönderme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                HareketKaydet.Kaydet(AnaEkran.musteriId, (sayi + " TL Havale/EFT Gönderildi"));
                                HareketKaydet.Kaydet(int.Parse(txtAlıcıHesap.Text), (sayi + " TL Havale/EFT Alındı"));
                            }
                            catch (Exception ex)
                            {
                                //Veritabanı işlemini geri aldık 
                                transaction.Rollback();
                                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                    }
                }
                catch { }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
