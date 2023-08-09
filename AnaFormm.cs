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
    public partial class AnaFormm : Form
    {
        public AnaFormm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MSI-GL65-LEOPAR\\SQLEXPRESS;Initial Catalog=PersonalDataBase;Integrated Security=True");

        void temizle()
        {
            txtid.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbSehir.Text = "";
            txtMeslek.Text = "";
            mskMaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAd.Focus();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataBaseDataSet1.MyDataBase' table. You can move, or remove it, as needed.
            

        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            this.myDataBaseTableAdapter.Fill(this.personalDataBaseDataSet1.MyDataBase);
        }

        private void btnkydt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MyDataBase (PerAd, PerSoyad, PerSehir, PerMaaş, PerMeslek, PerDurum) values (@e1, @e2, @e3, @e4, @e5, @e6)", baglanti);
            komut.Parameters.AddWithValue("@e1", txtAd.Text);
            komut.Parameters.AddWithValue("@e2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@e3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@e4", mskMaas.Text);
            komut.Parameters.AddWithValue("@e5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@e6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
            
        }

        private void btntem_Click(object sender, EventArgs e)
        {
            temizle();
        }

      

        private void label8_TextChanged(object sender, EventArgs e)
        {
           if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }

           if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmtsil = new SqlCommand("Delete From MyDataBase Where Perid=@k1", baglanti);
            kmtsil.Parameters.AddWithValue("@k1", txtid.Text);
            kmtsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silinmiştir");
        }

        // Güncelle kısmında label8 deki boyut hatasından dolayı güncelleme hata veriyor. Label 8 kısmını çıkarttığımda ise çalışıyor.
        private void btngncl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand gnclle = new SqlCommand("Update MyDataBase Set PerAd=@g1, PerSoyad=@g2, PerSehir=@g3, PerMaaş=@g4, PerDurum=@g5, PerMeslek=@g6 Where Perid=@g7", baglanti);
            gnclle.Parameters.AddWithValue("@g1", txtAd.Text);
            gnclle.Parameters.AddWithValue("@g2", txtSoyad.Text);
            gnclle.Parameters.AddWithValue("@g3", cmbSehir.Text);
            gnclle.Parameters.AddWithValue("@g4", mskMaas.Text);
            gnclle.Parameters.AddWithValue("@g5", label8.Text);
            gnclle.Parameters.AddWithValue("@g6", txtMeslek.Text);
            gnclle.Parameters.AddWithValue("@g7", txtid.Text);
            gnclle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seç = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[seç].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[seç].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[seç].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[seç].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[seç].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[seç].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[seç].Cells[6].Value.ToString();
        }

     
private void btnist_Click(object sender, EventArgs e)
        {
            Istatistik fr = new Istatistik();
            fr.Show();
        }

        private void btngrfk_Click(object sender, EventArgs e)
        {
            grafik grf = new grafik();
            grf.Show();
        }

        
    }
    
}
