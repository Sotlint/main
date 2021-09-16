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
    public partial class Form10 : Form
    {
        public static int cost_1;
        public static int cost_2;
        public static int cost_3;
        public Form10()
        {

        


            InitializeComponent();
         
            generator.gen_w();
            generator.gen_armor();
            generator.gen_ring();

            label2.Text = hero.monet.ToString();

            if (generator.weapon == 11) //мечи
            {
                label3.Text = "меч +1 ";
                cost_1 = 5;
            }
            if (generator.weapon == 12)
            {
                label3.Text = "меч +2 ";
                cost_1 = 10;
            }
            if (generator.weapon == 13)
            {
                cost_1 = 15;
                label3.Text = "меч +3 ";
            }
            if (generator.weapon == 21) //кинжалы
            {
                label3.Text = "кинжал +1";
                cost_1 = 5;
            }
            if (generator.weapon == 22)
            {
                label3.Text = "кинжал +2";
                cost_1 = 10;
            }
            if (generator.weapon == 23)
            {
                label3.Text = "кинжал +3";
                cost_1 = 15;
            }
            if (generator.weapon == 31) //копье
            {
                label3.Text = "копье +1";
                cost_1 = 5;
            }
            if (generator.weapon == 32)
            {
                label3.Text = "копье +2";
                cost_1 = 10;
            }
            if (generator.weapon == 33)
            {
                label3.Text = "копье +3";
                cost_1 = 15;
            }
            if (generator.weapon == 41) //посохи
            {
                label3.Text = "магический посох +1";
                cost_1 = 5;
            }
            if (generator.weapon == 42)
            {
                label3.Text = "магический посох +2";
                cost_1 = 10;
            }
            if (generator.weapon == 43)
            {
                label3.Text = "магический посох +3";
                cost_1 = 15;
            }



            if (generator.armor == 11) //легкая
            {
                cost_2 = 5;
                label4.Text = "Роба +1";

            }
            if (generator.armor == 12)
            {
                label4.Text = "Роба +2";
                cost_2 = 10;
            }
            if (generator.armor == 13)
            {
                label4.Text = "Роба +3";
                cost_2 = 15;
            }
            if (generator.armor == 21) //кожанная
            {
                label4.Text = "Кожанная броня +1";
                cost_2 = 5;
            }
            if (generator.armor == 22)
            {
                label4.Text = "Кожанная броня +2";
                cost_2 = 10;
            }
            if (generator.armor == 23)
            {
                label4.Text = "Кожанная броня +3";
                cost_2 = 15;
            }
            if (generator.armor == 31) //латы
            {
                label4.Text = "Латы +1";
                cost_2 = 5;
            }
            if (generator.armor == 32)
            {
                label4.Text = "Латы +2";
                cost_2 = 10;
            }
            if (generator.armor == 33)
            {
                label4.Text = "Латы +3";
                cost_2 = 15;
            }





            if (generator.ring == 11) //кольца на силу
            {
                label5.Text = "кольцо силы +1";
                cost_3 = 5;
            }
            if (generator.ring == 12)
            {
                label5.Text = "кольцо силы +2";
                cost_3 = 10;
            }
            if (generator.ring == 13)
            {
                label5.Text = "кольцо силы +3";
                cost_3 = 15;
            }
            if (generator.ring == 21) //кольца на ловкость
            {
                label5.Text = "кольцо ловкости +1";
                cost_3 = 5;
            }
            if (generator.ring == 22)
            {
                label5.Text = "кольцо ловкости +2";
                cost_3 = 10;
            }
            if (generator.ring == 23)
            {
                label5.Text = "кольцо ловкости +3";
                cost_3 = 15;
            }
            if (generator.ring == 31) //кольца на телосложения
            {
                label5.Text = "кольцо +1  телосложения";
                cost_3 = 5;
            }
            if (generator.ring == 32)
            {
                label5.Text = "кольцо +2  телосложения";
                cost_3 = 10;
            }
            if (generator.ring == 33)
            {
                label5.Text = "кольцо телосложения +3";
                cost_3 = 15;
            }
            if (generator.ring == 41) //кольца на интеллект
            {
                label5.Text = "кольцо интеллекта +1 ";
                cost_3 = 5;
            }
            if (generator.ring == 42)
            {
                label5.Text = "кольцо интеллекта +2 ";
                cost_3 = 10;
            }
            if (generator.ring == 43)
            {
                label5.Text = "кольцо интеллекта +3";
                cost_3 = 15;
            }
            if (generator.ring == 51) //кольца на хп
            {
                label5.Text = "кольцо здоровья +1";
                cost_3 = 5;
            }
            if (generator.ring == 52)
            {
                label5.Text = "кольцо здоровья +2";
                cost_3 = 10;
            }
            if (generator.ring == 53)
            {
                label5.Text = "кольцо здоровья +3 ";
                cost_3 = 15;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }





















        private void button1_Click(object sender, EventArgs e)
        {
            if(hero.monet>=cost_1)
            {
                hero.monet = hero.monet - cost_1;
                label2.Text = hero.monet.ToString();
                hero.char_har();
                label3.Hide();
                button1.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hero.monet >= cost_2)
            {
                hero.monet = hero.monet - cost_2;
                label2.Text = hero.monet.ToString();
                hero.char_har();
                label4.Hide();
                button2.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hero.monet >= cost_3)
            {
                hero.monet = hero.monet - cost_3;
                label2.Text = hero.monet.ToString();
                label5.Hide();
                button3.Hide();
                Form6 newForm = new Form6();
                newForm.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }











        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Text = cost_1.ToString();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "Купить";
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Text = cost_2.ToString();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "Купить";
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Text = cost_3.ToString();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Text = "Купить";

        }
    }
}
