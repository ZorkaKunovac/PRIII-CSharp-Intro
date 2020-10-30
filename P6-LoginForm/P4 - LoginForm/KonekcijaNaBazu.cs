using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4___LoginForm
{
    public class KonekcijaNaBazu: DbContext
    {
        public KonekcijaNaBazu() : base("PutanjaDoBaze")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Studenti> Studenti { get; set; }
        public DbSet <Korisnik> Korisnici { get; set; }
        public DbSet <Spolovi> Spolovi { get; set; }
    }
    [Table("Studenti")]
    public class Studenti
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
    }
}
