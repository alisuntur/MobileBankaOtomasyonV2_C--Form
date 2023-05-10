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
    public partial class BakiyeGoruntule : Form
    {
        public BakiyeGoruntule()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("server=DESKTOP-M2A9413\\SQLEXPRESS;initial catalog=BankaOtomasyonDb;integrated security=sspi;TrustServerCertificate=True");


        private void BakiyeGoruntule_Load(object sender, EventArgs e)
        {
            //Bakiye verimizi Ana ekran Class ından çektik 
            lblBakiye.Text = AnaEkran.mBakiye.ToString() + "TL";
        }
    }
}
