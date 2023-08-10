namespace Personel_Takip
{
    partial class PersonelListesiEkrani
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
            listviewPersonelListe = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnPersonelEkle = new Button();
            btnGuncelle = new Button();
            txtArama = new TextBox();
            lblArama = new Label();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // listviewPersonelListe
            // 
            listviewPersonelListe.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader6, columnHeader3, columnHeader4, columnHeader5 });
            listviewPersonelListe.GridLines = true;
            listviewPersonelListe.Location = new Point(29, 97);
            listviewPersonelListe.Name = "listviewPersonelListe";
            listviewPersonelListe.Size = new Size(579, 236);
            listviewPersonelListe.TabIndex = 0;
            listviewPersonelListe.UseCompatibleStateImageBehavior = false;
            listviewPersonelListe.View = View.Details;
            listviewPersonelListe.SelectedIndexChanged += listviewPersonelListe_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel Ad";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "Soyad";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 2;
            columnHeader3.Text = "Personel TC";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 3;
            columnHeader4.Text = "Doğum Tarihi";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 4;
            columnHeader5.Text = "Cinsiyet";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPersonelEkle
            // 
            btnPersonelEkle.Location = new Point(466, 24);
            btnPersonelEkle.Name = "btnPersonelEkle";
            btnPersonelEkle.Size = new Size(142, 51);
            btnPersonelEkle.TabIndex = 1;
            btnPersonelEkle.Text = "Yeni Personel Ekle";
            btnPersonelEkle.UseVisualStyleBackColor = true;
            btnPersonelEkle.Click += btnPersonelEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(318, 24);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(142, 51);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Personel Detayları";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(134, 39);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(178, 23);
            txtArama.TabIndex = 3;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Location = new Point(29, 42);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(99, 15);
            lblArama.TabIndex = 4;
            lblArama.Text = "Personel Arama  :";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Departman";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 120;
            // 
            // PersonelListesiEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 366);
            Controls.Add(lblArama);
            Controls.Add(txtArama);
            Controls.Add(btnGuncelle);
            Controls.Add(btnPersonelEkle);
            Controls.Add(listviewPersonelListe);
            Name = "PersonelListesiEkrani";
            Text = "Personel Listesi";
            Load += PersonelListesiEkrani_Load;
            Click += PersonelListesiEkrani_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listviewPersonelListe;
        private Button btnPersonelEkle;
        private Button btnGuncelle;
        private TextBox txtArama;
        private Label lblArama;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}