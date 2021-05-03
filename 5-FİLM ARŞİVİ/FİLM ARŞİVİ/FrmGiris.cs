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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Filmarsivim;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select AD,KATEGORI,LINK,IZLENDI,ID from TBL_FILMLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FrmFilmekle fr = new FrmFilmekle();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbllink.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();           
            webBrowser1.Navigate(lbllink.Text);
        }

        private void btntamekran_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            groupBox1.Size = new Size(1920, 1080);
            groupBox1.Location = new Point(0, 0);
            btnkucult.Visible = true;

        }
        string izlendi;
        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkategori.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            izlendi= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            id= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (izlendi == "True")
            {
                cbxizlendi.Checked = true;
            }
            else
            {
                cbxizlendi.Checked = false;
            }
        }

        private void cbxizlendi_OnChange(object sender, EventArgs e)
        {
            if (cbxizlendi.Checked == true)
            {
                izlendi = "True";
            }
            if (cbxizlendi.Checked == false)
            {
                izlendi = "False";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBL_FILMLER set AD=@P1,KATEGORI=@P2,IZLENDI=@P3 where ID=@P4", baglanti);
            komut.Parameters.AddWithValue("@P1", txtad.Text);
            komut.Parameters.AddWithValue("@P2", txtkategori.Text);
            komut.Parameters.AddWithValue("@P3", izlendi.ToString());
            komut.Parameters.AddWithValue("@P4", id.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            filmler();
            txtad.Clear();
            txtkategori.Clear();
            cbxizlendi.Checked = false;
        }

        private void btnkucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            groupBox1.Size = new Size(974, 596);
            groupBox1.Location = new Point(9, 106);
            btnkucult.Visible = false;
            button1.Location=new Point(1269, 4);
            button2.Location = new Point(1227, 4); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bu yazılım 24 Nisan 2021 yılında KADİR AYDEMİR tarafından yazılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
