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
        KonekcijaNaBazu konekcijaNaBazu = new KonekcijaNaBazu();
        public KorisniciAdmin()
        {
            InitializeComponent();
            dvgKorisnici.AutoGenerateColumns = false;
        }
        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                dvgKorisnici.DataSource = null;
                dvgKorisnici.DataSource = korisnici ?? konekcijaNaBazu.Korisnici.ToList();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }
        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            //  dvgKorisnici.DataSource = DBInMemory.RegistrovaniKorisnici;
            LoadData();
        }
          private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
           if(registracija.ShowDialog()== DialogResult.OK)
                LoadData();
        }

        private void dvgKorisnici_MouseClick(object sender, MouseEventArgs e)
        {
            /*Korisnik korisnik = dvgKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            if (korisnik != null)
            {
                Registracija registracija = new Registracija(korisnik);
                registracija.ShowDialog();
                LoadData();
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = textBox1.Text.ToLower();
            List<Korisnik> rezultat =
                DBInMemory.RegistrovaniKorisnici.Where(
                    korisnik => korisnik.Ime.ToLower().Contains(filter) ||
                    korisnik.Prezime.ToLower().Contains(filter)).ToList();
            LoadData(rezultat);
        }

        private void dvgKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Korisnik korisnik = dvgKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            Form form = null;
            if (korisnik != null)
            {
                if (e.ColumnIndex == 5)
                    form = new KorisniciPolozeniPredmeti(korisnik);
                else
                    form = new Registracija(korisnik);
                form.ShowDialog();
                LoadData();
            }
        }
    }
}
