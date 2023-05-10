using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlkanMobilBankaDb
{
    public class HareketKaydet
    {
        //İşlem ekranlarından ulaşmak için HareketKaydet classımızı oluşturduk. Kod tekrarı olmaması açısından
        public static void Kaydet(int mId,string mesaj)
        {
            //SQL bağlantısı yapıldı
            SqlConnection connect = new SqlConnection("server=DESKTOP-M2A9413\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");
            //SQL komutu oluşturuldu
            SqlCommand cmd = new SqlCommand("insert into hareketler(musteriId,islem,tarih) values(@p1,@p2,@p3)",connect);
           //Sorgu parametreleri girildi
            cmd.Parameters.AddWithValue("@p1", mId);
            cmd.Parameters.AddWithValue("@p2", mesaj);
            cmd.Parameters.AddWithValue("@p3", DateTime.Now);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();


        }
    }
}
