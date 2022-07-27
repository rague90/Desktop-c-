using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace zakati.Basededonne
{
    public partial class zaket : DbContext
    {
        public zaket()
            : base("name=zaket")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<istifada> istifada { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<utilisateur> utilisateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<utilisateur>()
                .HasMany(e => e.istifada)
                .WithOptional(e => e.utilisateur)
                .HasForeignKey(e => e.id_user)
                .WillCascadeOnDelete();
        }
    }
}
