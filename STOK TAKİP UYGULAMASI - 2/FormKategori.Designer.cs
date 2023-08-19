namespace STOK_TAKİP_UYGULAMASI___2
{
    partial class FormKategori
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
            label1 = new Label();
            txtBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 82);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Kategori :";
            // 
            // txtBox1
            // 
            txtBox1.BackColor = Color.Linen;
            txtBox1.Location = new Point(191, 82);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(140, 27);
            txtBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Location = new Point(226, 127);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 2;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormKategori
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(464, 210);
            Controls.Add(button1);
            Controls.Add(txtBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FormKategori";
            Text = "Kategori Sayfası";
            Load += FormKategori_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBox1;
        private Button button1;
    }
}