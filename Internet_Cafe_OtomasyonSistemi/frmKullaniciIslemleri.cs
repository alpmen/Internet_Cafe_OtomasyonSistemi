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
    public partial class frmKullaniciIslemleri : Form
    {
        public frmKullaniciIslemleri()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public void listele()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Yoneticiler", bgl.baglanti());
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
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void frmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="" && textBox5.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Yoneticiler (KullaniciAdi,KullaniciSoyadi,mail,Sifre) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox2.Text);
                komut.Parameters.AddWithValue("@p2", textBox3.Text);
                komut.Parameters.AddWithValue("@p3", textBox4.Text);
                komut.Parameters.AddWithValue("@p4", textBox5.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ekleme işlemi başarılı");
                temizle();
                listele();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                SqlCommand komut = new SqlCommand("delete Tbl_Yoneticiler where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.ExecuteNonQuery();
                temizle();
                listele();
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi başarılı");
             }
            else
            {
                MessageBox.Show("Lütfen silinecek kişiyi seçiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[x].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[x].Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Yoneticiler set KullaniciAdi=@p1,KullaniciSoyadi=@p2,mail=@p3,Sifre=@p4 where ID=@p5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox2.Text);
                komut.Parameters.AddWithValue("@p2", textBox3.Text);
                komut.Parameters.AddWithValue("@p3", textBox4.Text);
                komut.Parameters.AddWithValue("@p4", textBox5.Text);
                komut.Parameters.AddWithValue("@p5", textBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                temizle();
                listele();
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek kişiyi seçiniz");
            }

        }
    }
}
