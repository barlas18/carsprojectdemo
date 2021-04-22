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
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKayıtOl kayıtol = new frmKayıtOl();
            kayıtol.Show();
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           AracKiralamaContext db = new AracKiralamaContext();
         
            Kullanici kullanici = db.Kullanici.Where(x => x.kullaniciAdi == txtKullaniciAdi.Text && x.sifre == txtSifre.Text).SingleOrDefault();

            if (kullanici==null)
            {
                MessageBox.Show("Kayıt bulunamadı ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kullanici!=null && kullanici.yetki==true)
            {
                Formlar.frmAnasayfa anasayfadon = new Formlar.frmAnasayfa();
                anasayfadon.Show();
                this.Hide();
            }
            else if (kullanici != null && kullanici.yetki == false)
            {
                Formlar.frmAracListe deneme = new Formlar.frmAracListe();
                deneme.Show();
                this.Hide();
            }
            
           



        }
    }
}
