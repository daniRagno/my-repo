using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Monster Pikachu = new Monster("Pikachu", 10, 50, 20);
            Monster Charmander = new Monster("Charmander", 56, 10,15);
            Pikachu.attack(Charmander);
            Pikachu.attack(Charmander);
            Charmander.heal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monster Pikachu = new Monster("Strongbonna", 10, 50, 20);

            Pikachu.describe(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Monster Charmander = new Monster("Charmander", 56, 10, 15);

            Charmander.describe(textBox2);
        }

        
    }
}
