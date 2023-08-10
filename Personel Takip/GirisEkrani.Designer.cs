namespace Personel_Takip
{
    partial class GirisEkrani
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
            lblOzelKarakter2 = new Label();
            lblOzelKarakter = new Label();
            btnGiris = new Button();
            lblSifre = new Label();
            lblKullaniciAdi = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            cbxSifre = new CheckBox();
            SuspendLayout();
            // 
            // lblOzelKarakter2
            // 
            lblOzelKarakter2.AutoSize = true;
            lblOzelKarakter2.Location = new Point(166, 125);
            lblOzelKarakter2.Name = "lblOzelKarakter2";
            lblOzelKarakter2.Size = new Size(10, 15);
            lblOzelKarakter2.TabIndex = 13;
            lblOzelKarakter2.Text = ":";
            // 
            // lblOzelKarakter
            // 
            lblOzelKarakter.AutoSize = true;
            lblOzelKarakter.Location = new Point(166, 86);
            lblOzelKarakter.Name = "lblOzelKarakter";
            lblOzelKarakter.Size = new Size(10, 15);
            lblOzelKarakter.TabIndex = 12;
            lblOzelKarakter.Text = ":";
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.Location = new Point(70, 208);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(291, 34);
            btnGiris.TabIndex = 9;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(89, 125);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(30, 15);
            lblSifre.TabIndex = 11;
            lblSifre.Text = "Şifre";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(70, 86);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 10;
            lblKullaniciAdi.Text = "Kullanıcı Adı ";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(199, 122);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(162, 23);
            txtSifre.TabIndex = 8;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(199, 83);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(162, 23);
            txtKullaniciAdi.TabIndex = 7;
            // 
            // cbxSifre
            // 
            cbxSifre.AutoSize = true;
            cbxSifre.Location = new Point(237, 162);
            cbxSifre.Name = "cbxSifre";
            cbxSifre.Size = new Size(86, 19);
            cbxSifre.TabIndex = 14;
            cbxSifre.Text = "Şifre Göster";
            cbxSifre.UseVisualStyleBackColor = true;
            cbxSifre.CheckedChanged += cbxSifre_CheckedChanged;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 317);
            Controls.Add(cbxSifre);
            Controls.Add(lblOzelKarakter2);
            Controls.Add(lblOzelKarakter);
            Controls.Add(btnGiris);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "GirisEkrani";
            Text = "Giriş Ekranı";
            Load += GirisEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOzelKarakter2;
        private Label lblOzelKarakter;
        private Button btnGiris;
        private Label lblSifre;
        private Label lblKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private CheckBox cbxSifre;
    }
}