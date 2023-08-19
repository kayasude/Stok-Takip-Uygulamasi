namespace STOK_TAKİP_UYGULAMASI___2
{
    partial class MüşteriEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüşteriEkle));
            tck = new Label();
            adsoyad = new Label();
            tel = new Label();
            eposta = new Label();
            adres = new Label();
            txtTc = new TextBox();
            txtAdsoyad = new TextBox();
            txtEposta = new TextBox();
            txtAdres = new TextBox();
            button1 = new Button();
            textTck = new TextBox();
            txtTel = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tck
            // 
            tck.AutoSize = true;
            tck.Location = new Point(73, 187);
            tck.Name = "tck";
            tck.Size = new Size(100, 20);
            tck.TabIndex = 0;
            tck.Text = "TC Kimlik No:";
            // 
            // adsoyad
            // 
            adsoyad.AutoSize = true;
            adsoyad.Location = new Point(73, 251);
            adsoyad.Name = "adsoyad";
            adsoyad.Size = new Size(92, 20);
            adsoyad.TabIndex = 1;
            adsoyad.Text = "Ad - Soyad :";
            adsoyad.Click += label2_Click;
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Location = new Point(73, 311);
            tel.Name = "tel";
            tel.Size = new Size(61, 20);
            tel.TabIndex = 2;
            tel.Text = "Tel No :";
            // 
            // eposta
            // 
            eposta.AutoSize = true;
            eposta.Location = new Point(73, 372);
            eposta.Name = "eposta";
            eposta.Size = new Size(67, 20);
            eposta.TabIndex = 3;
            eposta.Text = "E - Posta";
            // 
            // adres
            // 
            adres.AutoSize = true;
            adres.Location = new Point(73, 434);
            adres.Name = "adres";
            adres.Size = new Size(48, 20);
            adres.TabIndex = 4;
            adres.Text = "Adres";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(0, 0);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(100, 27);
            txtTc.TabIndex = 0;
            // 
            // txtAdsoyad
            // 
            txtAdsoyad.BackColor = Color.Linen;
            txtAdsoyad.Location = new Point(236, 244);
            txtAdsoyad.Name = "txtAdsoyad";
            txtAdsoyad.Size = new Size(140, 27);
            txtAdsoyad.TabIndex = 1;
            // 
            // txtEposta
            // 
            txtEposta.BackColor = Color.Linen;
            txtEposta.Location = new Point(236, 365);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(140, 27);
            txtEposta.TabIndex = 3;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.Linen;
            txtAdres.Location = new Point(236, 427);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(140, 27);
            txtAdres.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Location = new Point(236, 485);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 5;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textTck
            // 
            textTck.BackColor = Color.Linen;
            textTck.Location = new Point(236, 187);
            textTck.Name = "textTck";
            textTck.Size = new Size(140, 27);
            textTck.TabIndex = 7;
            // 
            // txtTel
            // 
            txtTel.BackColor = Color.Linen;
            txtTel.Location = new Point(236, 304);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(140, 27);
            txtTel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // MüşteriEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(456, 551);
            Controls.Add(pictureBox1);
            Controls.Add(txtTel);
            Controls.Add(textTck);
            Controls.Add(button1);
            Controls.Add(txtAdres);
            Controls.Add(txtEposta);
            Controls.Add(txtAdsoyad);
            Controls.Add(adres);
            Controls.Add(eposta);
            Controls.Add(tel);
            Controls.Add(adsoyad);
            Controls.Add(tck);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "MüşteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MüşteriEkle";
            Load += MüşteriEkle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tck;
        private Label adsoyad;
        private Label tel;
        private Label eposta;
        private Label adres;
        private TextBox txtTcK;
        private TextBox txtAdsoyad;
        private TextBox txtEposta;
        private TextBox txtAdres;
        private Button button1;
        private TextBox txtTc;
        private TextBox textTck;
        private MaskedTextBox txtTel;
        private PictureBox pictureBox1;
    }
}