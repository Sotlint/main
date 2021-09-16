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
    public partial class Form3 : Form
    {


        public static int ind = 0;


        public static void stamina_down()
        {
            if (ind == 0)
            {
                if (hero.ust >= 3)
                {

                    hero.damage = hero.damage / 2;
                    hero.block = hero.block / 2;
                    hero.crit = hero.crit / 2;
                    hero.dodje = hero.dodje / 2;
                    ind = 1;


                }
            }
        }

        public static void stamina_up()
        {
            if (ind == 1)
            {
                if (hero.ust < 3)
                {
                    hero.damage = hero.temp_damage;
                    hero.block = hero.temp_block;
                    hero.crit = hero.temp_crit;
                    hero.dodje = hero.temp_dodje;
                    ind = 0;
                }
            }
        }
        



        private static Random rnd = new Random();
        public int i;
        public Form3()
        {
           
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e) //вверх
        {
            if ((pictureBox26.Location.Y - 57) > 21)
            {
                pictureBox26.Location = new Point(pictureBox26.Location.X, pictureBox26.Location.Y - 57);

               


                i = rnd.Next(1, 6); //генерация события

                if (i == 1)
                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                    Form5 newForm = new Form5();
                    newForm.ShowDialog();
                }
                if (i == 2 || i == 3)
                {
                    hero.ust = hero.ust + 3;
                    label4.Text = hero.ust.ToString();
                    Form8 newForm = new Form8();
                    newForm.ShowDialog();
                }
                if(i==4)
                 {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                }
                if (i == 5)

                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    Form10 newForm = new Form10();
                    newForm.ShowDialog();


                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                }
                stamina_down();
            }
            


        }

     
        private void button1_Click(object sender, EventArgs e) //вниз
        {
            if ((pictureBox26.Location.Y + 57) < 286)
            {
                pictureBox26.Location = new Point(pictureBox26.Location.X, pictureBox26.Location.Y + 57);

                

                i = rnd.Next(1, 6); //генерация события

                if (i == 1)
                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                    Form5 newForm = new Form5();
                    newForm.ShowDialog();
                }
                if (i == 2 || i == 3)
                {
                    hero.ust = hero.ust + 3;
                    label4.Text = hero.ust.ToString();
                    Form8 newForm = new Form8();
                    newForm.ShowDialog();
                   
                }
                if (i == 4)
                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                }
                if (i == 5)

                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    Form10 newForm = new Form10();
                    newForm.ShowDialog();


                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                }
                stamina_down();
            }


        }

        private void button3_Click(object sender, EventArgs e) //вправо
        {
            if ((pictureBox26.Location.X + 57) < 288)
            {
                pictureBox26.Location = new Point(pictureBox26.Location.X + 57, pictureBox26.Location.Y);

                

                i = rnd.Next(1, 6); //генерация события

                if (i == 1)
                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                    Form5 newForm = new Form5();
                    newForm.ShowDialog();
                }
                if (i == 2 || i == 3)
                {
                    hero.ust = hero.ust + 3;
                    label4.Text = hero.ust.ToString();
                    Form8 newForm = new Form8();
                    newForm.ShowDialog();
                }
                if (i == 4)
                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                }
                if (i == 5)

                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    Form10 newForm = new Form10();
                    newForm.ShowDialog();


                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                }
                stamina_down();
            }


        }

        private void button4_Click(object sender, EventArgs e) //влево
        {
            if ((pictureBox26.Location.X - 57) > 12)
            {
                pictureBox26.Location = new Point(pictureBox26.Location.X - 57, pictureBox26.Location.Y);

                

                i = rnd.Next(1, 6); //генерация события

                if (i == 1)
                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                    Form5 newForm = new Form5();
                    newForm.ShowDialog();
                }
                if (i == 2 || i == 3)
                {
                    hero.ust = hero.ust + 3;
                    label4.Text = hero.ust.ToString();
                    Form8 newForm = new Form8();
                    newForm.ShowDialog();
                }
                if (i == 4)
                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                }
                if (i == 5)

                {
                    hero.ust = hero.ust + 1;
                    label4.Text = hero.ust.ToString();
                    Form10 newForm = new Form10();
                    newForm.ShowDialog();


                    hero.score = hero.score + 1;
                    label2.Text = hero.score.ToString();
                }
                stamina_down();
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }








        private void button7_Click(object sender, EventArgs e)
        {
            int k = rnd.Next(1,6);

            if (k == 1 || k == 2 || k == 3 || k == 4)
            {
                
                    hero.ust = hero.ust - 2;

                if(hero.ust<0)
                {
                    hero.ust = 0;
                }

                hero.hp = hero.hp + hero.max_hp / 3;
                if((hero.hp + hero.max_hp / 3)>hero.max_hp)
                {
                    hero.hp = hero.max_hp;
                }
                    label4.Text = hero.ust.ToString();
                    stamina_up();  
            }
            else
            {
               
                    hero.ust = hero.ust - 1;
                    if (hero.ust < 0)
                    {
                        hero.ust = 0;
                    }
                hero.hp = hero.hp + hero.max_hp / 3;
                if ((hero.hp + hero.max_hp / 3) > hero.max_hp)
                {
                    hero.hp = hero.max_hp;
                }
                label4.Text = hero.ust.ToString();
                    stamina_up();
   
                Form8 newForm = new Form8();
                newForm.ShowDialog();
            }
        }
    }
}
