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
            Monster Charmender = new Monster("Charmender", 56, 10,15);

            Pikachu.attack(Charmender);
            Charmender.attack(Pikachu);
            Pikachu.heal();
            Charmender.heal(Pikachu);
            Pikachu.attack(Charmender);
            Pikachu.attack(Charmender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monster Pikachu = new Monster("Pikachu", 10, 50, 20);

            Pikachu.describe(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Monster Charmender = new Monster("Charmender", 56, 10, 15);

            Charmender.describe(textBox2);
        }

        
    }
}
