using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_1_pasibandymai_su_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tai ko spaudei jei parasyta NESPAUST?"); //mbox tab
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tekstas = textBox1.Text; // paimti teksta is teksboxo
            label1Pakeisi.Text = tekstas; // tekstas nueina i labeli
            textBox1.Text = ""; // nunulinamas tekstboksas
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pirmas = Convert.ToInt32(textBox2.Text);
            var antras = Convert.ToInt32(textBox3.Text);
            var suma = pirmas + antras;
            label1.Text = "Suma: " + suma;
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var forma = new KitaForma();
            forma.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var vardas = textBoxVardas.Text;
            var amzius = Convert.ToInt32(textBoxAmzius.Text);
            var forma = new DuomenysForma(vardas,amzius);
            forma.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var forma = new IvestiDuomenisForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult==DialogResult.OK)
                {
                    textBoxVardasGauti.Text = forma.Vardas;
                    textBoxAmziusGauti.Text = forma.Amzius.ToString();
                }
            }
        }
    }
    
}
