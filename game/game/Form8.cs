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
    public partial class Form8 : Form
    {

        Random rnd = new Random();

        public int win = 0;
       public int lose = 0;
        public Form8()
        {
      
                InitializeComponent();
            label12.Text = hero.name;
            monstr.gen_monster();
            monstr.monstr_har();
            textBox1.Text = hero.hp.ToString();
            textBox2.Text = monstr.hp.ToString();
            textBox3.Text = hero.vinosl.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ch;
            float temp_block;

            if (hero.vinosl >= hero.trata_vin)
            {
                ch = rnd.Next(1, 101);
                if (monstr.dodje >= ch)
                {
                    monstr.hp = monstr.hp - 0;
                    label7.Text = "Герой провел атаку но монстр уклонился";
                    hero.vinosl = hero.vinosl - hero.trata_vin;
                    textBox3.Text = hero.vinosl.ToString();
                }
                else
                {
                    ch = rnd.Next(1, 101);

                    if (monstr.block >= ch)
                    {
                        temp_block = monstr.block;
                        monstr.block = 95;
                        monstr.hp = monstr.hp - hero.damage * (1 - (monstr.resist / 100));
                        monstr.block = temp_block;
                        hero.vinosl = hero.vinosl - hero.trata_vin;
                        label7.Text = "Герой провел атаку но монстр блокировал";
                        textBox3.Text = hero.vinosl.ToString();
                    }

                    else
                    {
                        ch = rnd.Next(1, 101);
                        if (hero.crit >= ch)
                        {
                            monstr.hp = monstr.hp - hero.damage * 2 ;
                            hero.vinosl = hero.vinosl - hero.trata_vin;
                            label7.Text = "Герой нанес критический урон";
                            textBox3.Text = hero.vinosl.ToString();
                        }
                        else
                        {
                            monstr.hp = (monstr.hp - hero.damage * (1 - (monstr.resist / 100)));
                            hero.vinosl = hero.vinosl - hero.trata_vin;
                            label7.Text = "Герой нанес обычный урон";
                            textBox3.Text = hero.vinosl.ToString();
                        }
                    }
                }

                if (monstr.hp == 0 || monstr.hp < 0)
                {
                    hero.exp = hero.exp + 5;
                    label11.Text = "Победа";
                    label11.Visible = true;
                    button5.Text = "Продолжить";
                    button5.Visible = true;

                }
                textBox2.Text = monstr.hp.ToString();
            }
            else
            {
                label7.Text = "Герой вымотан,пропуск хода";
            }





            monstr.AI_monster();
            label10.Text = monstr.log;
            textBox1.Text = hero.hp.ToString();

            if (hero.hp == 0 || hero.hp < 0)
            {
                label11.Text = "Поражение";
                label11.Visible = true;
                button5.Text = "Продолжить";
                button5.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float temp_1;
            float temp_2;
          

            temp_1 = hero.block;
            temp_2 = hero.resist;
            
            label7.Text = "Герой защищается";
            hero.block = hero.block + 10;
            hero.resist = hero.resist * 2;

            if (hero.temp_vin <= (hero.temp_vin / 5)+hero.vinosl)
            {
                hero.vinosl = hero.temp_vin;
                textBox3.Text = hero.vinosl.ToString();

            }
            else
            {
                hero.vinosl = hero.vinosl + (hero.temp_vin / 5);
                textBox3.Text = hero.vinosl.ToString();

            }
            

            monstr.AI_monster();
            label10.Text = monstr.log;
            textBox1.Text = hero.hp.ToString();
            if (hero.hp == 0 || hero.hp < 0)
            {
                label11.Text = "Поражение";
                label11.Visible = true;
                button5.Text = "Продолжить";
                button5.Visible = true;
            }
            hero.block = temp_1;
            hero.resist = temp_2;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float temp_1;
            temp_1 = hero.block;
            label7.Text = "Герой востанавливается";

            if (hero.temp_vin <= (hero.temp_vin / 3) + hero.vinosl)
            {
                hero.block = hero.block - temp_1 / 3;
                hero.vinosl = hero.temp_vin;
                textBox3.Text = hero.vinosl.ToString();

            }
            else
            {
                hero.block = hero.block - temp_1 / 3;
                hero.vinosl = hero.vinosl + (hero.temp_vin / 3);
                textBox3.Text = hero.vinosl.ToString();

            }



            monstr.AI_monster();
            textBox1.Text = hero.hp.ToString();

            hero.block = temp_1;
            if (hero.hp == 0 || hero.hp < 0)
            {
                label11.Text = "Поражение";
                label11.Visible = true;
                button5.Text = "Продолжить";
                button5.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (monstr.hp == 0 || monstr.hp < 0)
            {
                hero.monet = hero.monet + 5;

                if(hero.exp>=hero.lvlup_exp)
                {
                    hero.lvlup_exp = hero.lvlup_exp + 5;
                    hero.exp = 0;
                    Form9 lvlup = new Form9();
                    lvlup.ShowDialog();

                }
                Form5 newForm = new Form5();
                hero.vinosl = hero.temp_vin;
                newForm.ShowDialog();
                Close();
            }
            if (hero.hp == 0 || hero.hp < 0)
            {
                label11.Text = "Поражение";
                label11.Visible = true;
                button5.Text = "Продолжить";
                button5.Visible = true;
                Application.Exit();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
