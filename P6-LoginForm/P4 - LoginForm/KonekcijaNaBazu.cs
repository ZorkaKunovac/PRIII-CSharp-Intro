using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4___LoginForm
{
    class KonekcijaNaBazu: DbContext
    {
        public KonekcijaNaBazu() : base("PutanjaDoBaze")
        {

        }
        public DbSet<Studenti> Studenti { get; set; }
    }
    [Table("Studenti")]
     class Studenti
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
    }
}
