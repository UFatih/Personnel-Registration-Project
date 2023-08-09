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
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MSI-GL65-LEOPAR\\SQLEXPRESS;Initial Catalog=PersonalDataBase;Integrated Security=True");
        private void Istatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı

            baglanti.Open();
            SqlCommand kmtt1 = new SqlCommand("Select Count(*) From MyDataBase", baglanti);
            SqlDataReader dr1 = kmtt1.ExecuteReader();
            while(dr1.Read())
            {
                Lbltotalpers.Text = dr1[0].ToString();
            }

            baglanti.Close();



            //Toplam Evli Sayısı

            baglanti.Open();
            SqlCommand kmtt2 = new SqlCommand("Select Count(*) From MyDataBase Where PerDurum=1", baglanti);
            SqlDataReader dr2 = kmtt2.ExecuteReader();
            while (dr2.Read())
            {
                Lbltotalevpers.Text = dr2[0].ToString();
            }
            baglanti.Close();




            // Toplam Bekar Sayısı

            baglanti.Open();
            SqlCommand kmtt3 = new SqlCommand("Select Count (*) From MyDataBase Where PerDurum=0", baglanti);
            SqlDataReader dr3 = kmtt3.ExecuteReader();
            while (dr3.Read())
            {
                Lbltotalbekarpers.Text = dr3[0].ToString();
            }
            baglanti.Close();

            // Toplam Şehir Sayısı

            baglanti.Open();
            SqlCommand kmtt4 = new SqlCommand("Select count (distinct(PerSehir)) From MyDataBase", baglanti);
            SqlDataReader dr4 = kmtt4.ExecuteReader();
            while (dr4.Read())
            {
                lbltotsehir.Text = dr4[0].ToString();
            }
            baglanti.Close();

            // Toplam Maas

            baglanti.Open();
            SqlCommand kmtt5 = new SqlCommand("Select Sum (PerMaaş) From MyDataBase", baglanti);
            SqlDataReader dr5 = kmtt5.ExecuteReader();
            while (dr5.Read())
            {
                lbltotalmaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand kmtt6 = new SqlCommand("Select Avg (PerMaaş) From MyDataBase", baglanti);
            SqlDataReader dr6 = kmtt6.ExecuteReader();
            while (dr6.Read())
            {
                lblortalamamaas.Text = dr6[0].ToString();
            }
            baglanti.Close();

        }

        private void Lbltotalpers_Click(object sender, EventArgs e)
        {

        }
    }
}
