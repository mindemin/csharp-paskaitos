using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarbasSuFailu
{
    public partial class Form1 : Form
    {
        // saraso importui suskurimas
        public List<Darbuotojas> Darbuotojai { get; private set; } = new List<Darbuotojas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiFailaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new OpenFileDialog();
            forma.Filter = "csv failas (*.csv)|*.csv";

            if (forma.ShowDialog()==DialogResult.OK)
            {
                // MessageBox.Show(forma.FileName); 
                using (StreamReader sr = new StreamReader(forma.FileName))
                {
                    

                    string eilute;
                    int indeksas = 0;
              
                    // Read and display lines from the file until the end of 
                    // the file is reached.

                    while ((eilute = sr.ReadLine()) != null)
                    {
                        // MessageBox.Show(eilute); 
                        if (indeksas == 0) // nuimame pavadinimo eilute
                        {
                           indeksas++;
                           continue;
                        }                                              
                        var isskaidyta = eilute.Split(';'); // string masyvas, priskiriam kintamuosius
                        var vardas = isskaidyta[0];
                        var pavarde = isskaidyta[1];
                        var amzius = Convert.ToInt32(isskaidyta[2]);
                        var pareigos = isskaidyta[3];
                        var alga = Convert.ToDouble(isskaidyta[4]);

                        // ikeliame i sarasa duomenis
                        var darbuotojas = new Darbuotojas(vardas, pavarde, amzius, pareigos, alga);
                        Darbuotojai.Add(darbuotojas);

                    }

                    dataGridView1.DataSource = Darbuotojai; // sarasa isveda i grid meniu
                }

            }
        }

        private void skaiciuotiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new SkaiciavimaiForma(Darbuotojai);
            forma.ShowDialog();

        }
    }
}
