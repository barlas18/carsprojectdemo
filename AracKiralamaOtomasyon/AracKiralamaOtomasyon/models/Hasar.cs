namespace AracKiralamaOtomasyon.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hasar")]
    public partial class Hasar
    {
        public int hasarID { get; set; }
        public string Tc { get; internal set; }
        public string ad { get; internal set; }
        public string soyad { get; internal set; }
        public string telefon { get; internal set; }

        public string plaka { get; internal set; }
        public string marka { get; internal set; }
        public string seri { get; internal set; }
        public string model { get; internal set; }
        public decimal masraf { get; internal set; }

        public string aciklama { get; set; }





    }
}
