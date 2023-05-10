using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace AlkanMobilBankaDb
{
    public partial class ParolaDegistir : Form
    {
        public ParolaDegistir()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("server=DESKTOP-M2A9413\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının mevcut parolasını kontrol et
            string selectQuery = "SELECT sifre FROM musteriler WHERE ID = @p1";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connect);
            selectCommand.Parameters.AddWithValue("@p1", AnaEkran.musteriId);
            connect.Open();
            string currentPassword = Convert.ToString(selectCommand.ExecuteScalar());
            connect.Close();

            if (txtback.Text == "" || txtnew.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurun !", "Parola Değiştirme İşlemi");
            }
            else if (txtnew.Text.Length < 6)
            {
                MessageBox.Show("En az 6 karakterlik bir parola girin !", "Parola Değiştirme İşlemi");
            }
            else if (txtback.Text != currentPassword)
            {
                MessageBox.Show("Mevcut parolanız yanlış !", "Parola Değiştirme İşlemi");
            }
            else
            {
                try
                {
                    // Veritabanında parolayı güncelle
                    string updateQuery = "UPDATE musteriler SET sifre = @p1 WHERE ID = @p2";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connect);
                    updateCommand.Parameters.AddWithValue("@p1", txtnew.Text);
                    updateCommand.Parameters.AddWithValue("@p2", AnaEkran.musteriId);
                    connect.Open();
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Parolanız başarıyla değiştirildi !", "Parola Değiştirme İşlemi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
