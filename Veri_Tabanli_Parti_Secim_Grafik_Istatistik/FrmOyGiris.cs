using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veri_Tabanli_Parti_Secim_Grafik_Istatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=KOBOOM\SQLEXPRESS;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void buttonOyGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,aparti,bparti,cparti,dparti,eparti) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxIlceAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxA.Text);
            komut.Parameters.AddWithValue("@p3", textBoxB.Text);
            komut.Parameters.AddWithValue("@p4", textBoxC.Text);
            komut.Parameters.AddWithValue("@p5", textBoxD.Text);
            komut.Parameters.AddWithValue("@p6", textBoxE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }
    }
}
