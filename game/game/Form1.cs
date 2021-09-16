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
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
           
            Form2 lvlup = new Form2();
            lvlup.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
