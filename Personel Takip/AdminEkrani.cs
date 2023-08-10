using BusinessLayer.ContextBL;
using DataAccessLayer.Context;
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
    public partial class AdminEkrani : Form
    {
        public AdminEkrani(int Id)
        {
            InitializeComponent();
            adminId = Id;
            db = new ProjeContextBL();
        }

        private int adminId;
        ProjeContextBL db;
        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            ListViewDoldur();
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            btnEkle.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lviewYetkiliListe.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Kullanıcıyı tamamen silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Yetkili yetkili = (Yetkili)lviewYetkiliListe.SelectedItems[0].Tag;
                    db.YetkiliBL.Delete(yetkili.YetkiliId);
                    ListViewDoldur();
                    MessageBox.Show("Kullanıcı hesabı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lviewYetkiliListe.SelectedItems.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) && !string.IsNullOrWhiteSpace(txtSifre.Text))
                {

                    Yetkili yetkili = (Yetkili)lviewYetkiliListe.SelectedItems[0].Tag;
                    yetkili.KullaniciAdi = txtKullaniciAdi.Text;
                    yetkili.Sifre = txtSifre.Text;
                    if (rbtnAktif.Checked)
                    {
                        yetkili.AktifDurum = AktifDurum.Aktif;
                        yetkili.HataliGiris = 0;
                    }
                    else if (rbtnPasif.Checked)
                    {
                        yetkili.AktifDurum = AktifDurum.Pasif;
                    }

                    if (rbtnAdmin.Checked)
                    {
                        yetkili.YetkiDurum = YetkiDurum.Admin;
                    }
                    else if (rbtnYetkili.Checked)
                    {
                        yetkili.YetkiDurum = YetkiDurum.Yetkili;
                    }

                    db.YetkiliBL.Update(yetkili);
                    ListViewDoldur();
                    MessageBox.Show("Kullanıcı bilgileri güncellendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) && !string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                if (!KullaniciAdiKontrol(txtKullaniciAdi.Text))
                {
                    return;
                }
                if (!SifreKontrol(txtSifre.Text))
                {
                    return;
                }


                if (rbtnAdmin.Checked || rbtnYetkili.Checked)
                {
                    if (rbtnAktif.Checked || rbtnPasif.Checked)
                    {

                        Yetkili yetkili = new Yetkili();
                        yetkili.KullaniciAdi = txtKullaniciAdi.Text;
                        yetkili.Sifre = txtSifre.Text;
                        if (rbtnAktif.Checked)
                        {
                            yetkili.AktifDurum = AktifDurum.Aktif;
                        }
                        else if (rbtnPasif.Checked)
                        {
                            yetkili.AktifDurum = AktifDurum.Pasif;
                        }

                        if (rbtnAdmin.Checked)
                        {
                            yetkili.YetkiDurum = YetkiDurum.Admin;
                        }
                        else if (rbtnYetkili.Checked)
                        {
                            yetkili.YetkiDurum = YetkiDurum.Yetkili;
                        }

                        db.YetkiliBL.Add(yetkili);
                        ListViewDoldur();
                        MessageBox.Show("Yeni kullanıcı oluşturuldu", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Hesap durumunu belirlemeniz gerekmektedir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcının yetkisini belirlemeniz gerekmektedir", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AdminEkrani_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            rbtnAktif.Checked = false;
            rbtnPasif.Checked = false;
            rbtnAdmin.Checked = false;
            rbtnYetkili.Checked = false;
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            btnEkle.Enabled = true;
        }
        private void lviewYetkiliListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviewYetkiliListe.SelectedItems.Count > 0)
            {
                Yetkili yetkili = (Yetkili)lviewYetkiliListe.SelectedItems[0].Tag;
                if (yetkili.AktifDurum == AktifDurum.Aktif)
                {
                    rbtnAktif.Checked = true;
                }
                else if (yetkili.AktifDurum == AktifDurum.Pasif)
                {
                    rbtnPasif.Checked = true;
                }

                if (yetkili.YetkiDurum == YetkiDurum.Admin)
                {
                    rbtnAdmin.Checked = true;
                }
                else if (yetkili.YetkiDurum == YetkiDurum.Yetkili)
                {
                    rbtnYetkili.Checked = true;
                }
                txtKullaniciAdi.Text = yetkili.KullaniciAdi;
                txtSifre.Text = yetkili.Sifre;
                btnSil.Enabled = true;
                btnGuncelle.Enabled = true;
                btnEkle.Enabled = false;
            }
            else
            {
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                rbtnAktif.Checked = false;
                rbtnPasif.Checked = false;
                rbtnAdmin.Checked = false;
                rbtnYetkili.Checked = false;
                btnSil.Enabled = false;
                btnGuncelle.Enabled = false;
                btnEkle.Enabled = true;
            }
        }

        private void ListViewDoldur()
        {
            lviewYetkiliListe.Items.Clear();
            List<Yetkili> yetkililer = db.YetkiliBL.GetAll();

            foreach (Yetkili yetkili in yetkililer)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = yetkili.KullaniciAdi.ToString();
                lvi.SubItems.Add(yetkili.Sifre.ToString());
                lvi.SubItems.Add(yetkili.AktifDurum.ToString());

                var dateTime = db.LoginBL.GetLoginDateById(yetkili.YetkiliId);
                lvi.SubItems.Add(dateTime.ToString());

                lvi.SubItems.Add(yetkili.YetkiDurum.ToString());

                lvi.Tag = yetkili;
                lviewYetkiliListe.Items.Add(lvi);

            }
        }

        private bool KullaniciAdiKontrol(string kullaniciAdi)
        {
            if (kullaniciAdi.Contains("@") && kullaniciAdi.EndsWith(".com") && kullaniciAdi.Length <= 20)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı içerisinde '@' olmalıdır ve '.com' ile bitmelidir.Kullanıcı adı 20 karakterden fazla olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private bool SifreKontrol(string sifre)
        {

            if (sifre.Length > 16)
            {
                MessageBox.Show("Şifre 16 karakterden fazla olamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (sifre.Count(char.IsUpper) < 2)
            {
                MessageBox.Show("Şifre en az 2 büyük harf içermelidir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (sifre.Count(char.IsLower) < 2)
            {
                MessageBox.Show("Şifre en az 2 küçük harf içermelidir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int ozelKarakter = sifre.Count(c => !char.IsLetterOrDigit(c));
            if (ozelKarakter < 2)
            {
                MessageBox.Show("Şifre en az 2 özel karakter içermelidir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int digitCount = sifre.Count(char.IsDigit);
            if (digitCount < 2)
            {
                MessageBox.Show("Şifre en az 2 adet sayı içermelidir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


    }
}
