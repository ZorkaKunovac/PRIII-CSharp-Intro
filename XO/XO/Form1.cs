using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public int brojac { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        void Igraj(object dugme)
        {
            Button btn = dugme as Button;
            if (btn.Text == "")
            {
                if (brojac % 2 == 0)
                    btn.Text = "X";
                else
                    btn.Text = "O";
                brojac++;
            }

            if (ProvjeriPobjedu() == true)
            {
                if (btn.Text == "X")
                    MessageBox.Show("Igrac X je pobjednik!");
                else
                    MessageBox.Show("Igrac O je pobjednik!");
                this.Close();
            }
            if (ProvjeriNerjeseno() == true)
            {
                MessageBox.Show("Nerijeseno!");
                this.Close();
            }
         }
        bool ProvjeriPobjedu()
        {
            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && btn1.Text!="")
                return true;
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && btn4.Text!="")
                return true;
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && btn7.Text != "")
                return true;

            if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && btn1.Text != "")
                return true;
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && btn2.Text != "")
                return true;
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && btn3.Text != "")
                return true;

            if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && btn1.Text != "")
                return true;
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && btn3.Text != "")
                return true;
            else return false;
        }
        bool ProvjeriNerjeseno()
        {
            if (brojac == 9)
                return true;
            return false;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Igraj(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Igraj(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Igraj(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Igraj(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Igraj(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Igraj(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Igraj(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Igraj(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Igraj(sender);
        }
    }
}
