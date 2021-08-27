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
    public partial class frmUrunİslemleri : Form
    {
        public frmUrunİslemleri()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public void listele()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Urunler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            
        }
        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
        }

        private void frmUrunİslemleri_Load(object sender, EventArgs e)
        {
            listele();
            SqlCommand komut = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!="" && comboBox1.Text!="" && textBox4.Text!="")
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Urunler (UrunAdi,Kategori,Fiyat) values(@p1,@p2,@p3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox2.Text);
                komut.Parameters.AddWithValue("@p2", comboBox1.Text);
                komut.Parameters.AddWithValue("@p3", textBox4.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ekleme işlemi başarılı");
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                SqlCommand komut = new SqlCommand("delete Tbl_Urunler where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                temizle();
                listele();
                MessageBox.Show("Silme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen silinecek ürünü seçiniz");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Urunler set UrunAdi=@p1, Kategori=@p2,Fiyat=@p3 where ID=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", comboBox1.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox1.Text);
            komut.ExecuteNonQuery();
            temizle();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme başarılı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[x].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
        }
    }
}
