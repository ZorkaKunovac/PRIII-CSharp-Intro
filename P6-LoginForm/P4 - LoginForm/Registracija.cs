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
    public partial class Registracija : Form
    {
        private Korisnik korisnik;
        public bool Edit { get; set; }
        public Registracija()
        {
            InitializeComponent();
            korisnik = new Korisnik();
            UcitajSpolove();
        }
         public Registracija(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
            UcitajPodatkeOKorisniku();
             Edit = true;
        }
         private void UcitajPodatkeOKorisniku()
        {
            try
            {
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtUsername.Text = korisnik.Username;
                txtPassword.Text = korisnik.Password;
                pbSlikaKorisnika.Image = korisnik.Slika;
                cmbSpol.SelectedItem = korisnik.Spol;
                cbAdmin.Checked = korisnik.Admin;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska ---> {ex.Message}");
            }
         }
         private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                korisnik.Ime = txtIme.Text;
                korisnik.Prezime = txtPrezime.Text;
                korisnik.Username = txtUsername.Text;
                korisnik.Password = txtPassword.Text;
                korisnik.Slika = pbSlikaKorisnika.Image;
                //korisnik.Spol = cmbSpol.Text;
                korisnik.Spol = cmbSpol.SelectedItem.ToString();
                korisnik.Admin = cbAdmin.Checked;
                if (!Edit)
                {
                    korisnik.Id = DBInMemory.RegistrovaniKorisnici.Count + 1;
                    DBInMemory.RegistrovaniKorisnici.Add(korisnik);
                    MessageBox.Show("Korisnik uspjesno sacuvan!");
                }
                else MessageBox.Show("Korisnik uspjesno editovan!");

                DialogResult = DialogResult.OK;
                Close();
            }
        }
         private void txtIme_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}";
        }
        private bool ValidanUnos()
        {
            if (pbSlikaKorisnika.Image == null)
            {
                err.SetError(pbSlikaKorisnika, Validator.porObaveznoPolje);
                return false;
            }
            else err.Clear();
            return Validator.ObaveznoPolje(txtIme, err, Validator.porObaveznoPolje)
                && Validator.ObaveznoPolje(txtPrezime, err, Validator.porObaveznoPolje)
                 && Validator.ObaveznoPolje(cmbSpol, err, Validator.porObaveznoPolje);
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            try
            {
                 if (ofdUcitajSliku.ShowDialog() == DialogResult.OK)
                {
                    string PutanjaSlike = ofdUcitajSliku.FileName;
                    Image slika = Image.FromFile(PutanjaSlike);
                    pbSlikaKorisnika.Image = slika;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska --> {ex.Message}");
            }
        }
         private void pictureBox1_Click(object sender, EventArgs e)
        {
            char Prazan = new char();
            if (txtPassword.PasswordChar == Prazan)
                txtPassword.PasswordChar = '*';
            else
                txtPassword.PasswordChar = Prazan;
        }

      
        private void UcitajSpolove()
        {
            cmbSpol.DataSource = DBInMemory.Spolovi;
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
