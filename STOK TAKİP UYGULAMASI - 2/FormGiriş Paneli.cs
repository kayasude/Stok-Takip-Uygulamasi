using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOK_TAKİP_UYGULAMASI___2
{
    public partial class FormGiriş_Paneli : Form
    {
        public FormGiriş_Paneli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ka = textkullanıcıadı.Text;
            string sifre = txtşifre.Text;
            if (ka == "Sude")
            {
                if (sifre == "75011500")
                {
                    lblsonuc.Text = "Giriş Başarılı";
                }
                else
                {
                    lblsonuc.Text = "Şifre Hatalı";
                }
            }
            else
            {
                lblsonuc.Text = "Kullanıcı Adı Hatalı";
            }

            /*FormGiriş_Paneli baglan = new FormGiriş_Paneli();
            baglan.Show();
            this.Hide();
       */


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
