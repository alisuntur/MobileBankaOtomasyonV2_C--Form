using Microsoft.Data.SqlClient;

namespace AlkanMobilBankaDb;

public partial class AnaEkran : Form
{
    //SQL Baðlantýsý Yapýldý
    SqlConnection con = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");

    //Sonraki formlarda kullanmak üzere deðiþkenlerimizi public þeklinde sýnýflandýrdýk 
    public static string adSoyad = "";
    public static string kAdi = "";
    public static int musteriId;
    public static double mBakiye = 0.0f;


    public AnaEkran()
    {
        InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        kAdi = textBox1.Text;
        string parola = textBox2.Text;
        bool sonuc = false;
        if (radioButton1.Checked)
        {
            if (kAdi == "admin" && parola == "admin")
            {
                //Yetkili Admin Giriþi ve Yetkili Form Açýlma Ýþlemi
                YetkiliÝslem yetkiliÝslemler = new YetkiliÝslem();
                yetkiliÝslemler.Show();

            }
            else
            {
                //Hatalý giriþ yaparsa hata ekraný veriyoruz
                MessageBox.Show("Sayýn Yetkili Hatalý Kullanýcý Adý /Parola Denemesi !");
            }
            textBox1.Text = "";
            textBox2.Text = "";

        }
        else
        {
            //SQL Baðlantýsý Açýldý
            con.Open();
            //SQL Sorgularý Yapýlýyor
            SqlCommand komut = new SqlCommand("select * from musteriler where tckimlikNo= @p1 and sifre=@p2 and durum=1", con);
            komut.Parameters.AddWithValue("@p1", kAdi);
            komut.Parameters.AddWithValue("@p2", parola);
            //Veri okumak için nesne oluþturduk
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //SQL den aldýðýmýz deðerler kontrol için stringe çeviriliyor
                    adSoyad = dr["adSoyad"].ToString();
                    musteriId = int.Parse(dr["ID"].ToString());
                    mBakiye = float.Parse(dr["bakiye"].ToString());
                    sonuc = true;
                }
            }
            else
            {
                MessageBox.Show("Giriþ yapmak istediðiniz hesap pasif durumda veya hatalý kullanýcý adý/parola girdiniz.");
            }
            //Baðlantýyý kapatýyoruz
            con.Close();


            if (sonuc)
            {
                //Müsteri giriþi için yeni form açýyoruz
                sonuc = false;
                musteriÝslem mÝslem = new musteriÝslem();
                mÝslem.Show();
            }
            //Textboxlarý sýfýrladýk
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }

    private void AnaEkran_Load(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
}