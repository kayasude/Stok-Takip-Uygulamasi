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
    public partial class FormSatışListele : Form
    {
        public FormSatışListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = SUDE\\SQLEXPRESS; Initial Catalog = stok_takip; Integrated Security = True");
        DataSet daset = new DataSet();

        private void satislistele()

        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from satış", baglanti);
            adtr.Fill(daset, "satış");
            dataGridView1.DataSource = daset.Tables["satış"];

            baglanti.Close();
        }

        private void FormSatışListele_Load(object sender, EventArgs e)
        {
            satislistele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
