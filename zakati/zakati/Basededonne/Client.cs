namespace zakati.Basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string Nom { get; set; }

        public string prenom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDeNaissance { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDeCreation { get; set; }

        public int? age { get; set; }

        public string email { get; set; }

        public double? phone1 { get; set; }

        public double? phone2 { get; set; }

        public double? NuméroDelaCarteNational { get; set; }

        public int? int_istafada { get; set; }

        public int? id_user { get; set; }
    }
}
