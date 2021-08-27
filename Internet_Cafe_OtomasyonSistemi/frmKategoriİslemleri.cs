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
namespace Internet_Cafe_OtomasyonSistemi
{
    public partial class frmKategoriİslemleri : Form
    {
        public frmKategoriİslemleri()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        private void frmKategoriİslemleri_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Kategoriler",bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[x].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!="")
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Kategoriler (Kategori) values(@p1)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox2.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ekleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen kategori adını giriniz");
            }
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                SqlCommand komut = new SqlCommand("delete Tbl_Kategoriler where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Hata! Lütfen silinecek kategoriyi seçiniz");
            }
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Kategoriler set Kategori=@p1 where ID=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox2.Text);
                komut.Parameters.AddWithValue("@p2", textBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek kategoriyi seçin");
            }
            temizle();
        }

        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
