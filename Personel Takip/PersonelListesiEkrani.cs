using BusinessLayer.ContextBL;
using EntityLayer.Entities;
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
    public partial class PersonelListesiEkrani : Form
    {
        public PersonelListesiEkrani(int Id)
        {
            InitializeComponent();
            yetkiliId = Id;
            db = new ProjeContextBL();
        }

        int yetkiliId;
        ProjeContextBL db;
        private void PersonelListesiEkrani_Load(object sender, EventArgs e)
        {
            ListViewDoldur();
            btnGuncelle.Enabled = false;
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelKarti personelKarti = new PersonelKarti();
            personelKarti.ShowDialog();
            ListViewDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            PersonelKarti personelKarti = new PersonelKarti(personelId);
            personelKarti.ShowDialog();
            ListViewDoldur();
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            listviewPersonelListe.Items.Clear();
            List<Personel> personeller = db.PersonelBL.GetByText(txtArama.Text);
            btnGuncelle.Enabled = false;

            foreach (Personel personel in personeller)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = personel.Ad.ToString();
                lvi.SubItems.Add(personel.Soyad.ToString());

                Departman departman = db.DepartmanBL.Find(personel.DepartmanId);
                lvi.SubItems.Add(departman.DepartmanAdi);

                lvi.SubItems.Add(personel.TC.ToString());
                lvi.SubItems.Add(personel.DogumTarihi.ToString());
                lvi.SubItems.Add(personel.Cinsiyet.ToString());
                lvi.Tag = personel;

                listviewPersonelListe.Items.Add(lvi);
            }
        }

        private void ListViewDoldur()
        {
            listviewPersonelListe.Items.Clear();
            db = new ProjeContextBL();
            List<Personel> personeller = db.PersonelBL.GetAll();

            foreach (Personel personel in personeller)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = personel.Ad.ToString();
                lvi.SubItems.Add(personel.Soyad.ToString());

                Departman departman = db.DepartmanBL.Find(personel.DepartmanId);
                lvi.SubItems.Add(departman.DepartmanAdi);

                lvi.SubItems.Add(personel.TC.ToString());
                lvi.SubItems.Add(personel.DogumTarihi.ToString());
                lvi.SubItems.Add(personel.Cinsiyet.ToString());
                lvi.Tag = personel;

                listviewPersonelListe.Items.Add(lvi);
            }
        }

        int personelId;
        private void listviewPersonelListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewPersonelListe.SelectedItems.Count > 0)
            {
                Personel personel = (Personel)listviewPersonelListe.SelectedItems[0].Tag;
                personelId = personel.PersonelId;
                btnGuncelle.Enabled = true;
            }
            else
            {
                btnGuncelle.Enabled = false;
            }
        }

        private void PersonelListesiEkrani_Click(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = false;
        }
    }
}
