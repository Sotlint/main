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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        int k;

        private void Form5_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 4);
            if(i == 1)
            {
                generator.gen_w();
                if (generator.weapon == 11) //мечи
                {
                    label1.Text = "меч +1 - урон от одноручных мечей зависит в равной степени от ловкости и силы ";
                }
                if (generator.weapon == 12)
                {
                    label1.Text = "меч +2 - урон от одноручных мечей зависит в равной степени от ловкости и силы ";
                }
                if (generator.weapon == 13)
                {
                    label1.Text = "меч +3 - урон от одноручных мечей зависит в равной степени от ловкости и силы ";
                }

                if (generator.weapon == 21) //кинжалы
                {
                    label1.Text = "кинжал +1 - урон кинжалов зависит от ловкости, повышет шанс нанести критический урон";
                }
                if (generator.weapon == 22)
                {
                    label1.Text = "кинжал +2 - урон кинжалов зависит от ловкости, повышет шанс нанести критический урон";
                }
                if (generator.weapon == 23)
                {
                    label1.Text = "кинжал +3 - урон кинжалов зависит от ловкости, повышет шанс нанести критический урон";
                }

                if (generator.weapon == 31) //копье
                {
                    label1.Text = "копье +1 - урон зависит в большой степени от силы чемот ловкости, немного повышает шанс нанести критический урон";
                }
                if (generator.weapon == 32)
                {
                    label1.Text = "копье +2 - урон зависит в большой степени от силы чемот ловкости, немного повышает шанс нанести критический урон";
                }
                if (generator.weapon == 33)
                {
                    label1.Text = "копье +3 - урон зависит в большой степени от силы чемот ловкости, немного повышает шанс нанести критический урон";
                }

                if (generator.weapon == 41) //посохи
                {
                    label1.Text = "магический посох +1 - добавляют очки магии,открывает доступ к заклинаниям. Физический урон зависит от силы";
                }
                if (generator.weapon == 42)
                {
                    label1.Text = "магический посох +2 - добавляют очки магии,открывает доступ к заклинаниям. Физический урон зависит от силы";
                }
                if (generator.weapon == 43)
                {
                    label1.Text = "магический посох +3 - добавляют очки магии,открывает доступ к заклинаниям. Физический урон зависит от силы";
                }
            }  
    
            if (i == 2) //кольца
            {
                generator.gen_ring();
                if (generator.ring == 11) //кольца на силу
                {
                    label1.Text = "кольцо +1 - увеличивает силу";
                }
                if (generator.ring == 12)
                {
                    label1.Text = "кольцо +2 - увеличивает силу";
                }
                if (generator.ring == 13)
                {
                    label1.Text = "кольцо +3 - увеличивает силу";
                }

                if (generator.ring == 21) //кольца на ловкость
                {
                    label1.Text = "кольцо +1 - увеличивает ловкость";
                }
                if (generator.ring == 22)
                {
                    label1.Text = "кольцо +2 - увеличивает ловкость";
                }
                if (generator.ring == 23)
                {
                    label1.Text = "кольцо +3 - увеличивает ловкость";
                }

                if (generator.ring == 31) //кольца на телосложения
                {
                    label1.Text = "кольцо +1 - увеличивает телосложение";
                }
                if (generator.ring == 32)
                {
                    label1.Text = "кольцо +2 - увеличивает телосложение";
                }
                if (generator.ring == 33)
                {
                    label1.Text = "кольцо +3 - увеличивает телосложение";
                }

                if (generator.ring == 41) //кольца на интеллект
                {
                    label1.Text = "кольцо +1 - увеличивает интеллект";
                }
                if (generator.ring == 42)
                {
                    label1.Text = "кольцо +2 - увеличивает интеллект";
                }
                if (generator.ring == 43)
                {
                    label1.Text = "кольцо +3 - увеличивает интеллект";
                }

                if (generator.ring == 51) //кольца на хп
                {
                    label1.Text = "кольцо +1 - увеличивает хп";
                }
                if (generator.ring == 52)
                {
                    label1.Text = "кольцо +2 - увеличивает хп";
                }
                if (generator.ring == 53)
                {
                    label1.Text = "кольцо +3 - увеличивает хп";
                }

            }

            if (i == 3)
            {
                generator.gen_armor();
                if (generator.armor == 11) //легкая
                {
                    label1.Text = "Роба +1 - Слабо защищает от урона, увеличивает шанс уворота";
                }
                if (generator.armor == 12)
                {
                    label1.Text = "Роба +2 - Слабо защищает от урона, увеличивает шанс уворота";
                }
                if (generator.armor == 13)
                {
                    label1.Text = "Роба +3 - Слабо защищает от урона, увеличивает шанс уворота";
                }

                if (generator.armor == 21) //кожанная
                {
                    label1.Text = "Кожанная броня +1 - Средняя защита. Увеличивает шанс уворота и блока";
                }
                if (generator.armor == 22)
                {
                    label1.Text = "Кожанная броня +2 - Средняя защита. Увеличивает шанс уворота и блока";
                }
                if (generator.armor == 23)
                {
                    label1.Text = "Кожанная броня +3 - Средняя защита. Увеличивает шанс уворота и блока";
                }

                if (generator.armor == 31) //латы
                {
                    label1.Text = "Латы +1 - Хорошая защита. Повышает шанс блока.";
                }
                if (generator.armor == 32)
                {
                    label1.Text = "Латы +2 - Хорошая защита. Повышает шанс блока.";
                }
                if (generator.armor == 33)
                {
                    label1.Text = "Латы +3 - Хорошая защита. Повышает шанс блока.";
                }
            }

            k = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(k == 1)
            {
                hero.char_har();
            }
            if (k == 2)
            {
                Form6 newForm = new Form6();
                newForm.Show();
                
            }
            if (k == 3)
            {
                hero.char_har();
            }
            
            Close();
        }
    }
}
