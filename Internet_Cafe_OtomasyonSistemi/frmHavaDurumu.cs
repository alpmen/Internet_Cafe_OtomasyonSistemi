using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Internet_Cafe_OtomasyonSistemi
{
    public partial class frmHavaDurumu : Form
    {
        public frmHavaDurumu()
        {
            InitializeComponent();
        }

        private void frmHavaDurumu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string api = "a89628607be204417aed37bea3dfb38f";
                string connection =
                    "https://api.openweathermap.org/data/2.5/weather?q=" + textBox1.Text.ToLower() + "&mode=xml&lang=tr&units=metric&appid=" + api;
                XDocument weather = XDocument.Load(connection);
                var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                var state = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
                var nem = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                var rüzgar = weather.Descendants("speed").ElementAt(0).Attribute("value").Value;
                label10.Text = temp + " '";
                label9.Text = state + " ";
                label8.Text = nem + " %";
                label7.Text = rüzgar + " km/s";
            }
            catch (Exception)
            {

                MessageBox.Show("Böyle bir yer bulunamadı");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
