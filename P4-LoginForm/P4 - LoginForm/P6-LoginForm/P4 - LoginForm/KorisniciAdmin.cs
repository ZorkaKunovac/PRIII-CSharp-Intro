using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4___LoginForm
{
    public partial class KorisniciAdmin : Form
    {
        public KorisniciAdmin()
        {
            InitializeComponent();
            dvgKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            dvgKorisnici.DataSource = DBInMemory.RegistrovaniKorisnici;
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
           if(registracija.ShowDialog()== DialogResult.OK)
            {
                dvgKorisnici.DataSource = null;
                dvgKorisnici.DataSource = DBInMemory.RegistrovaniKorisnici;
            }
        }

        private void dvgKorisnici_MouseClick(object sender, MouseEventArgs e)
        {
            Korisnik korisnik = dvgKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            if(korisnik!=null)
            {
                Registracija registracija = new Registracija(korisnik);
                registracija.ShowDialog();
                dvgKorisnici.DataSource = null;
                dvgKorisnici.DataSource = DBInMemory.RegistrovaniKorisnici;
            }
        }
    }
}
