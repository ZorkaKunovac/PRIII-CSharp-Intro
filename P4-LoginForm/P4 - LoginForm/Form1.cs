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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool pronadjen = false;
            if (ValidanUnos())
            {
                foreach (var korisnik in DBInMemory.RegistrovaniKorisnici)
                {
                    if (username == korisnik.Username && password == korisnik.Password)
                    {
                        MessageBox.Show($"Dobro dosli {korisnik}");
                        pronadjen = true;
                    }
                }
                if (pronadjen == false)
                    MessageBox.Show($"Uneseni podaci nisu validni");
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ObaveznoPolje(txtUsername, errLogin, Validator.porObaveznoPolje)
                 && Validator.ObaveznoPolje(txtPassword, errLogin, Validator.porObaveznoPolje);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
