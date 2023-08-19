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
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SUDE\\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=True");

        bool durum;
        private void kategoriengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                if (txtBox1.Text == read["kategori"].ToString() || txtBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void FormKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum == true)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + txtBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kategori Eklendi.");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Var", "UYARI");
            }
            txtBox1.Text = "";
        }
    }
}
