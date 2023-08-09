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

namespace Veri_tabanı__Personel_Kayıt_projesi_
{
    public partial class grafik : Form
    {
        public grafik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MSI-GL65-LEOPAR\\SQLEXPRESS;Initial Catalog=PersonalDataBase;Integrated Security=True");

        private void grafik_Load(object sender, EventArgs e)
        {
            //grafik 1
            baglanti.Open();
            SqlCommand grfk1 = new SqlCommand("Select PerSehir, Count(*) From MyDataBase Group By PerSehir", baglanti);
            SqlDataReader drg1 = grfk1.ExecuteReader();
            while (drg1.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(drg1[0], drg1[1]);
            }
            baglanti.Close();

            //grafik 2
            baglanti.Open();
            SqlCommand grfk2 = new SqlCommand("Select PerMeslek, Avg(PerMaaş) From MyDataBase Group By PerMeslek", baglanti);
            SqlDataReader drg2 = grfk2.ExecuteReader();
            while (drg2.Read())
            {
                chart2.Series["Meslek-Maaş"].Points.AddXY(drg2[0], drg2[1]);
            }
            baglanti.Close();
        }
    }
}
