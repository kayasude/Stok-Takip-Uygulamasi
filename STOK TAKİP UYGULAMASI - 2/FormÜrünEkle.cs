using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace STOK_TAKİP_UYGULAMASI___2
{
    public partial class FormÜrünEkle : Form
    {
        public FormÜrünEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SUDE\\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=True");

        bool durum;
        private void barkodnoengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                if (txtbarkodNo2.Text == read["barkodno"].ToString() || txtbarkodno.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void Kategori_Getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                combokategori.Items.Add(read["kategori"].ToString());
            }

            baglanti.Close();
        }

        private void FormÜrünEkle_Load(object sender, EventArgs e)
        {
            Kategori_Getir();
        }

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomarka.Items.Clear();
            combomarka.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from markabilgileri where kategori = '" + combokategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                combomarka.Items.Add(read["marka"].ToString());
            }

            baglanti.Close();
        }

        private void btnyeniürünekle_Click(object sender, EventArgs e)
        {

            barkodnoengelle();

            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values (@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih) ", baglanti);

                komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@kategori", combokategori.Text);
                komut.Parameters.AddWithValue("@marka", combomarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtürünadı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtmiktar.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtalışfiyatı.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsatışfiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün eklendi");

            }

            else
            {
                MessageBox.Show("Böyle Bir Barkod No Zaten Var ", "UYARI !");
            }

            combomarka.Items.Clear();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }

                if (item is System.Windows.Forms.ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtbarkodno2_TextChanged(object sender, EventArgs e)
        {
            if (txtbarkodNo2.Text == "")

            {
                txtmiktar2.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        item.Text = "";
                    }
                }
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select*from urun where barkodno like '" + txtbarkodNo2.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txtkategori2.Text = read["kategori"].ToString();
                txtmarka2.Text = read["marka"].ToString();
                txtürünadı2.Text = read["urunadi"].ToString();
                txtmiktar2.Text = read["miktari"].ToString();
                txtalışfiyatı2.Text = read["alisfiyati"].ToString();
                txtsatışfiyatı2.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void btnvarolanaekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'" + int.Parse(txtmiktar2.Text) + "' where barkodno='" + (txtbarkodNo2.Text) + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var Olan Ürüne Eklendi");
        }

        private void combomarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
