namespace STOK_TAKİP_UYGULAMASI___2
{
    partial class FormGiriş_Paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiriş_Paneli));
            label1 = new Label();
            label2 = new Label();
            txtşifre = new MaskedTextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textkullanıcıadı = new TextBox();
            btngirişyap = new Button();
            checkbenihatırla = new CheckBox();
            lblsonuc = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 199);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "KULLANICI ADI :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 259);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "ŞİFRE : ";
            // 
            // txtşifre
            // 
            txtşifre.Location = new Point(276, 252);
            txtşifre.Mask = "00000";
            txtşifre.Name = "txtşifre";
            txtşifre.Size = new Size(140, 27);
            txtşifre.TabIndex = 3;
            txtşifre.UseSystemPasswordChar = true;
            txtşifre.ValidatingType = typeof(int);
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 181);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Castellar", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(41, 36);
            label3.Name = "label3";
            label3.Size = new Size(436, 34);
            label3.TabIndex = 0;
            label3.Text = "STOK TAKİP SİSTEME GİRİŞ";
            // 
            // textkullanıcıadı
            // 
            textkullanıcıadı.Location = new Point(276, 196);
            textkullanıcıadı.Name = "textkullanıcıadı";
            textkullanıcıadı.Size = new Size(140, 27);
            textkullanıcıadı.TabIndex = 5;
            // 
            // btngirişyap
            // 
            btngirişyap.Location = new Point(322, 332);
            btngirişyap.Name = "btngirişyap";
            btngirişyap.Size = new Size(94, 29);
            btngirişyap.TabIndex = 6;
            btngirişyap.Text = "GİRİŞ YAP";
            btngirişyap.UseVisualStyleBackColor = true;
            btngirişyap.Click += button1_Click;
            // 
            // checkbenihatırla
            // 
            checkbenihatırla.AutoSize = true;
            checkbenihatırla.Location = new Point(290, 285);
            checkbenihatırla.Name = "checkbenihatırla";
            checkbenihatırla.Size = new Size(126, 24);
            checkbenihatırla.TabIndex = 7;
            checkbenihatırla.Text = "BENİ HATIRLA";
            checkbenihatırla.UseVisualStyleBackColor = true;
            checkbenihatırla.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblsonuc
            // 
            lblsonuc.AutoSize = true;
            lblsonuc.Location = new Point(101, 322);
            lblsonuc.Name = "lblsonuc";
            lblsonuc.Size = new Size(0, 20);
            lblsonuc.TabIndex = 8;
            // 
            // FormGiriş_Paneli
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(514, 388);
            Controls.Add(lblsonuc);
            Controls.Add(checkbenihatırla);
            Controls.Add(btngirişyap);
            Controls.Add(textkullanıcıadı);
            Controls.Add(panel1);
            Controls.Add(txtşifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FormGiriş_Paneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox txtşifre;
        private Panel panel1;
        private TextBox textkullanıcıadı;
        private Button btngirişyap;
        private CheckBox checkbenihatırla;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lblsonuc;
    }
}