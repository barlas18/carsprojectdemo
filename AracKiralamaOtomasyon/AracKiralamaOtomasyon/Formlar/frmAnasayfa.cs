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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriEkle musteriKayit = new frmMusteriEkle();
            musteriKayit.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKurumsalEkle kurumsalKayit = new frmKurumsalEkle();
            kurumsalKayit.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAracEkle aracKayit = new frmAracEkle();
            aracKayit.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriListe musteriListe = new frmMusteriListe();
            musteriListe.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKurumsalListe kurumListe = new frmKurumsalListe();
            kurumListe.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAracListe aracListe = new frmAracListe();
            aracListe.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmHasarKayit hasarKayit = new frmHasarKayit();
            hasarKayit.Show();
            this.Hide();
        }

        private void btnPersonelKayit_Click(object sender, EventArgs e)
        {
            frmKayıtOl frmKayıtOl = new frmKayıtOl();
            frmKayıtOl.Show();
            this.Hide();
        }
    }
}
