using AracKiralamaOtomasyon.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyon
{
    public partial class frmKayıtOl : Form
    {

        public frmKayıtOl()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AracKiralamaContext db = new AracKiralamaContext();

            Kullanici kullanici = new Kullanici();
            kullanici.kullaniciAdi = txtKullaniciAdi.Text;
            kullanici.sifre = txtSifre.Text;
            kullanici.ad = txtAd.Text;
            kullanici.soyad = txtSoyad.Text;
            kullanici.tc = txtTc.Text;
            kullanici.telefon = txtTelefon.Text;
            kullanici.yetki = rdbYonetici.Checked;

            db.Kullanici.Add(kullanici);
            db.SaveChanges();

            MessageBox.Show("Bilgileriniz Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
