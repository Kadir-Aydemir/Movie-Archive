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

namespace FİLM_ARŞİVİ
{
    public partial class FrmFilmekle : Form
    {
        public FrmFilmekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Filmarsivim;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {           
            this.Close();           
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_FILMLER (AD,KATEGORI,LINK,IZLENDI) values (@p1,@p2,@p3,0)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtkategori.Text);
            komut.Parameters.AddWithValue("@p3", txtlink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ FİLM EKLENDİ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            txtad.Text = "";
            txtkategori.Text = "";
            txtlink.Text = "";
        }
    }
}
