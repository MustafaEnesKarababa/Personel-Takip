using BusinessLayer.ContextBL;
using BusinessLayer.EntitiesBL;
using EntityLayer.Entities;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();

        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || !string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                ProjeContextBL projeContextBL = new ProjeContextBL();
                int yetkiliId = projeContextBL.YetkiliBL.Login(txtKullaniciAdi.Text, txtSifre.Text);

                if (yetkiliId > 0)
                {
                    Yetkili yetkili = projeContextBL.YetkiliBL.Find(yetkiliId);

                    if (yetkili.YetkiDurum == YetkiDurum.Admin)
                    {
                        if (yetkili.Sifre == txtSifre.Text)
                        {
                            AdminEkrani adminEkrani = new AdminEkrani(yetkiliId);
                            this.Hide();
                            adminEkrani.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kullnaıcı adı veya şifre hatalı, tekrar deneyin", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (yetkili.YetkiDurum == YetkiDurum.Yetkili)
                    {
                        if (yetkili.Sifre == txtSifre.Text && yetkili.AktifDurum == AktifDurum.Aktif)
                        {
                            int hataliDeneme = 0;
                            yetkili.HataliGiris = hataliDeneme;
                            YetkiliBL yetkiliBL = new YetkiliBL();
                            yetkiliBL.Update(yetkili);

                            Login login = new Login();
                            login.GirisTarihi = DateTime.Now;
                            login.YetkiliId = yetkiliId;
                            LoginBL loginBL = new LoginBL();
                            loginBL.Add(login);

                            PersonelListesiEkrani personelListesiEkrani = new PersonelListesiEkrani(yetkiliId);
                            this.Hide();
                            personelListesiEkrani.ShowDialog();
                            this.Show();
                        }
                        else if (yetkili.AktifDurum == AktifDurum.Pasif)
                        {
                            MessageBox.Show("Hesabınız bloke edilmiş durumdadır.Admin ile iletişime geçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            int hataliDeneme = yetkili.HataliGiris;
                            hataliDeneme += 1;
                            yetkili.HataliGiris = hataliDeneme;
                            YetkiliBL yetkiliBL = new YetkiliBL();
                            yetkiliBL.Update(yetkili);

                            if (yetkili.HataliGiris >= 3)
                            {
                                yetkili.AktifDurum = AktifDurum.Pasif;
                                yetkiliBL.Update(yetkili);
                                MessageBox.Show("Şifrenizi 3 kere hatalı girdiniz.Hesabıız bloke edilmiştir.Admin ile iletişime geçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Şifrenizi hatalı girdiniz.Deneme hakkkınız : " + (3 - hataliDeneme), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kayıtlı kullanıcı bulunamadı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bilgileri Eksiksiz Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSifre.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
