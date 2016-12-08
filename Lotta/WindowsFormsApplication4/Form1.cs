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
            Monster strongbonna = new Monster("strongbonna", 10, 50, 20);
            Monster charmender = new Monster("charmender", 56, 10,15);

            strongbonna.attack(charmender);
            charmender.attack(strongbonna);
            strongbonna.heal();
            strongbonna.curHp = 2442;
            charmender.heal(strongbonna);
            strongbonna.attack(charmender);
            strongbonna.attack(charmender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monster strongbonna = new Monster("strongbonna", 10, 50, 20);

            strongbonna.describe(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Monster charmender = new Monster("charmender", 56, 10, 15);

            charmender.describe(textBox2);
        }

        
    }
}
