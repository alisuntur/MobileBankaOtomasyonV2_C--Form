using Microsoft.Data.SqlClient;

namespace AlkanMobilBankaDb;

public partial class AnaEkran : Form
{
    //SQL Ba�lant�s� Yap�ld�
    SqlConnection con = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");

    //Sonraki formlarda kullanmak �zere de�i�kenlerimizi public �eklinde s�n�fland�rd�k 
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
                //Yetkili Admin Giri�i ve Yetkili Form A��lma ��lemi
                Yetkili�slem yetkili�slemler = new Yetkili�slem();
                yetkili�slemler.Show();

            }
            else
            {
                //Hatal� giri� yaparsa hata ekran� veriyoruz
                MessageBox.Show("Say�n Yetkili Hatal� Kullan�c� Ad� /Parola Denemesi !");
            }
            textBox1.Text = "";
            textBox2.Text = "";

        }
        else
        {
            //SQL Ba�lant�s� A��ld�
            con.Open();
            //SQL Sorgular� Yap�l�yor
            SqlCommand komut = new SqlCommand("select * from musteriler where tckimlikNo= @p1 and sifre=@p2 and durum=1", con);
            komut.Parameters.AddWithValue("@p1", kAdi);
            komut.Parameters.AddWithValue("@p2", parola);
            //Veri okumak i�in nesne olu�turduk
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //SQL den ald���m�z de�erler kontrol i�in stringe �eviriliyor
                    adSoyad = dr["adSoyad"].ToString();
                    musteriId = int.Parse(dr["ID"].ToString());
                    mBakiye = float.Parse(dr["bakiye"].ToString());
                    sonuc = true;
                }
            }
            else
            {
                MessageBox.Show("Giri� yapmak istedi�iniz hesap pasif durumda veya hatal� kullan�c� ad�/parola girdiniz.");
            }
            //Ba�lant�y� kapat�yoruz
            con.Close();


            if (sonuc)
            {
                //M�steri giri�i i�in yeni form a��yoruz
                sonuc = false;
                musteri�slem m�slem = new musteri�slem();
                m�slem.Show();
            }
            //Textboxlar� s�f�rlad�k
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