namespace Personel_Takip
{
    partial class AdminEkrani
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            lblKullaniciAdi = new Label();
            btnSil = new Button();
            lblSifre = new Label();
            btnGuncelle = new Button();
            btnEkle = new Button();
            lblOzelKarakter = new Label();
            lblOzelKarakter2 = new Label();
            lviewYetkiliListe = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            rbtnAktif = new RadioButton();
            rbtnPasif = new RadioButton();
            rbtnYetkili = new RadioButton();
            rbtnAdmin = new RadioButton();
            gbxDurum = new GroupBox();
            gbxYetki = new GroupBox();
            gbxDurum.SuspendLayout();
            gbxYetki.SuspendLayout();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(262, 28);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(139, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(262, 71);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(136, 23);
            txtSifre.TabIndex = 2;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(150, 31);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(73, 15);
            lblKullaniciAdi.TabIndex = 5;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(87, 201);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(125, 34);
            btnSil.TabIndex = 6;
            btnSil.Text = "Yetkili Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(150, 74);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(30, 15);
            lblSifre.TabIndex = 7;
            lblSifre.Text = "Şifre";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(218, 201);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(135, 34);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(359, 201);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 34);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "Yetkili Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblOzelKarakter
            // 
            lblOzelKarakter.AutoSize = true;
            lblOzelKarakter.Location = new Point(245, 31);
            lblOzelKarakter.Name = "lblOzelKarakter";
            lblOzelKarakter.Size = new Size(10, 15);
            lblOzelKarakter.TabIndex = 12;
            lblOzelKarakter.Text = ":";
            // 
            // lblOzelKarakter2
            // 
            lblOzelKarakter2.AutoSize = true;
            lblOzelKarakter2.Location = new Point(245, 74);
            lblOzelKarakter2.Name = "lblOzelKarakter2";
            lblOzelKarakter2.Size = new Size(10, 15);
            lblOzelKarakter2.TabIndex = 13;
            lblOzelKarakter2.Text = ":";
            // 
            // lviewYetkiliListe
            // 
            lviewYetkiliListe.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lviewYetkiliListe.GridLines = true;
            lviewYetkiliListe.Location = new Point(13, 265);
            lviewYetkiliListe.Name = "lviewYetkiliListe";
            lviewYetkiliListe.Size = new Size(530, 183);
            lviewYetkiliListe.TabIndex = 16;
            lviewYetkiliListe.UseCompatibleStateImageBehavior = false;
            lviewYetkiliListe.View = View.Details;
            lviewYetkiliListe.SelectedIndexChanged += lviewYetkiliListe_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Kullanıcı Adı";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Şifre";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Aktif / Pasif";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Son Giriş Zamanı";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Yetki Durumu";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // rbtnAktif
            // 
            rbtnAktif.AutoSize = true;
            rbtnAktif.Location = new Point(38, 37);
            rbtnAktif.Name = "rbtnAktif";
            rbtnAktif.Size = new Size(50, 19);
            rbtnAktif.TabIndex = 17;
            rbtnAktif.TabStop = true;
            rbtnAktif.Text = "Aktif";
            rbtnAktif.UseVisualStyleBackColor = true;
            // 
            // rbtnPasif
            // 
            rbtnPasif.AutoSize = true;
            rbtnPasif.Location = new Point(118, 37);
            rbtnPasif.Name = "rbtnPasif";
            rbtnPasif.Size = new Size(50, 19);
            rbtnPasif.TabIndex = 18;
            rbtnPasif.TabStop = true;
            rbtnPasif.Text = "Pasif";
            rbtnPasif.UseVisualStyleBackColor = true;
            // 
            // rbtnYetkili
            // 
            rbtnYetkili.AutoSize = true;
            rbtnYetkili.Location = new Point(118, 37);
            rbtnYetkili.Name = "rbtnYetkili";
            rbtnYetkili.Size = new Size(56, 19);
            rbtnYetkili.TabIndex = 22;
            rbtnYetkili.TabStop = true;
            rbtnYetkili.Text = "Yetkili";
            rbtnYetkili.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            rbtnAdmin.AutoSize = true;
            rbtnAdmin.Location = new Point(32, 37);
            rbtnAdmin.Name = "rbtnAdmin";
            rbtnAdmin.Size = new Size(61, 19);
            rbtnAdmin.TabIndex = 21;
            rbtnAdmin.TabStop = true;
            rbtnAdmin.Text = "Admin";
            rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxDurum
            // 
            gbxDurum.Controls.Add(rbtnPasif);
            gbxDurum.Controls.Add(rbtnAktif);
            gbxDurum.Location = new Point(87, 117);
            gbxDurum.Name = "gbxDurum";
            gbxDurum.Size = new Size(195, 78);
            gbxDurum.TabIndex = 23;
            gbxDurum.TabStop = false;
            gbxDurum.Text = "Hesap Durumu";
            // 
            // gbxYetki
            // 
            gbxYetki.Controls.Add(rbtnYetkili);
            gbxYetki.Controls.Add(rbtnAdmin);
            gbxYetki.Location = new Point(288, 117);
            gbxYetki.Name = "gbxYetki";
            gbxYetki.Size = new Size(195, 78);
            gbxYetki.TabIndex = 24;
            gbxYetki.TabStop = false;
            gbxYetki.Text = "Yetki Durumu";
            // 
            // AdminEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 459);
            Controls.Add(gbxYetki);
            Controls.Add(gbxDurum);
            Controls.Add(lviewYetkiliListe);
            Controls.Add(lblOzelKarakter2);
            Controls.Add(lblOzelKarakter);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(lblSifre);
            Controls.Add(btnSil);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "AdminEkrani";
            Text = "AdminEkrani";
            Load += AdminEkrani_Load;
            Click += AdminEkrani_Click;
            gbxDurum.ResumeLayout(false);
            gbxDurum.PerformLayout();
            gbxYetki.ResumeLayout(false);
            gbxYetki.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label lblKullaniciAdi;
        private Button btnSil;
        private Label lblSifre;
        private Button btnGuncelle;
        private Button btnEkle;
        private Label lblOzelKarakter;
        private Label lblOzelKarakter2;
        private ListView lviewYetkiliListe;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private RadioButton rbtnAktif;
        private RadioButton rbtnPasif;
        private ColumnHeader columnHeader4;
        private RadioButton rbtnYetkili;
        private RadioButton rbtnAdmin;
        private ColumnHeader columnHeader5;
        private GroupBox gbxDurum;
        private GroupBox gbxYetki;
    }
}