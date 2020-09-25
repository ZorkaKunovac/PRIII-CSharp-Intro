using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Dogadjaj : Form
    {
        delegate void Notifikacija(string poruka);
        event Notifikacija SMSNotifikacija;

        delegate void NotifikacijaNadleznih(string broj, string poruka);
        event NotifikacijaNadleznih ZabranjenUnos;

     
        public Dogadjaj()
        {
            InitializeComponent();
            ZabranjenUnos += PosaljiNotifikacijuNadleznim;
        }
        void PosaljiNotifikacijuNadleznim(string broj, string poruka)
        {
            MessageBox.Show($"Nadlezni {broj}: {poruka}");
        }
        private void btnSMS_Click(object sender, EventArgs e)
        {
            SMSNotifikacija?.Invoke(txtPoruka.Text);
        }
        void BHTelecom(string poruka)
        {
            MessageBox.Show($"BHTelecom ---> {poruka}");
        }
        void HTEronet(string poruka)
        {
            MessageBox.Show($"HTEronet ---> {poruka}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chTelecom_CheckedChanged(object sender, EventArgs e)
        {
            if (chTelecom.Checked)
                SMSNotifikacija += BHTelecom;
            else
                SMSNotifikacija -= BHTelecom;
         }

        private void chEronet_CheckedChanged(object sender, EventArgs e)
        {
            if (chEronet.Checked)
                SMSNotifikacija += HTEronet;
            else
                SMSNotifikacija -= HTEronet;
        }

        private void txtPoruka_TextChanged(object sender, EventArgs e)
        {
            if (txtPoruka.Text.Contains("ubiti"))
                ZabranjenUnos("061622000", $"Zabranjeni unos -->{txtPoruka.Text}");
        }
    }
}
