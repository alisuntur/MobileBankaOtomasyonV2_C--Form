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
    public partial class musteriİslem : Form
    {
        public musteriİslem()
        {
            InitializeComponent();
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            // Oturum kapatma işlemi
            this.Close();
        }

        private void musteriİslem_Load(object sender, EventArgs e)
        {
            //Form 1 de public yaptığımız referans bilgileri çağırdık
            lblAdSoyad.Text = AnaEkran.adSoyad;
            lblHesapNo.Text = AnaEkran.musteriId.ToString();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            ParaCek paracekme = new ParaCek();
            paracekme.Show();
        }

        private void btnParaYatır_Click(object sender, EventArgs e)
        {
            ParaYatir parayatirma = new ParaYatir();
            parayatirma.Show();
        }

        private void btnBakiyeGor_Click(object sender, EventArgs e)
        {
            BakiyeGoruntule bakiyeGoruntuleme = new BakiyeGoruntule();
            bakiyeGoruntuleme.Show();
        }

        private void btnParaGonder_Click(object sender, EventArgs e)
        {
            ParaGonder paraaGonderme = new ParaGonder();
            paraaGonderme.Show();
        }

        private void btnParolaGuncelle_Click(object sender, EventArgs e)
        {
            ParolaDegistir paroladegistirme = new ParolaDegistir();
            paroladegistirme.Show();
        }

        private void btnHareketGor_Click(object sender, EventArgs e)
        {
            HesapHareket hesaphareketleri = new HesapHareket();
            hesaphareketleri.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
