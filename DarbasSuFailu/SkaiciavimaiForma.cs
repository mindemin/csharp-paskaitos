using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarbasSuFailu
{
    public partial class SkaiciavimaiForma : Form
    {
        public SkaiciavimaiForma(List<Darbuotojas> Darbuotojai)
        {
            InitializeComponent();
            textBox1.Text = Vidurkis(Darbuotojai).ToString(); // issikvieciam metoda vidurkis
            textBox2.Text = DarbuotojuSkaicius(Darbuotojai).ToString();
        }

        public double Vidurkis (List<Darbuotojas> darbuotojai) // skaiciavimo metodas
        {
            // return 0; // be skaiciavimu
            double suma = 0;
            foreach (var darb in darbuotojai)
            {
                suma += darb.Alga;
            }
            return suma / darbuotojai.Count;
        }

        public double DarbuotojuSkaicius (List<Darbuotojas> darbuotojai) // skaiciavimo metodas
        {
            // return 0; // be skaiciavimu
           
            return darbuotojai.Count;
        }

    }
}
