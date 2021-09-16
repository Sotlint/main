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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (hero.temp_ring_1 == 11) //кольца на силу
            {
                label4.Text = "кольцо на силу +1 ";
            }
            if (hero.temp_ring_1 == 12)
            {
                label4.Text = "кольцо на силу +2";
            }
            if (hero.temp_ring_1 == 13)
            {
                label4.Text = "кольцо на силу +3";
            }
            if (hero.temp_ring_1 == 21) //кольца на ловкость
            {
                label4.Text = "кольцо на ловкость +1";
            }
            if (hero.temp_ring_1 == 22)
            {
                label4.Text = "кольцо на ловкость +2";
            }
            if (hero.temp_ring_1 == 23)
            {
                label4.Text = "кольцо на ловкость +3";
            }
            if (hero.temp_ring_1 == 31) //кольца на телосложения
            {
                label4.Text = "кольцо на телосложение +1";
            }
            if (hero.temp_ring_1 == 32)
            {
                label4.Text = "кольцо на телосложение +2";
            }
            if (hero.temp_ring_1 == 33)
            {
                label4.Text = "кольцо на телосложение +3";
            }
            if (hero.temp_ring_1 == 41) //кольца на интеллект
            {
                label4.Text = "кольцо на интелеллект +1";
            }
            if (hero.temp_ring_1 == 42)
            {
                label4.Text = "кольцо на интелеллект +2";
            }
            if (hero.temp_ring_1 == 43)
            {
                label4.Text = "кольцо  на интелеллект +3";
            }
            if (hero.temp_ring_1 == 51) //кольца на хп
            {
                label4.Text = "кольцо на хп +1";
            }
            if (hero.temp_ring_1 == 52)
            {
                label4.Text = "кольцо на хп +2";
            }
            if (hero.temp_ring_1 == 53)
            {
                label4.Text = "кольцо на хп +3";
            }

            if (hero.temp_ring_2 == 11) //кольца на силу
            {
                label3.Text = "кольцо на силу +1";
            }
            if (hero.temp_ring_2 == 12)
            {
                label3.Text = "кольцо на силу +2";
            }
            if (hero.temp_ring_2 == 13)
            {
                label3.Text = "кольцо на силу +3";
            }
            if (hero.temp_ring_2 == 21) //кольца на ловкость
            {
                label3.Text = "кольцо на ловкость +1";
            }
            if (hero.temp_ring_2 == 22)
            {
                label3.Text = "кольцо на ловкость +2";
            }
            if (hero.temp_ring_2 == 23)
            {
                label3.Text = "кольцо на ловкость +3";
            }
            if (hero.temp_ring_2 == 31) //кольца на телосложения
            {
                label3.Text = "кольцо на телосложение +1";
            }
            if (hero.temp_ring_2 == 32)
            {
                label3.Text = "кольцо на телосложение +2";
            }
            if (hero.temp_ring_2 == 33)
            {
                label3.Text = "кольцо на телосложение +3";
            }
            if (hero.temp_ring_2 == 41) //кольца на интеллект
            {
                label3.Text = "кольцо на интеллект +1";
            }
            if (hero.temp_ring_2 == 42)
            {
                label3.Text = "кольцо на интеллект +2";
            }
            if (hero.temp_ring_2 == 43)
            {
                label3.Text = "кольцо на интеллект +3";
            }
            if (hero.temp_ring_2 == 51) //кольца на хп
            {
                label3.Text = "кольцо на хп +1";
            }
            if (hero.temp_ring_2 == 52)
            {
                label3.Text = "кольцо на хп +2";
            }
            if (hero.temp_ring_2 == 53)
            {
                label3.Text = "кольцо на хп +3";
            }

            if (hero.temp_armor == 11) //легкая
            {
                label2.Text = "Роба +1";
            }
            if (hero.temp_armor == 12)
            {
                label2.Text = "Роба +2";
            }
            if (hero.temp_armor == 13)
            {
                label2.Text = "Роба +3";
            }
            if (hero.temp_armor == 21) //кожанная
            {
                label2.Text = "Кожанная броня +1";
            }
            if (hero.temp_armor == 22)
            {
                label2.Text = "Кожанная броня +2";
            }
            if (hero.temp_armor == 23)
            {
                label2.Text = "Кожанная броня +3";
            }
            if (hero.temp_armor == 31) //латы
            {
                label2.Text = "Латы +1";
            }
            if (hero.temp_armor == 32)
            {
                label2.Text = "Латы +2";
            }
            if (hero.temp_armor == 33)
            {
                label2.Text = "Латы +3";
            }

            if (hero.temp_waepon == 11) //мечи
            {
                label1.Text = "меч +1";
            }
            if (hero.temp_waepon == 12)
            {
                label1.Text = "меч +2";
            }
            if (hero.temp_waepon == 13)
            {
                label1.Text = "меч +3";
            }
            if (hero.temp_waepon == 21) //кинжалы
            {
                label1.Text = "кинжал +1";
            }
            if (hero.temp_waepon == 22)
            {
                label1.Text = "кинжал +2";
            }
            if (hero.temp_waepon == 23)
            {
                label1.Text = "кинжал +3";
            }
            if (hero.temp_waepon == 31) //копье
            {
                label1.Text = "копье +1";
            }
            if (hero.temp_waepon == 32)
            {
                label1.Text = "копье +2";
            }
            if (hero.temp_waepon == 33)
            {
                label1.Text = "копье +3";
            }
            if (hero.temp_waepon == 41) //посохи
            {
                label1.Text = "магический посох +1";
            }
            if (hero.temp_waepon == 42)
            {
                label1.Text = "магический посох +2";
            }
            if (hero.temp_waepon == 43)
            {
                label1.Text = "магический посох +3";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
