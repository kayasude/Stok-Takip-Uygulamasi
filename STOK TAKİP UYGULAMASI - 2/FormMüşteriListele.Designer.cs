namespace STOK_TAKİP_UYGULAMASI___2
{
    partial class FormMüşteriListele
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
            dataGridView1 = new DataGridView();
            btngüncelle = new Button();
            txtAdres = new TextBox();
            txtEposta = new TextBox();
            txtAdsoyad = new TextBox();
            adres = new Label();
            eposta = new Label();
            tel = new Label();
            adsoyad = new Label();
            tck = new Label();
            btnsil = new Button();
            label1 = new Label();
            txtTc = new TextBox();
            txtTcAra = new TextBox();
            txtTel = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(398, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(611, 330);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick;
            // 
            // btngüncelle
            // 
            btngüncelle.BackColor = Color.Linen;
            btngüncelle.Location = new Point(205, 377);
            btngüncelle.Name = "btngüncelle";
            btngüncelle.Size = new Size(106, 29);
            btngüncelle.TabIndex = 21;
            btngüncelle.Text = "GÜNCELLE";
            btngüncelle.UseVisualStyleBackColor = false;
            btngüncelle.Click += btngüncelle_Click;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.Linen;
            txtAdres.Location = new Point(205, 319);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(140, 27);
            txtAdres.TabIndex = 20;
            // 
            // txtEposta
            // 
            txtEposta.BackColor = Color.Linen;
            txtEposta.Location = new Point(205, 257);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(140, 27);
            txtEposta.TabIndex = 19;
            // 
            // txtAdsoyad
            // 
            txtAdsoyad.BackColor = Color.Linen;
            txtAdsoyad.Location = new Point(205, 136);
            txtAdsoyad.Name = "txtAdsoyad";
            txtAdsoyad.Size = new Size(140, 27);
            txtAdsoyad.TabIndex = 17;
            // 
            // adres
            // 
            adres.AutoSize = true;
            adres.Location = new Point(42, 326);
            adres.Name = "adres";
            adres.Size = new Size(48, 20);
            adres.TabIndex = 16;
            adres.Text = "Adres";
            // 
            // eposta
            // 
            eposta.AutoSize = true;
            eposta.Location = new Point(42, 264);
            eposta.Name = "eposta";
            eposta.Size = new Size(67, 20);
            eposta.TabIndex = 15;
            eposta.Text = "E - Posta";
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Location = new Point(42, 203);
            tel.Name = "tel";
            tel.Size = new Size(61, 20);
            tel.TabIndex = 14;
            tel.Text = "Tel No :";
            // 
            // adsoyad
            // 
            adsoyad.AutoSize = true;
            adsoyad.Location = new Point(42, 143);
            adsoyad.Name = "adsoyad";
            adsoyad.Size = new Size(92, 20);
            adsoyad.TabIndex = 13;
            adsoyad.Text = "Ad - Soyad :";
            // 
            // tck
            // 
            tck.AutoSize = true;
            tck.Location = new Point(39, 76);
            tck.Name = "tck";
            tck.Size = new Size(100, 20);
            tck.TabIndex = 12;
            tck.Text = "TC Kimlik No:";
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Linen;
            btnsil.Location = new Point(1037, 76);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(101, 34);
            btnsil.TabIndex = 23;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(719, 44);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 24;
            label1.Text = "TC İLE ARAMA :";
            label1.Click += label1_Click;
            // 
            // txtTc
            // 
            txtTc.BackColor = Color.Linen;
            txtTc.Location = new Point(205, 69);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(140, 27);
            txtTc.TabIndex = 27;
            // 
            // txtTcAra
            // 
            txtTcAra.BackColor = Color.Linen;
            txtTcAra.Location = new Point(868, 37);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(140, 27);
            txtTcAra.TabIndex = 28;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // txtTel
            // 
            txtTel.BackColor = Color.Linen;
            txtTel.Location = new Point(205, 196);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(140, 27);
            txtTel.TabIndex = 29;
            // 
            // FormMüşteriListele
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1152, 497);
            Controls.Add(txtTel);
            Controls.Add(txtTcAra);
            Controls.Add(txtTc);
            Controls.Add(label1);
            Controls.Add(btnsil);
            Controls.Add(btngüncelle);
            Controls.Add(txtAdres);
            Controls.Add(txtEposta);
            Controls.Add(txtAdsoyad);
            Controls.Add(adres);
            Controls.Add(eposta);
            Controls.Add(tel);
            Controls.Add(adsoyad);
            Controls.Add(tck);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FormMüşteriListele";
            Text = "Müşteri Listeleme Sayfası";
            Load += FormMüşteriListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btngüncelle;
        private TextBox txtAdres;
        private TextBox txtEposta;
        private TextBox txtAdsoyad;
        private Label adres;
        private Label eposta;
        private Label tel;
        private Label adsoyad;
        private Label tck;
        private Button btnsil;
        private Label label1;
        private TextBox txtTc;
        private TextBox txtTcAra;
        private MaskedTextBox txtTel;
    }
}