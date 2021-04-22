using AracKiralamaOtomasyon.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyon.Formlar
{
    public partial class frmMusteriEkle : Form
    {

        public frmMusteriEkle()
        {
            InitializeComponent();
        }

       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AracKiralamaContext db = new AracKiralamaContext();

            Musteri musteri = new Musteri();
            musteri.tc = txtTc.Text;
            musteri.ad = txtAd.Text;
            musteri.soyad = txtSoyad.Text;
            musteri.telefon = txtTelefon.Text;
            musteri.adres = txtAdres.Text;
            musteri.email = txtEmail.Text;
            musteri.ehliyetSeriNo = txtSeriNo.Text;
            musteri.ehliyetAlisTarihi = dtimepEhliyetAlis.Value;
            db.Musteri.Add(musteri);
            db.SaveChanges();

            MessageBox.Show("Bilgileriniz Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {

        }
    }
}
