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
    public partial class frmMusteriListe : Form
    {

        public frmMusteriListe()
        {
            InitializeComponent();
        }

        private void btnAnasayfaDon_Click(object sender, EventArgs e)
        {

        }

        private void frmMusteriListe_Load(object sender, EventArgs e)
        {
            models.AracKiralamaContext db = new models.AracKiralamaContext();

            var liste = db.Musteri.Select(x=> new { 

                x.tc,
                x.ad,
                x.soyad,
                x.telefon,
                x.adres,
                x.email,
                x.ehliyetSeriNo,
                x.ehliyetAlisTarihi           
            }).ToList();

            dataGridView1.DataSource = liste;

        } 
    }
}
