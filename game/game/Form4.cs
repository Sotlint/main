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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
          textBox1.Text = hero.str.ToString();
          textBox2.Text = hero.dex.ToString();
          textBox3.Text = hero.wiz.ToString();
          textBox4.Text = hero.telo.ToString();
          textBox5.Text = hero.hp.ToString();
          textBox6.Text = hero.block.ToString();
          textBox7.Text = hero.dodje.ToString();
          textBox8.Text = hero.crit.ToString();
          textBox9.Text = hero.magic_point.ToString();
          textBox10.Text = hero.damage.ToString();
          textBox11.Text = hero.resist.ToString();
          textBox12.Text = hero.vinosl.ToString();
          label19.Text = hero.monet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
