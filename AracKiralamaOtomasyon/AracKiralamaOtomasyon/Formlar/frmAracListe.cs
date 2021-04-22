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
    public partial class frmAracListe : Form
    {


        public frmAracListe()
        {
            InitializeComponent();
        }

        private void frmAracListe_Load(object sender, EventArgs e)
        {
            AracKiralamaContext db = new AracKiralamaContext();

            var liste = db.Arac.Select(x => new {

                x.plaka,
                x.marka,
                x.seri,
                x.model,
                x.vites,
                x.renk,
                x.km,
                x.yakit,
                x.kaskoDurumu
            }).ToList();

            dataGridView1.DataSource = liste;

        }

        private void btnAnasayfaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
