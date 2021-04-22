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
    public partial class frmKurumsalListe : Form
    {


        public frmKurumsalListe()
        {
            InitializeComponent();
        }

        private void btnAnasayfaDon_Click(object sender, EventArgs e)
        {

        }

        private void frmKurumsalListe_Load(object sender, EventArgs e)
        {
            models.AracKiralamaContext db = new models.AracKiralamaContext();

            var liste = db.Kurumsal.Select(x => new {

                x.kurumİsmi,
                x.kurumAdres,
                x.kurumTelefon,
                x.kurumEmail,
                x.vergiNo,
                x.muhattap,
                x.muhattapTelefon,
            }).ToList();

            dataGridView1.DataSource = liste;
        }
    }
}
