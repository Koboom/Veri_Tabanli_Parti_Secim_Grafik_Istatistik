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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=KOBOOM\SQLEXPRESS;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboBoxIlceSecin.Items.Add(dr[0].ToString());
            }
        }

        private void comboBoxIlceSecin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
