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

namespace STOK_TAKİP_UYGULAMASI___2
{
    public partial class FormÜrünListele : Form
    {
        public FormÜrünListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = SUDE\\SQLEXPRESS; Initial Catalog = stok_takip; Integrated Security = True");
        DataSet daset = new DataSet();


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



        private void FormÜrünListele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            Kategori_Getir();
        }

        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from urun ", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbarkodNo2.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txtkategori2.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtmarka2.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txtürünadı2.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txtmiktar2.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            txtalışfiyatı2.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            txtsatışfiyatı2.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" update urun set urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", baglanti);

            komut.Parameters.AddWithValue("@barkodno", txtbarkodNo2.Text);
            komut.Parameters.AddWithValue("@urunadi", txtürünadı2.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(txtmiktar2.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtalışfiyatı2.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsatışfiyatı2.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();

            daset.Tables["urun"].Clear();
            ÜrünListele();

            MessageBox.Show("Güncelleme Yapıldı");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void btnmarkagüncelleme_Click(object sender, EventArgs e)
        {

            if (txtbarkodNo2.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(" update urun set marka=@marka,kategori=@kategori where barkodno=@barkodno", baglanti);

                komut.Parameters.AddWithValue("@barkodno", txtbarkodNo2.Text);
                komut.Parameters.AddWithValue("@kategori", combokategori.Text);
                komut.Parameters.AddWithValue("@marka", combomarka.Text);


                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Yapıldı");

                daset.Tables["urun"].Clear();
                ÜrünListele();
            }

            else
            {
                MessageBox.Show("Lütfen Barkod No Giriniz ! ");
            }



            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno ='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();

            MessageBox.Show("Ürün Başarıyla Silindi");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun where barkodno like '%" + txtbarkodnoara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
