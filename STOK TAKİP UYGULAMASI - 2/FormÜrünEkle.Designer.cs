namespace STOK_TAKİP_UYGULAMASI___2
{
    partial class FormÜrünEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÜrünEkle));
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnyeniürünekle = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtürünadı = new TextBox();
            label2 = new Label();
            label1 = new Label();
            combomarka = new ComboBox();
            combokategori = new ComboBox();
            txtsatışfiyatı = new TextBox();
            txtalışfiyatı = new TextBox();
            txtmiktar = new TextBox();
            txtbarkodno = new TextBox();
            groupBox2 = new GroupBox();
            label15 = new Label();
            btnvarolanaekle = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtsatışfiyatı2 = new TextBox();
            txtbarkodNo2 = new TextBox();
            txtalışfiyatı2 = new TextBox();
            txtkategori2 = new TextBox();
            txtmiktar2 = new TextBox();
            txtmarka2 = new TextBox();
            txtürünadı2 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnyeniürünekle);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtürünadı);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(combomarka);
            groupBox1.Controls.Add(combokategori);
            groupBox1.Controls.Add(txtsatışfiyatı);
            groupBox1.Controls.Add(txtalışfiyatı);
            groupBox1.Controls.Add(txtmiktar);
            groupBox1.Controls.Add(txtbarkodno);
            groupBox1.Location = new Point(24, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 402);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Ürün";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 297);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 13;
            label7.Text = "Satış Fiyatı :";
            // 
            // btnyeniürünekle
            // 
            btnyeniürünekle.BackColor = Color.Linen;
            btnyeniürünekle.Location = new Point(169, 338);
            btnyeniürünekle.Name = "btnyeniürünekle";
            btnyeniürünekle.Size = new Size(106, 29);
            btnyeniürünekle.TabIndex = 2;
            btnyeniürünekle.Text = "EKLE";
            btnyeniürünekle.UseVisualStyleBackColor = false;
            btnyeniürünekle.Click += btnyeniürünekle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 253);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 12;
            label6.Text = "Alış Fiyatı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 209);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 11;
            label5.Text = "Miktar : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 165);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 10;
            label4.Text = "Ürün Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 121);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 9;
            label3.Text = "Marka : ";
            // 
            // txtürünadı
            // 
            txtürünadı.BackColor = Color.Linen;
            txtürünadı.Location = new Point(134, 164);
            txtürünadı.Name = "txtürünadı";
            txtürünadı.Size = new Size(140, 27);
            txtürünadı.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 77);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 8;
            label2.Text = "Kategori :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 7;
            label1.Text = "Barkod No:";
            // 
            // combomarka
            // 
            combomarka.BackColor = Color.Linen;
            combomarka.FormattingEnabled = true;
            combomarka.Location = new Point(134, 120);
            combomarka.Name = "combomarka";
            combomarka.Size = new Size(140, 28);
            combomarka.TabIndex = 6;
            combomarka.SelectedIndexChanged += combomarka_SelectedIndexChanged;
            // 
            // combokategori
            // 
            combokategori.BackColor = Color.Linen;
            combokategori.FormattingEnabled = true;
            combokategori.Location = new Point(134, 76);
            combokategori.Name = "combokategori";
            combokategori.Size = new Size(140, 28);
            combokategori.TabIndex = 5;
            combokategori.SelectedIndexChanged += combokategori_SelectedIndexChanged;
            // 
            // txtsatışfiyatı
            // 
            txtsatışfiyatı.BackColor = Color.Linen;
            txtsatışfiyatı.Location = new Point(134, 293);
            txtsatışfiyatı.Name = "txtsatışfiyatı";
            txtsatışfiyatı.Size = new Size(140, 27);
            txtsatışfiyatı.TabIndex = 4;
            // 
            // txtalışfiyatı
            // 
            txtalışfiyatı.BackColor = Color.Linen;
            txtalışfiyatı.Location = new Point(134, 250);
            txtalışfiyatı.Name = "txtalışfiyatı";
            txtalışfiyatı.Size = new Size(140, 27);
            txtalışfiyatı.TabIndex = 3;
            // 
            // txtmiktar
            // 
            txtmiktar.BackColor = Color.Linen;
            txtmiktar.Location = new Point(134, 207);
            txtmiktar.Name = "txtmiktar";
            txtmiktar.Size = new Size(140, 27);
            txtmiktar.TabIndex = 2;
            // 
            // txtbarkodno
            // 
            txtbarkodno.BackColor = Color.Linen;
            txtbarkodno.Location = new Point(134, 33);
            txtbarkodno.Name = "txtbarkodno";
            txtbarkodno.Size = new Size(140, 27);
            txtbarkodno.TabIndex = 0;
            txtbarkodno.TextChanged += txtbarkodno_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(btnvarolanaekle);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtsatışfiyatı2);
            groupBox2.Controls.Add(txtbarkodNo2);
            groupBox2.Controls.Add(txtalışfiyatı2);
            groupBox2.Controls.Add(txtkategori2);
            groupBox2.Controls.Add(txtmiktar2);
            groupBox2.Controls.Add(txtmarka2);
            groupBox2.Controls.Add(txtürünadı2);
            groupBox2.Location = new Point(380, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 402);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Var Olan Ürün";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(34, 362);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 21;
            // 
            // btnvarolanaekle
            // 
            btnvarolanaekle.BackColor = Color.Linen;
            btnvarolanaekle.Location = new Point(201, 338);
            btnvarolanaekle.Name = "btnvarolanaekle";
            btnvarolanaekle.Size = new Size(106, 29);
            btnvarolanaekle.TabIndex = 3;
            btnvarolanaekle.Text = "EKLE";
            btnvarolanaekle.UseVisualStyleBackColor = false;
            btnvarolanaekle.Click += btnvarolanaekle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 304);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 20;
            label8.Text = "Satış Fiyatı :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 260);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 19;
            label9.Text = "Alış Fiyatı :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 216);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 18;
            label10.Text = "Miktar : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 172);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 17;
            label11.Text = "Ürün Adı :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 128);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 16;
            label12.Text = "Marka : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(34, 79);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 15;
            label13.Text = "Kategori :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 36);
            label14.Name = "label14";
            label14.Size = new Size(87, 20);
            label14.TabIndex = 14;
            label14.Text = "Barkod No:";
            // 
            // txtsatışfiyatı2
            // 
            txtsatışfiyatı2.BackColor = Color.Linen;
            txtsatışfiyatı2.Location = new Point(166, 297);
            txtsatışfiyatı2.Name = "txtsatışfiyatı2";
            txtsatışfiyatı2.Size = new Size(140, 27);
            txtsatışfiyatı2.TabIndex = 8;
            // 
            // txtbarkodNo2
            // 
            txtbarkodNo2.BackColor = Color.Linen;
            txtbarkodNo2.Location = new Point(166, 33);
            txtbarkodNo2.Name = "txtbarkodNo2";
            txtbarkodNo2.Size = new Size(140, 27);
            txtbarkodNo2.TabIndex = 2;
            txtbarkodNo2.TextChanged += txtbarkodno2_TextChanged;
            // 
            // txtalışfiyatı2
            // 
            txtalışfiyatı2.BackColor = Color.Linen;
            txtalışfiyatı2.Location = new Point(166, 253);
            txtalışfiyatı2.Name = "txtalışfiyatı2";
            txtalışfiyatı2.Size = new Size(140, 27);
            txtalışfiyatı2.TabIndex = 7;
            // 
            // txtkategori2
            // 
            txtkategori2.BackColor = Color.Linen;
            txtkategori2.Location = new Point(166, 77);
            txtkategori2.Name = "txtkategori2";
            txtkategori2.Size = new Size(140, 27);
            txtkategori2.TabIndex = 3;
            // 
            // txtmiktar2
            // 
            txtmiktar2.BackColor = Color.Linen;
            txtmiktar2.Location = new Point(166, 209);
            txtmiktar2.Name = "txtmiktar2";
            txtmiktar2.Size = new Size(140, 27);
            txtmiktar2.TabIndex = 6;
            // 
            // txtmarka2
            // 
            txtmarka2.BackColor = Color.Linen;
            txtmarka2.Location = new Point(166, 121);
            txtmarka2.Name = "txtmarka2";
            txtmarka2.Size = new Size(140, 27);
            txtmarka2.TabIndex = 4;
            // 
            // txtürünadı2
            // 
            txtürünadı2.BackColor = Color.Linen;
            txtürünadı2.Location = new Point(166, 165);
            txtürünadı2.Name = "txtürünadı2";
            txtürünadı2.Size = new Size(140, 27);
            txtürünadı2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(237, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormÜrünEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(748, 628);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Name = "FormÜrünEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekleme Sayfası";
            Load += FormÜrünEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox combomarka;
        private ComboBox combokategori;
        private TextBox txtsatışfiyatı;
        private TextBox txtalışfiyatı;
        private TextBox txtmiktar;
        private TextBox txtürünadı;
        private TextBox txtbarkodno;
        private TextBox txtsatışfiyatı2;
        private TextBox txtbarkodNo2;
        private TextBox txtalışfiyatı2;
        private TextBox txtkategori2;
        private TextBox txtmiktar2;
        private TextBox txtmarka2;
        private TextBox txtürünadı2;
        private Button btnyeniürünekle;
        private Button btnvarolanaekle;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private PictureBox pictureBox1;
    }
}