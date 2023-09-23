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
    public partial class Yetkiliİslem : Form
    {
        public Yetkiliİslem()
        {
            InitializeComponent();
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            //  Admin form kapatıldı
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriekleme = new MusteriEkle();
            musteriekleme.Show();

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            MusteriAra musteriarama = new MusteriAra();
            musteriarama.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelleme musteriguncelle = new MusteriGuncelleme();
            musteriguncelle.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            MusteriListele musterilisteleme = new MusteriListele();
            musterilisteleme.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasifHesapAc hesapaktiflestir = new PasifHesapAc();
            hesapaktiflestir.Show();
        }

        private void btnPasiflestir_Click(object sender, EventArgs e)
        {
            MusteriPasiflestir hesappasiflestir = new MusteriPasiflestir();
            hesappasiflestir.Show();
        }

        private void Yetkiliİslem_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
