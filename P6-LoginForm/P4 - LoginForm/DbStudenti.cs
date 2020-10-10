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
    public partial class DbStudenti : Form
    {
        KonekcijaNaBazu konekcijaNaBazu = new KonekcijaNaBazu();
        public DbStudenti()
        {
            InitializeComponent();
        }

        private void DbStudenti_Load(object sender, EventArgs e)
        {
            UcitajSveStudente();
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            try
            {
                Studenti novi = new Studenti() { ImePrezime = txtImePrezime.Text };
                konekcijaNaBazu.Studenti.Add(novi);
                konekcijaNaBazu.SaveChanges();
                UcitajSveStudente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }
        private void UcitajSveStudente()
        {
            try
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = konekcijaNaBazu.Studenti.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }
    }
}
