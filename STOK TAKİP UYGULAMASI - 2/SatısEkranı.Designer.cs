namespace STOK_TAKİP_UYGULAMASI___2
{
    partial class SATIS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SATIS));
            dataGridView1 = new DataGridView();
            MÜŞTERİ = new GroupBox();
            textTelNo = new MaskedTextBox();
            txtTc = new TextBox();
            tel = new Label();
            adsoyad = new Label();
            tc = new Label();
            textAdsoyad = new TextBox();
            groupBox2 = new GroupBox();
            toplamfiyat = new Label();
            satışfiyat = new Label();
            miktar = new Label();
            ürünadı = new Label();
            barkodno = new Label();
            textToplamFiyat = new TextBox();
            textSatışFiyat = new TextBox();
            textMiktar = new TextBox();
            textÜrünAdı = new TextBox();
            textBarkodNo = new TextBox();
            buttonekle = new Button();
            buttonsatışyap = new Button();
            buttonsil = new Button();
            buttonsatışiptal = new Button();
            label9 = new Label();
            lblGenelToplam = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            MÜŞTERİ.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(595, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(634, 363);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // MÜŞTERİ
            // 
            MÜŞTERİ.Controls.Add(textTelNo);
            MÜŞTERİ.Controls.Add(txtTc);
            MÜŞTERİ.Controls.Add(tel);
            MÜŞTERİ.Controls.Add(adsoyad);
            MÜŞTERİ.Controls.Add(tc);
            MÜŞTERİ.Controls.Add(textAdsoyad);
            MÜŞTERİ.Location = new Point(234, 114);
            MÜŞTERİ.Name = "MÜŞTERİ";
            MÜŞTERİ.Size = new Size(346, 159);
            MÜŞTERİ.TabIndex = 1;
            MÜŞTERİ.TabStop = false;
            MÜŞTERİ.Text = "MÜŞTERİ İŞLEMLERİ";
            MÜŞTERİ.Enter += MÜŞTERİ_Enter;
            // 
            // textTelNo
            // 
            textTelNo.BackColor = Color.Linen;
            textTelNo.Location = new Point(189, 107);
            textTelNo.Mask = "(999) 000-0000";
            textTelNo.Name = "textTelNo";
            textTelNo.Size = new Size(140, 27);
            textTelNo.TabIndex = 8;
            // 
            // txtTc
            // 
            txtTc.BackColor = Color.Linen;
            txtTc.Location = new Point(189, 26);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(140, 27);
            txtTc.TabIndex = 7;
            txtTc.TextChanged += textTCKimlikNo_TextChanged;
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Location = new Point(46, 107);
            tel.Name = "tel";
            tel.Size = new Size(61, 20);
            tel.TabIndex = 5;
            tel.Text = "Tel No :";
            // 
            // adsoyad
            // 
            adsoyad.AutoSize = true;
            adsoyad.Location = new Point(47, 67);
            adsoyad.Name = "adsoyad";
            adsoyad.Size = new Size(92, 20);
            adsoyad.TabIndex = 4;
            adsoyad.Text = "Ad - Soyad :";
            // 
            // tc
            // 
            tc.AutoSize = true;
            tc.Location = new Point(47, 33);
            tc.Name = "tc";
            tc.Size = new Size(106, 20);
            tc.TabIndex = 3;
            tc.Text = "TC Kimlik NO :";
            // 
            // textAdsoyad
            // 
            textAdsoyad.BackColor = Color.Linen;
            textAdsoyad.Location = new Point(189, 64);
            textAdsoyad.Name = "textAdsoyad";
            textAdsoyad.Size = new Size(140, 27);
            textAdsoyad.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toplamfiyat);
            groupBox2.Controls.Add(satışfiyat);
            groupBox2.Controls.Add(miktar);
            groupBox2.Controls.Add(ürünadı);
            groupBox2.Controls.Add(barkodno);
            groupBox2.Controls.Add(textToplamFiyat);
            groupBox2.Controls.Add(textSatışFiyat);
            groupBox2.Controls.Add(textMiktar);
            groupBox2.Controls.Add(textÜrünAdı);
            groupBox2.Controls.Add(textBarkodNo);
            groupBox2.Location = new Point(234, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 191);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // toplamfiyat
            // 
            toplamfiyat.AutoSize = true;
            toplamfiyat.Location = new Point(47, 154);
            toplamfiyat.Name = "toplamfiyat";
            toplamfiyat.Size = new Size(104, 20);
            toplamfiyat.TabIndex = 9;
            toplamfiyat.Text = "Toplam Fiyat :";
            // 
            // satışfiyat
            // 
            satışfiyat.AutoSize = true;
            satışfiyat.Location = new Point(47, 121);
            satışfiyat.Name = "satışfiyat";
            satışfiyat.Size = new Size(89, 20);
            satışfiyat.TabIndex = 8;
            satışfiyat.Text = "Satış Fiyatı :";
            // 
            // miktar
            // 
            miktar.AutoSize = true;
            miktar.Location = new Point(47, 88);
            miktar.Name = "miktar";
            miktar.Size = new Size(62, 20);
            miktar.TabIndex = 7;
            miktar.Text = "Miktar :";
            // 
            // ürünadı
            // 
            ürünadı.AutoSize = true;
            ürünadı.Location = new Point(47, 55);
            ürünadı.Name = "ürünadı";
            ürünadı.Size = new Size(79, 20);
            ürünadı.TabIndex = 6;
            ürünadı.Text = "Ürün Adı :";
            // 
            // barkodno
            // 
            barkodno.AutoSize = true;
            barkodno.Location = new Point(47, 25);
            barkodno.Name = "barkodno";
            barkodno.Size = new Size(91, 20);
            barkodno.TabIndex = 5;
            barkodno.Text = "Barkod No :";
            // 
            // textToplamFiyat
            // 
            textToplamFiyat.BackColor = Color.Linen;
            textToplamFiyat.Location = new Point(189, 154);
            textToplamFiyat.Name = "textToplamFiyat";
            textToplamFiyat.Size = new Size(140, 27);
            textToplamFiyat.TabIndex = 4;
            // 
            // textSatışFiyat
            // 
            textSatışFiyat.BackColor = Color.Linen;
            textSatışFiyat.Location = new Point(189, 121);
            textSatışFiyat.Name = "textSatışFiyat";
            textSatışFiyat.Size = new Size(140, 27);
            textSatışFiyat.TabIndex = 3;
            textSatışFiyat.TextChanged += textSatışFiyat_TextChanged;
            // 
            // textMiktar
            // 
            textMiktar.BackColor = Color.Linen;
            textMiktar.Location = new Point(189, 88);
            textMiktar.Name = "textMiktar";
            textMiktar.Size = new Size(140, 27);
            textMiktar.TabIndex = 2;
            textMiktar.Text = "1";
            textMiktar.TextAlign = HorizontalAlignment.Center;
            textMiktar.TextChanged += textMiktar_TextChanged;
            // 
            // textÜrünAdı
            // 
            textÜrünAdı.BackColor = Color.Linen;
            textÜrünAdı.Location = new Point(189, 55);
            textÜrünAdı.Name = "textÜrünAdı";
            textÜrünAdı.Size = new Size(140, 27);
            textÜrünAdı.TabIndex = 1;
            // 
            // textBarkodNo
            // 
            textBarkodNo.BackColor = Color.Linen;
            textBarkodNo.Location = new Point(189, 22);
            textBarkodNo.Name = "textBarkodNo";
            textBarkodNo.Size = new Size(140, 27);
            textBarkodNo.TabIndex = 0;
            textBarkodNo.TextChanged += textBarkodNo_TextChanged;
            // 
            // buttonekle
            // 
            buttonekle.BackColor = Color.Linen;
            buttonekle.ForeColor = Color.Black;
            buttonekle.Location = new Point(595, 492);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(106, 29);
            buttonekle.TabIndex = 3;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = false;
            buttonekle.Click += buttonekle_Click;
            // 
            // buttonsatışyap
            // 
            buttonsatışyap.BackColor = Color.Linen;
            buttonsatışyap.Location = new Point(1123, 497);
            buttonsatışyap.Name = "buttonsatışyap";
            buttonsatışyap.Size = new Size(106, 29);
            buttonsatışyap.TabIndex = 4;
            buttonsatışyap.Text = "SATIŞ YAP";
            buttonsatışyap.UseVisualStyleBackColor = false;
            buttonsatışyap.Click += buttonsatışyap_Click;
            // 
            // buttonsil
            // 
            buttonsil.BackColor = Color.Linen;
            buttonsil.Location = new Point(1235, 114);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(106, 29);
            buttonsil.TabIndex = 5;
            buttonsil.Text = "SİL";
            buttonsil.UseVisualStyleBackColor = false;
            buttonsil.Click += buttonsil_Click;
            // 
            // buttonsatışiptal
            // 
            buttonsatışiptal.BackColor = Color.Linen;
            buttonsatışiptal.Location = new Point(1235, 149);
            buttonsatışiptal.Name = "buttonsatışiptal";
            buttonsatışiptal.Size = new Size(106, 29);
            buttonsatışiptal.TabIndex = 6;
            buttonsatışiptal.Text = "SATIŞ İPTAL";
            buttonsatışiptal.UseVisualStyleBackColor = false;
            buttonsatışiptal.Click += buttonsatışiptal_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(911, 497);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 7;
            label9.Text = "Genel Toplam :";
            label9.Click += label9_Click_1;
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Location = new Point(846, 501);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(0, 20);
            lblGenelToplam.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1347, 92);
            panel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Location = new Point(875, 25);
            button2.Name = "button2";
            button2.Size = new Size(116, 51);
            button2.TabIndex = 6;
            button2.Text = "KATEGORİ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Location = new Point(747, 25);
            button1.Name = "button1";
            button1.Size = new Size(122, 51);
            button1.TabIndex = 5;
            button1.Text = "MARKA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Linen;
            button9.Location = new Point(1036, 27);
            button9.Name = "button9";
            button9.Size = new Size(133, 49);
            button9.TabIndex = 4;
            button9.Text = "SATIŞLARI LİSTELE";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Linen;
            button8.Location = new Point(536, 27);
            button8.Name = "button8";
            button8.Size = new Size(116, 51);
            button8.TabIndex = 3;
            button8.Text = "ÜRÜN LİSTELE";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.Linen;
            button7.Location = new Point(412, 27);
            button7.Name = "button7";
            button7.Size = new Size(117, 51);
            button7.TabIndex = 2;
            button7.Text = "ÜRÜN EKLE";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Linen;
            button6.Location = new Point(182, 27);
            button6.Name = "button6";
            button6.Size = new Size(138, 51);
            button6.TabIndex = 1;
            button6.Text = "MÜŞTERİ LİSTELE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.Linen;
            button5.Location = new Point(36, 27);
            button5.Name = "button5";
            button5.Size = new Size(140, 51);
            button5.TabIndex = 0;
            button5.Text = "MÜŞTERİ EKLE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SATIS
            // 
            AcceptButton = buttonekle;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1347, 537);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblGenelToplam);
            Controls.Add(label9);
            Controls.Add(buttonsatışiptal);
            Controls.Add(buttonsil);
            Controls.Add(buttonsatışyap);
            Controls.Add(buttonekle);
            Controls.Add(groupBox2);
            Controls.Add(MÜŞTERİ);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "SATIS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SATIS";
            Load += SATIS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            MÜŞTERİ.ResumeLayout(false);
            MÜŞTERİ.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox MÜŞTERİ;
        private GroupBox groupBox2;
        private TextBox textAdsoyad;
        private TextBox textToplamFiyat;
        private TextBox textSatışFiyat;
        private TextBox textMiktar;
        private TextBox textÜrünAdı;
        private TextBox textBarkodNo;
        private Label tel;
        private Label adsoyad;
        private Label tc;
        private Label toplamfiyat;
        private Label satışfiyat;
        private Label miktar;
        private Label ürünadı;
        private Label barkodno;
        private Button buttonekle;
        private Button buttonsatışyap;
        private Button buttonsil;
        private Button buttonsatışiptal;
        private Label label9;
        private Label lblGenelToplam;
        private Panel panel1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button9;
        private Button button2;
        private Button button1;
        private TextBox txtTc;
        private MaskedTextBox textTelNo;
        private PictureBox pictureBox1;
    }
}