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

namespace STOK_TAKİP_UYGULAMASI___2
{
    public partial class MüşteriEkle : Form
    {
        public MüşteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = SUDE\\SQLEXPRESS; Initial Catalog = stok_takip; Integrated Security = True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into müsteri(tc,adsoyad,telefon,email,adres) values(@tc,@adsoyad,@telefon,@email,@adres)", baglanti);

            komut.Parameters.AddWithValue("@tc", textTck.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@email", txtEposta.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("MÜŞTERİ BAŞARIYLA EKLENDİ");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void MüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void textTc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
