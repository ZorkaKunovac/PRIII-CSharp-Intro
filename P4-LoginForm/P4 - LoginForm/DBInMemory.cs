using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4___LoginForm
{
    class DBInMemory
    {
        public static List<Korisnik> RegistrovaniKorisnici = new List<Korisnik>();

        static DBInMemory()
        {
            RegistrovaniKorisnici = new List<Korisnik>();
            DodajPodrazumijevaneKorisnike();
        }

        private static void DodajPodrazumijevaneKorisnike()
        {
            Korisnik k1 = new Korisnik() { Id = 1, Ime = "Denis", Prezime = "Music", Username = "denis", Password = "denis" };
            Korisnik k2 = new Korisnik() { Id = 2, Ime = "Jasmin", Prezime = "Azemovic", Username = "jasmin", Password = "jasmin" };
            RegistrovaniKorisnici.Add(k1);
            RegistrovaniKorisnici.Add(k2);
        }
    }
}
