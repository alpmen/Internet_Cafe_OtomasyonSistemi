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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();
        double[] sureler = new double[12];
        double[] ucretler = new double[12];
        double[] SiparisUcret = new double[12];
        public double urunUcret = 0;

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            SqlCommand komuts = new SqlCommand("select * from Tbl_Kasa", bgl.baglanti());
            SqlDataReader drs = komuts.ExecuteReader();
            while (drs.Read())
            {
                label55.Text = drs[0].ToString();
                label56.Text = drs[1].ToString();
            }
            bgl.baglanti().Close();
            
            numericUpDown2.Maximum = 12;
            numericUpDown2.Minimum = 1;

            numericUpDown3.Maximum = 12;
            numericUpDown3.Minimum = 1;
            for (int i = 0; i < 12; i++)
            {
                sureler[i] = 0;
                ucretler[i] = 0;
                SiparisUcret[i] = 0;
            }
            SqlCommand komut = new SqlCommand("select * from Tbl_Kategoriler",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();

            //SqlCommand komut2 = new SqlCommand("select * from Tbl_Masa", bgl.baglanti());
            //SqlDataReader dr2 = komut2.ExecuteReader();
            
            //bgl.baglanti().Close();

            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;

            //RadioButton[] MyButtons = new RadioButton[] { radioButton1,radioButton2,radioButton3,radioButton4,radioButton5,radioButton6,radioButton7,
            //radioButton8,radioButton9,radioButton10,radioButton11,radioButton12};
            //PictureBox[] MyPicture = new PictureBox[]{pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,
            //pictureBox8,pictureBox9,pictureBox10,pictureBox11,pictureBox12};

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sureler[0]++;
            label4.Text = sureler[0].ToString() + "dk";
            label3.Text = (sureler[0] * 0.5).ToString() + "₺";
            ucretler[0] = Convert.ToDouble(sureler[0] * 0.5);

        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            sureler[11]++;
            label46.Text = sureler[11].ToString() + "dk";
            label45.Text = (sureler[11] * 0.5).ToString() + "₺";
            ucretler[11] = Convert.ToDouble(sureler[11] * 0.5);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sureler[1]++;
            label6.Text = sureler[1].ToString() + "dk";
            label5.Text = (sureler[1] * 0.5).ToString() + "₺";
            ucretler[1] = Convert.ToDouble(sureler[1] * 0.5);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sureler[2]++;
            label10.Text = sureler[2].ToString() + "dk";
            label9.Text = (sureler[2] * 0.5).ToString() + "₺";
            ucretler[2] = Convert.ToDouble(sureler[2] * 0.5);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            sureler[3]++;
            label14.Text = sureler[3].ToString() + "dk";
            label13.Text = (sureler[3] * 0.5).ToString() + "₺";
            ucretler[3] = Convert.ToDouble(sureler[3] * 0.5);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            sureler[4]++;
            label18.Text = sureler[4].ToString() + "dk";
            label17.Text = (sureler[4] * 0.5).ToString() + "₺";
            ucretler[4] = Convert.ToDouble(sureler[4] * 0.5);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            sureler[5]++;
            label22.Text = sureler[5].ToString() + "dk";
            label21.Text = (sureler[5] * 0.5).ToString() + "₺";
            ucretler[5] = Convert.ToDouble(sureler[5] * 0.5);
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            sureler[6]++;
            label26.Text = sureler[6].ToString() + "dk";
            label25.Text = (sureler[6] * 0.5).ToString() + "₺";
            ucretler[6] = Convert.ToDouble(sureler[6] * 0.5);
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            sureler[7]++;
            label30.Text = sureler[7].ToString() + "dk";
            label29.Text = (sureler[7] * 0.5).ToString() + "₺";
            ucretler[7] = Convert.ToDouble(sureler[7] * 0.5);
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            sureler[8]++;
            label34.Text = sureler[8].ToString() + "dk";
            label33.Text = (sureler[8] * 0.5).ToString() + "₺";
            ucretler[8] = Convert.ToDouble(sureler[8] * 0.5);
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            sureler[9]++;
            label38.Text = sureler[9].ToString() + "dk";
            label37.Text = (sureler[9] * 0.5).ToString() + "₺";
            ucretler[9] = Convert.ToDouble(sureler[9] * 0.5);
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            sureler[10]++;
            label42.Text = sureler[10].ToString() + "dk";
            label41.Text = (sureler[10] * 0.5).ToString() + "₺";
            ucretler[10] = Convert.ToDouble(sureler[10] * 0.5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                timer1.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox13.Visible = true;

            }
            else if (radioButton2.Checked)
            {
                timer2.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox14.Visible = true;
            }
            else if (radioButton3.Checked)
            {
                timer3.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox15.Visible = true;
            }
            else if (radioButton4.Checked)
            {
                timer4.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=4", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox16.Visible = true;
            }
            else if (radioButton5.Checked)
            {
                timer5.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox20.Visible = true;
            }
            else if (radioButton6.Checked)
            {
                timer6.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=6", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox19.Visible = true;
            }
            else if (radioButton7.Checked)
            {
                timer7.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=7", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox18.Visible = true;
            }
            else if (radioButton8.Checked)
            {
                timer8.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox17.Visible = true;
            }
            else if (radioButton9.Checked)
            {
                timer9.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox24.Visible = true;
            }
            else if (radioButton10.Checked)
            {
                timer10.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=10", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox23.Visible = true;
            }
            else if (radioButton11.Checked)
            {
                timer11.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=11", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox22.Visible = true;
            }
            else if (radioButton12.Checked)
            {
                timer12.Start();
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set AcilisSaati=@p1 ,Durum=@p2 where ID=12", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", 1);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pictureBox21.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen Masa Seçiniz");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            SqlCommand komutoku = new SqlCommand("select * from Tbl_Kasa", bgl.baglanti());
            SqlDataReader dr = komutoku.ExecuteReader();
            while (dr.Read())
            {
                toplam += Convert.ToDouble(dr[0].ToString());
            }


            if (radioButton1.Checked)
            {
                timer1.Stop();
                double total = toplam + ucretler[0] + SiparisUcret[0];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=1",bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[0]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[0]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1",bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: "+sureler[0] +"\n Süre ücreti: "+ucretler[0].ToString()+"\nSipariş ücreti: "+SiparisUcret[0]);
                ucretler[0] = 0;
                sureler[0] = 0;
                SiparisUcret[0] = 0;
                label4.Text = "-";
                label3.Text = "-";
                pictureBox13.Visible = false;

            }
            else if (radioButton2.Checked)
            {   
                timer2.Stop();
                double total = toplam + ucretler[1] + SiparisUcret[1];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[1]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[1]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[1] + "\n Süre ücreti: " + ucretler[1].ToString() + "\nSipariş ücreti: " + SiparisUcret[1]); ucretler[1] = 0;
                ucretler[1] = 0;
                sureler[1] = 0;
                SiparisUcret[1] = 0;
                label6.Text = "-";
                label5.Text = "-";
                pictureBox14.Visible = false;


            }
            else if (radioButton3.Checked)
            {
                
                timer3.Stop();
                double total = toplam + ucretler[2] + SiparisUcret[2];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[2]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[2]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[2] + "\n Süre ücreti: " + ucretler[2].ToString() + "\nSipariş ücreti: " + SiparisUcret[2]); ucretler[1] = 0;
                ucretler[2] = 0;
                sureler[2] = 0;
                SiparisUcret[2] = 0;
                label10.Text = "-";
                label9.Text = "-";
                pictureBox15.Visible = false;


            }
            else if (radioButton4.Checked)
            {
                timer4.Stop();
                double total = toplam + ucretler[3] + SiparisUcret[3];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=4", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[3]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[3]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[3] + "\n Süre ücreti: " + ucretler[3].ToString() + "\nSipariş ücreti: " + SiparisUcret[3]); ucretler[1] = 0;
                ucretler[3] = 0;
                sureler[3] = 0;
                SiparisUcret[3] = 0;
                label14.Text = "-";
                label13.Text = "-";
                pictureBox16.Visible = false;
            }
            else if (radioButton5.Checked)
            {
                timer5.Stop();
                double total = toplam + ucretler[4] + SiparisUcret[4];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[4]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[4]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[4] + "\n Süre ücreti: " + ucretler[4].ToString() + "\nSipariş ücreti: " + SiparisUcret[4]); ucretler[1] = 0;
                ucretler[4] = 0;
                sureler[4] = 0;
                SiparisUcret[4] = 0;
                label18.Text = "-";
                label17.Text = "-";
                pictureBox20.Visible = false;


            }
            else if (radioButton6.Checked)
            {
                timer6.Stop();
                double total = toplam + ucretler[5] + SiparisUcret[5];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=6", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[5]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[5]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[5] + "\n Süre ücreti: " + ucretler[5].ToString() + "\nSipariş ücreti: " + SiparisUcret[5]); ucretler[1] = 0;
                ucretler[5] = 0;
                sureler[5] = 0;
                SiparisUcret[5] = 0;
                label22.Text = "-";
                label21.Text = "-";
                pictureBox19.Visible = false;



            }
            else if (radioButton7.Checked)
            {
                timer7.Stop();
                double total = toplam + ucretler[6] + SiparisUcret[6];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=7", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[6]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[6]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[6] + "\n Süre ücreti: " + ucretler[6].ToString() + "\nSipariş ücreti: " + SiparisUcret[6]); ucretler[1] = 0;
                ucretler[6] = 0;
                sureler[6] = 0;
                SiparisUcret[6] = 0;
                label26.Text = "-";
                label25.Text = "-";
                pictureBox18.Visible = false;




            }
            else if (radioButton8.Checked)
            {
                timer8.Stop();
                double total = toplam + ucretler[7] + SiparisUcret[7];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[7]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[7]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[7] + "\n Süre ücreti: " + ucretler[7].ToString() + "\nSipariş ücreti: " + SiparisUcret[7]); ucretler[1] = 0;
                ucretler[7] = 0;
                sureler[7] = 0;
                SiparisUcret[7] = 0;
                label30.Text = "-";
                label29.Text = "-";
                pictureBox17.Visible = false;
            }
            else if (radioButton9.Checked)
            {
                timer9.Stop();
                double total = toplam + ucretler[8] + SiparisUcret[8];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[8]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[8]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[8] + "\n Süre ücreti: " + ucretler[8].ToString() + "\nSipariş ücreti: " + SiparisUcret[8]); ucretler[1] = 0;
                ucretler[8] = 0;
                sureler[8] = 0;
                SiparisUcret[8] = 0;
                label34.Text = "-";
                label33.Text = "-";
                pictureBox24.Visible = false;

            }
            else if (radioButton10.Checked)
            {
                timer10.Stop();
                double total = toplam + ucretler[9] + SiparisUcret[9];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=10", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[9]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[9]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[9] + "\n Süre ücreti: " + ucretler[9].ToString() + "\nSipariş ücreti: " + SiparisUcret[9]); ucretler[1] = 0;
                ucretler[9] = 0;
                sureler[9] = 0;
                SiparisUcret[9] = 0;
                label38.Text = "-";
                label37.Text = "-";
                pictureBox23.Visible = false;
            }
            else if (radioButton11.Checked)
            {
                timer11.Stop();
                double total = toplam + ucretler[10] + SiparisUcret[10];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=11", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[10]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[10]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[10] + "\n Süre ücreti: " + ucretler[10].ToString() + "\nSipariş ücreti: " + SiparisUcret[10]); ucretler[1] = 0;
                ucretler[10] = 0;
                sureler[10] = 0;
                SiparisUcret[10] = 0;
                label42.Text = "-";
                label41.Text = "-";
                pictureBox22.Visible = false;
            }
            else if (radioButton12.Checked)
            {
                timer12.Stop();
                double total = toplam + ucretler[11] + SiparisUcret[11];
                SqlCommand komut = new SqlCommand("update  Tbl_Masa set kapanisSaati=@p1,ucret=@p2,durum=@p3,siparisUcret=@p4 where ID=12", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", DateTime.Now);
                komut.Parameters.AddWithValue("@p2", ucretler[11]);
                komut.Parameters.AddWithValue("@p3", 0);
                komut.Parameters.AddWithValue("@p4", SiparisUcret[11]);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", total);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Toplam süre: " + sureler[11] + "\n Süre ücreti: " + ucretler[11].ToString() + "\nSipariş ücreti: " + SiparisUcret[11]); ucretler[1] = 0;
                ucretler[11] = 0;
                sureler[11] = 0;
                SiparisUcret[11] = 0;
                label46.Text = "-";
                label45.Text = "-";
                pictureBox21.Visible = false;
            }
            else
            {
                MessageBox.Show("Lütfen Masa Seçiniz");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlCommand komut = new SqlCommand("select * from Tbl_Urunler where Kategori=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",comboBox1.SelectedItem);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double ucret = (urunUcret)*(double)(numericUpDown1.Value);
            int masa = (int)numericUpDown2.Value;
            if (comboBox2.Text!="")
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Siparisler (MasaNo,Ücret) values(@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", masa);
                komut.Parameters.AddWithValue("@p2", ucret);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                SiparisUcret[masa-1] = ucret;
                MessageBox.Show("Sipariş yazıldı");
                
            }
            else
            {
                MessageBox.Show("Lütfen ürün seçiniz");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Fiyat from Tbl_Urunler where UrunAdi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBox2.SelectedItem);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label59.Text = dr[0].ToString();
                urunUcret = Convert.ToDouble(dr[0]);
            }
            bgl.baglanti().Close();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Masa where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numericUpDown3.Value);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label69.Text = dr[1].ToString();
                label68.Text = dr[2].ToString();
                label67.Text = dr[3].ToString() + " ₺";
                label66.Text = dr[5].ToString() + " ₺";
                label65.Text = ((double)(dr[3]) + (double)(dr[5])).ToString();
            }

        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            SqlCommand komuts = new SqlCommand("select * from Tbl_Kasa", bgl.baglanti());
            SqlDataReader drs = komuts.ExecuteReader();
            while (drs.Read())
            {
                label55.Text = drs[0].ToString();
                label56.Text = drs[1].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from Tbl_Kasa", bgl.baglanti());
            SqlDataReader drs = komut.ExecuteReader();
            while (drs.Read())
            {
                label55.Text = drs[0].ToString();
                label56.Text = drs[1].ToString();
                double total = ((double)(drs[0]) + (double)(drs[1]));
                label70.Text = total.ToString();
            }
            SqlCommand komut2 = new SqlCommand("update Tbl_Kasa set GunKazanc=@p1,ToplamKazanc=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", 0);
            komut2.Parameters.AddWithValue("@p2", label70.Text);
            komut2.ExecuteNonQuery();


            SqlCommand komut3 = new SqlCommand("select * from Tbl_Kasa", bgl.baglanti());
            SqlDataReader drs3 = komut3.ExecuteReader();
            while (drs3.Read())
            {
                label55.Text = drs3[0].ToString();
                label56.Text = drs3[1].ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmKategoriİslemleri fr = new frmKategoriİslemleri();
            fr.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmUrunİslemleri fr = new frmUrunİslemleri();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKullaniciIslemleri fr = new frmKullaniciIslemleri();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHavaDurumu fr = new frmHavaDurumu();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRadyo fr = new frmRadyo();
            fr.Show();
        }
    }
}






