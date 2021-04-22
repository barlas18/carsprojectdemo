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

namespace AracKiralamaOtomasyon.Formlar
{
    public partial class frmKurumsalEkle : Form
    {


        public frmKurumsalEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           AracKiralamaContext db = new AracKiralamaContext();

            Kurumsal kurumsal = new Kurumsal();

            kurumsal.kurumİsmi = txtKurumAd.Text;
            kurumsal.kurumAdres = txtKurumAdres.Text;
            kurumsal.kurumTelefon = txtKurumTelefon.Text;
            kurumsal.kurumEmail = txtKurumEmail.Text;
            kurumsal.vergiNo = txtVergiNo.Text;
            kurumsal.muhattap = txtMuhattap.Text;
            kurumsal.muhattapTelefon = txtMuhattapNo.Text;

            db.Kurumsal.Add(kurumsal);
            db.SaveChanges();

            MessageBox.Show("Bilgileriniz Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {

        }
    }
}
