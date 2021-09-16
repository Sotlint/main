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
    public partial class Form2 : Form
    {
        public int k = 0;
        

        public int point = 10;
        public Form2()
        {
            
            InitializeComponent();
           
     

            textBox4.Text = hero.str.ToString();
            textBox3.Text = hero.dex.ToString();
            textBox2.Text = hero.wiz.ToString();
            textBox1.Text = hero.telo.ToString();
            textBox5.Text = point.ToString();
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (point != 0)
            {
                hero.str = hero.str + 1;
                point = point - 1;
                textBox4.Text = hero.str.ToString();
                textBox5.Text = point.ToString();

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (point != 0)
            {
                hero.dex = hero.dex + 1;
                point = point - 1;
                textBox3.Text = hero.dex.ToString();
                textBox5.Text = point.ToString();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (point != 0)
            {
                hero.wiz = hero.wiz + 1;
                point = point - 1;
                textBox2.Text = hero.wiz.ToString();
                textBox5.Text = point.ToString();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (point != 0)
            {
                hero.telo = hero.telo + 1;
                point = point - 1;
                textBox1.Text = hero.telo.ToString();
                textBox5.Text = point.ToString();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

                hero.name = textBox6.Text;
                hero.char_har();
                
                
                Form3 newForm = new Form3();
                newForm.Show();

                Close();

            

        }
    }
}
