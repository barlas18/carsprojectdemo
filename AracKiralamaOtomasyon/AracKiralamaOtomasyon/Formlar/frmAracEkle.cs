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
    public partial class frmAracEkle : Form
    {

        public frmAracEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           AracKiralamaContext db = new AracKiralamaContext();

            Arac arac = new Arac();
            arac.plaka = txtPlaka.Text;
            arac.marka = txtMarka.Text;
            arac.seri = txtSeri.Text;
            arac.model = txtModel.Text;
            arac.vites = txtVites.Text;
            arac.renk = txtRenk.Text;
            arac.km = txtKm.Text;
            arac.yakit = txtYakit.Text;
            arac.kaskoDurumu = txtKasko.Text;
            db.Arac.Add(arac);
            db.SaveChanges();

            MessageBox.Show("Bilgileriniz Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {


        }
    }
}
