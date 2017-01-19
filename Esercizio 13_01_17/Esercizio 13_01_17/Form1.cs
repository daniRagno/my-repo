using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_13_01_17
{
    public partial class Form1 : Form
    {
        private string[] nomi = { "Tizio", "Caio", "Sempronio" };
        private string[] cognomi = { "Rossi", "Bianchi", "Verdi" };

        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private Persona generateRandomPersona()
        {
            return new Persona(nomi[rnd.Next(0, 3)], cognomi[rnd.Next(0, 3)], rnd.Next(18, 50));
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Persona p = new Persona(nomi[0], cognomi[0], 29);
            //Studente s = new Studente("Tizio", "Caio", 17, "3F");
            Console.WriteLine(generateRandomPersona());
            Console.WriteLine(generateRandomPersona());
            Console.WriteLine(generateRandomPersona());
        }
    }
}

