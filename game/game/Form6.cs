using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hero.char_har_ring_1();
            hero.char_har();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hero.char_har_ring_2();
            hero.char_har();
            Close();
        }
    }
}
