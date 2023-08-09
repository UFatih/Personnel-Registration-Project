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
    public partial class girişpnl : Form
    {
        public girişpnl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MSI-GL65-LEOPAR\\SQLEXPRESS;Initial Catalog=PersonalDataBase;Integrated Security=True");
        private void grşbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand grş = new SqlCommand("Select * From TableGiris Where Kuladi=@y1 and Şifre=@y2", baglanti);
            grş.Parameters.AddWithValue("@y1", txtkuladı.Text);
            grş.Parameters.AddWithValue("@y2", txtşifre.Text);
            SqlDataReader drr = grş.ExecuteReader();
            if (drr.Read())
            {
                AnaFormm frm = new AnaFormm();
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalıdır");
            }

            baglanti.Close();
        }

        
    }
}
