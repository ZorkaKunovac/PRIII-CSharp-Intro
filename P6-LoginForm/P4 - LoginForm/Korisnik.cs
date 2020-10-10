using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4___LoginForm
{
   public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Image Slika { get; set; }
        public string Spol { get; set; }
        public bool Admin { get; set; }
        public List<PolozeniPredmeti> Polozeni { get; set; } = new List<PolozeniPredmeti>();

        public override string ToString()
        {
            return $"{Ime} {Prezime} ({Username})";
        }

    }
}
