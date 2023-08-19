using System.Data;
using System.Data.SqlClient;

namespace STOK_TAKİP_UYGULAMASI___2
{
    public partial class SATIS : Form
    {
        public SATIS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = SUDE\\SQLEXPRESS; Initial Catalog = stok_takip; Integrated Security = True");
        DataSet daset = new DataSet();

        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            baglanti.Close();
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FormMüşteriListele listele = new FormMüşteriListele();
            listele.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MüşteriEkle ekle = new MüşteriEkle();
            ekle.ShowDialog();
        }

        private void textTCKimlikNo_TextChanged(object sender, EventArgs e)
        {

            if (txtTc.Text == "")
            {
                textAdsoyad.Text = "";
                textTelNo.Text = "";
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from müsteri where tc like '" + txtTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                textAdsoyad.Text = read["adsoyad"].ToString();
                textTelNo.Text = read["telefon"].ToString();
            }

            baglanti.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormÜrünEkle ekle = new FormÜrünEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKategori kategori = new FormKategori();
            kategori.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormSatışListele listele = new FormSatışListele();
            listele.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMarka marka = new FormMarka();
            marka.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            FormÜrünListele listele = new FormÜrünListele();
            listele.ShowDialog();
        }

        private void hesapla()
        {

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }


        private void SATIS_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }


        private void textBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from urun where barkodno like '" + textBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                textÜrünAdı.Text = read["urunadi"].ToString();
                textSatışFiyat.Text = read["satisfiyati"].ToString();
            }

            baglanti.Close();
        }

        private void Temizle()
        {
            if (textBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != textMiktar)
                        {
                            item.Text = "";
                        }
                    }


                }
            }
        }

        private void FormSatıs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
            {
                textMiktar.Text = textBarkodNo.Text.Substring(textBarkodNo.Text.Length - 1);
                textBarkodNo.Text = "";
            }
        }

        bool durum;
        private void Barkodkontrol()
        {
            durum = true;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                if (textBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }

            baglanti.Close();
        }
        private void buttonekle_Click(object sender, EventArgs e)
        {
            Barkodkontrol();

            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,barkodno,adsoyad,telefon,urunadi,miktari,satisfiyati,toplamfiyat,tarih) values(@tc,@barkodno,@adsoyad,@telefon,@urunadi,@miktari,@satisfiyati,@toplamfiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@barkodno", textBarkodNo.Text);
                komut.Parameters.AddWithValue("@adsoyad", textAdsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", textTelNo.Text);
                komut.Parameters.AddWithValue("@urunadi", textÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(textMiktar.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(textSatışFiyat.Text));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(textToplamFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set miktari=miktari+'" + int.Parse(textMiktar.Text) + "'where barkodno ='" + textBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyat = miktari * satisfiyati where barkodno='" + textBarkodNo.Text + "'", baglanti);


                komut3.ExecuteNonQuery();

                baglanti.Close();

            }


            textMiktar.Text = "1";

            daset.Tables["sepet"].Clear();

            sepetlistele();
            Temizle();
            hesapla();


            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != textMiktar)
                    {
                        item.Text = "";
                    }
                }


            }


        }

        private void textMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textToplamFiyat.Text = (double.Parse(textMiktar.Text) * double.Parse(textSatışFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void textSatışFiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textToplamFiyat.Text = (double.Parse(textMiktar.Text) * double.Parse(textSatışFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno = '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün Sepetten Silindi.");

            daset.Tables["sepet"].Clear();

            sepetlistele();
            hesapla();
        }

        private void buttonsatışiptal_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı.");

            daset.Tables["sepet"].Clear();


            sepetlistele();
            hesapla();
        }

        private void buttonsatışyap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satış (tc,barkodno,adsoyad,telefon,urunadi,miktari,satisfiyati,toplamfiyat,tarih) values(@tc,@barkodno,@adsoyad,@telefon,@urunadi,@miktari,@satisfiyati,@toplamfiyat,@tarih)", baglanti);


                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@adsoyad", textAdsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", textTelNo.Text);
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + (dataGridView1.Rows[i].Cells["barkodno"].Value.ToString()) + "'", baglanti);
                komut2.ExecuteNonQuery();

                baglanti.Close();




            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();

            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }



        private void txtTc_TextInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MÜŞTERİ_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}