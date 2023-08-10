using BusinessLayer.ContextBL;
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
using System.Web;
using System.Windows.Forms;

namespace Personel_Takip
{
    public partial class PersonelKarti : Form
    {
        public PersonelKarti()
        {
            InitializeComponent();
            btnSil.Enabled = false;
            db = new ProjeContextBL();
        }
        public PersonelKarti(int Id)
        {
            InitializeComponent();
            personelId = Id;
            btnKaydet.Text = "Güncelle";
            db = new ProjeContextBL();
        }
        int personelId;
        ProjeContextBL db;

        private void PersonelKarti_Load(object sender, EventArgs e)
        {
            if (personelId > 0)
            {
                BilgileriGetir();
            }
            else
            {
                cbxDoldur();
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kullanıcıyı tamamen silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.PersonelBL.Delete(personelId);
                MessageBox.Show("Kullanıcı hesabı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAd.Text) && !string.IsNullOrWhiteSpace(txtSoyad.Text) && !string.IsNullOrWhiteSpace(txtTC.Text))
            {

                if (!AdKotrol(txtAd.Text))
                {
                    MessageBox.Show("Personel ismi özel karakter veya sayı içeremez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!AdKotrol(txtSoyad.Text))
                {
                    MessageBox.Show("Personel soyadı özel karakter veya sayı içeremez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!YasKontrol(dtpDogumTarihi.Value))
                {
                    MessageBox.Show("Personel 18 yaşından küçük olamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!MailAdiKontrol(txtMail.Text))
                {
                    return;
                }

                if (personelId <= 0)
                {
                    if (!TcKontrol(txtTC.Text))
                    {
                        return;
                    }

                    Personel personel = new Personel();
                    personel.Ad = txtAd.Text;
                    personel.Soyad = txtSoyad.Text;
                    personel.TC = txtTC.Text;
                    personel.Cinsiyet = (Cinsiyet)cbxCinsiyet.SelectedItem;
                    personel.DogumTarihi = dtpDogumTarihi.Value;
                    personel.DepartmanId = (int)cbxDepartman.SelectedValue;
                    personel.Mail = txtMail.Text;
                    personel.Telefon = txtTelefon.Text;
                    personel.Adres = txtAdres.Text;

                    db.PersonelBL.Add(personel);
                    MessageBox.Show("Personel kaydı başarıyla gerçekleştirilmiştir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {

                    Personel personel = db.PersonelBL.Find(personelId);
                    if (personel.TC != txtTC.Text)
                    {
                        if (!TcKontrol(txtTC.Text))
                        {
                            return;
                        }
                    }
                    personel.Ad = txtAd.Text;
                    personel.Soyad = txtSoyad.Text;
                    personel.TC = txtTC.Text;
                    personel.Cinsiyet = (Cinsiyet)cbxCinsiyet.SelectedItem;
                    personel.DogumTarihi = dtpDogumTarihi.Value;
                    personel.DepartmanId = (int)cbxDepartman.SelectedValue;
                    personel.Mail = txtMail.Text;
                    personel.Telefon = txtTelefon.Text;
                    personel.Adres = txtAdres.Text;

                    db.PersonelBL.Update(personel);
                    MessageBox.Show("Personel kaydı güncellendi.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Personel bilgileri boş bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BilgileriGetir()
        {
            cbxDoldur();

            Personel personel = db.PersonelBL.Find(personelId);
            txtAd.Text = personel.Ad;
            txtSoyad.Text = personel.Soyad;
            txtTC.Text = personel.TC;
            cbxCinsiyet.SelectedItem = personel.Cinsiyet;
            dtpDogumTarihi.Value = personel.DogumTarihi;
            cbxDepartman.SelectedValue = personel.DepartmanId;
            txtMail.Text = personel.Mail;
            txtTelefon.Text = personel.Telefon;
            txtAdres.Text = personel.Adres;
        }

        private void cbxDoldur()
        {
            List<Departman> departmanlar = db.DepartmanBL.GetAll();
            cbxCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));

            cbxDepartman.DisplayMember = "DepartmanAdi";
            cbxDepartman.ValueMember = "DepartmanId";
            cbxDepartman.DataSource = departmanlar;

        }
        private bool AdKotrol(string text)
        {
            bool ozelKarakter = text.Any(c => !char.IsLetterOrDigit(c));
            bool sayi = text.Any(char.IsDigit);

            if (!ozelKarakter && !sayi && text.Length <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool TcKontrol(string TC)
        {
            if (TC.Length != 11)
            {
                MessageBox.Show("TC No 11 karakterden oluşmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!long.TryParse(TC, out _))
            {
                MessageBox.Show("Girmiş olduğunuz TC numarası sadece rakamlardan oluşmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!db.PersonelBL.CheckTC(TC))
            {
                MessageBox.Show("Girmiş olduğunuz TC daha önce kaydedilmiştir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;



        }
        private bool YasKontrol(DateTime dogumTarihi)
        {
            DateTime minYas = DateTime.Now.AddYears(-18);

            return dogumTarihi <= minYas;
        }
        private bool MailAdiKontrol(string mail)
        {
            if (mail.Contains("@") && mail.EndsWith(".com") && mail.Length <= 20 && mail.Length > 5)
            {
                return true;
            }
            else if (string.IsNullOrEmpty(mail))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı içerisinde '@' olmalıdır ve '.com' ile bitmelidir.Kullanıcı adı 5 den fazla 20 den az karaktere sahip olmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
