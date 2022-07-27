namespace zakati.Basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("istifada")]
    public partial class istifada
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? Somme { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDeCreation { get; set; }

        public int? Countour { get; set; }

        public int? id_user { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
