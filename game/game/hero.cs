using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    static class hero
    {
        public static string name;

        public static int ust = 0;
        public static int monet=100;

        public static float base_damage;//без оружия
        public static float damage;//урон в бою

        public static float lvlup_exp=10;
        public static float exp=0;
        public static float score=0;

        public static float trata_vin;
        public static float vinosl;

        public static float resist;
        public static float temp_hp;
        public static float max_hp;
        public static float hp;
        public static float magic_point;
        public static float dodje;
        public static float block;
        public static float crit;

        public static float str = 1;
        public static float dex = 1;
        public static float wiz = 1;
        public static float telo = 1;

        public static float ring_1 = 0;
        public static float ring_2 = 0;
        public static float ind_w = 0;

        public static float temp_ring_1 = 0;
        public static float temp_ring_2 = 0;
        public static float temp_armor = 0;
        public static float temp_waepon = 0;
        public static float temp_vin;

        public static float temp_dodje;
        public static float temp_block;
        public static float temp_crit;
        public static float temp_resist;
        public static float temp_str;
        public static float temp_dex;
        public static float temp_wiz;
        public static float temp_telo;
        public static float temp_damage;


        public static void char_har()
        {
         
            vinosl = 10+telo+str/2+dex/2+wiz/2;
            temp_vin = vinosl;
            resist =5+telo;
            hp = 10 + telo*10;
            max_hp = 10 + telo * 10;
            temp_hp = hp;
            magic_point = wiz - 1;
            dodje = 10 + dex + telo;
            block = 10 + str + telo;
            crit = 10 + dex;
            base_damage = (str) + (dex / 2) + (telo);
            if (ind_w == 0)
            {
                trata_vin = 2;
                damage = base_damage;
            }

            
           

            char_har_armor();

            char_har_weapon();
            temp_har();
        }

        public static void char_har_weapon()
        {

            if (generator.weapon == 0)
            {
                damage = base_damage;
            }
            else
            {
                Random rnd = new Random();
                ind_w = 1;
                crit = 10 + dex;
                temp_waepon = generator.weapon;
                if (generator.weapon == 11) //мечи
                {
                    damage = 5 + ((str + dex) / 2);
                    trata_vin = 5;
                }
                if (generator.weapon == 12)
                {
                    damage = rnd.Next(5, 15) + ((str + dex) / 2);
                    trata_vin = 5;
                }
                if (generator.weapon == 13)
                {
                    damage = rnd.Next(15, 25) + ((str + dex) / 2);
                    trata_vin = 5;
                }

                if (generator.weapon == 21) //кинжалы
                {
                    damage = 5 + dex;
                    crit = crit + 10;
                    trata_vin = 5 / 2;
                }
                if (generator.weapon == 22)
                {
                    damage = rnd.Next(5, 15) + dex;
                    crit = crit + 15;
                    trata_vin = 5 / 2;
                }
                if (generator.weapon == 23)
                {
                    damage = rnd.Next(15, 25) + dex;
                    crit = crit + 25;
                    trata_vin = 5 / 2;
                }

                if (generator.weapon == 31) //копье
                {
                    damage = 5 + str / 2 + dex;
                    crit = crit + 5;
                    trata_vin = 8;
                }
                if (generator.weapon == 32)
                {
                    damage = rnd.Next(5, 15) + str / 2 + dex;
                    crit = crit + 10;
                    trata_vin = 8;
                }
                if (generator.weapon == 33)
                {
                    damage = rnd.Next(15, 25) + str / 2 + dex;
                    crit = crit + 15;
                    trata_vin = 8;
                }

                if (generator.weapon == 41) //посохи
                {
                    damage = 5 + str / 2;
                    trata_vin = 5;
                }
                if (generator.weapon == 42)
                {
                    damage = rnd.Next(5, 15) + str / 2;
                    trata_vin = 5;
                }
                if (generator.weapon == 43)
                {
                    damage = rnd.Next(15, 25) + str / 2;
                    trata_vin = 5;
                }
            }
            temp_har();

        }

        public static void char_har_ring_1()
        {
            ring_1 = 1;

            if (temp_ring_1 == 11) //кольца на силу
            {
                str = str - 2;

            }

            if (temp_ring_1 == 12)
            {
                str = str - 4;
            }

            if (temp_ring_1 == 13)
            {
                str = str - 8;
            }

            if (temp_ring_1 == 21) //кольца на ловкость
            {
                dex = dex - 2;
            }

            if (temp_ring_1 == 22)
            {
                dex = dex - 4;
            }

            if (temp_ring_1 == 23)
            {
                dex = dex - 8;
            }

            if (temp_ring_1 == 31) //кольца на телосложения
            {
                telo = telo - 2;
            }

            if (temp_ring_1 == 32)
            {
                telo = telo - 4;
            }

            if (temp_ring_1 == 33)
            {
                telo = telo - 8;
            }

            if (temp_ring_1 == 41) //кольца на интеллект
            {
                wiz = wiz - 2;
            }

            if (temp_ring_1 == 42)
            {
                wiz = wiz - 4;
            }

            if (temp_ring_1 == 43)
            {
                wiz = wiz - 8;
            }

            if (temp_ring_1 == 51) //кольца на хп
            {
                hp = hp - 10;
            }

            if (temp_ring_1 == 52)
            {
                hp = hp - 20;
            }

            if (temp_ring_1 == 53)
            {
                hp = hp - 40;
            }



                if (generator.ring == 11) //кольца на силу
                {
                    str = str + 2;

                }

                if (generator.ring == 12)
                {
                    str = str + 4;
                }

                if (generator.ring == 13)
                {
                    str = str + 8;
                }

                if (generator.ring == 21) //кольца на ловкость
                {
                    dex = dex + 2;
                }

                if (generator.ring == 22)
                {
                    dex = dex + 4;
                }

                if (generator.ring == 23)
                {
                    dex = dex + 8;
                }

                if (generator.ring == 31) //кольца на телосложения
                {
                    telo = telo + 2;
                }

                if (generator.ring == 32)
                {
                    telo = telo + 4;
                }

                if (generator.ring == 33)
                {
                    telo = telo + 8;
                }

                if (generator.ring == 41) //кольца на интеллект
                {
                    wiz = wiz + 2;
                }

                if (generator.ring == 42)
                {
                    wiz = wiz + 4;
                }

                if (generator.ring == 43)
                {
                    wiz = wiz + 8;
                }

                if (generator.ring == 51) //кольца на хп
                {
                    hp = hp + 10;
                }

                if (generator.ring == 52)
                {
                    hp = hp + 20;
                }

                if (generator.ring == 53)
                {
                    hp = hp + 40;
                }
            temp_har();
        
            temp_ring_1 = generator.ring;
        }

        public static void char_har_ring_2()
        {
            ring_2 = 1;

            if (temp_ring_2 == 11) //кольца на силу
            {
                str = str - 2;

            }

            if (temp_ring_2 == 12)
            {
                str = str - 4;
            }

            if (temp_ring_2 == 13)
            {
                str = str - 8;
            }

            if (temp_ring_2 == 21) //кольца на ловкость
            {
                dex = dex - 2;
            }

            if (temp_ring_2 == 22)
            {
                dex = dex - 4;
            }

            if (temp_ring_2 == 23)
            {
                dex = dex - 8;
            }

            if (temp_ring_2 == 31) //кольца на телосложения
            {
                telo = telo - 2;
            }

            if (temp_ring_2 == 32)
            {
                telo = telo - 4;
            }

            if (temp_ring_2 == 33)
            {
                telo = telo - 8;
            }

            if (temp_ring_2 == 41) //кольца на интеллект
            {
                wiz = wiz - 2;
            }

            if (temp_ring_2 == 42)
            {
                wiz = wiz - 4;
            }

            if (temp_ring_2 == 43)
            {
                wiz = wiz - 8;
            }

            if (temp_ring_2 == 51) //кольца на хп
            {
                hp = hp - 10;
            }

            if (temp_ring_2 == 52)
            {
                hp = hp - 20;
            }

            if (temp_ring_2 == 53)
            {
                hp = hp - 40;
            }



            if (generator.ring == 11) //кольца на силу
            {
                str = str + 2;

            }

            if (generator.ring == 12)
            {
                str = str + 4;
            }

            if (generator.ring == 13)
            {
                str = str + 8;
            }

            if (generator.ring == 21) //кольца на ловкость
            {
                dex = dex + 2;
            }

            if (generator.ring == 22)
            {
                dex = dex + 4;
            }

            if (generator.ring == 23)
            {
                dex = dex + 8;
            }

            if (generator.ring == 31) //кольца на телосложения
            {
                telo = telo + 2;
            }

            if (generator.ring == 32)
            {
                telo = telo + 4;
            }

            if (generator.ring == 33)
            {
                telo = telo + 8;
            }

            if (generator.ring == 41) //кольца на интеллект
            {
                wiz = wiz + 2;
            }

            if (generator.ring == 42)
            {
                wiz = wiz + 4;
            }

            if (generator.ring == 43)
            {
                wiz = wiz + 8;
            }

            if (generator.ring == 51) //кольца на хп
            {
                hp = hp + 10;
            }

            if (generator.ring == 52)
            {
                hp = hp + 20;
            }

            if (generator.ring == 53)
            {
                hp = hp + 40;
            }
            
            temp_ring_2 = generator.ring;
            temp_har();
        }


        public static void char_har_armor()
        {

                if (temp_armor == 11) //легкая
                {
                    dodje = dodje - 10;

                }

                if (temp_armor == 12)
                {
                    dodje = dodje - 15;

                }

                if (temp_armor == 13)
                {
                    dodje = dodje - 25;

                }

                if (temp_armor == 21) //кожанная
                {
                    dodje = dodje - 5;
                    block = block - 5;
                    resist = resist - 5;

                }

                if (temp_armor == 22)
                {
                    dodje = dodje - 10;
                    block = block - 10;
                    resist = resist - 10;
                }

                if (temp_armor == 23)
                {
                    dodje = dodje - 20;
                    block = block - 20;
                    resist = resist - 15;

                }

                if (temp_armor == 31) //латы
                {
                    block = block - 10;
                    resist = resist - 10;
                }

                if (temp_armor == 32)
                {
                    block = block - 15;
                    resist = resist - 15;
                }

                if (temp_armor == 33)
                {
                    block = block - 25;
                    resist = resist - 20;

                }




                if (generator.armor == 11) //легкая
                {
                    dodje = dodje + 10;

                }

                if (generator.armor == 12)
                {
                    dodje = dodje + 15;

                }

                if (generator.armor == 13)
                {
                    dodje = dodje + 25;

                }

                if (generator.armor == 21) //кожанная
                {
                    dodje = dodje + 5;
                    block = block + 5;
                    resist = resist + 5;
                }

                if (generator.armor == 22)
                {
                    dodje = dodje + 10;
                    block = block + 10;
                    resist = resist + 10;
                }

                if (generator.armor == 23)
                {
                    dodje = dodje + 20;
                    block = block + 20;
                    resist = resist + 15;

                }

                if (generator.armor == 31) //латы
                {
                    block = block + 10;
                    resist = resist + 10;
                }

                if (generator.armor == 32)
                {
                    block = block + 15;
                    resist = resist + 15;
                }

                if (generator.armor == 33)
                {
                    block = block + 25;
                    resist = resist + 20;
                }


                temp_armor = generator.armor;
            temp_har();


        }


        public static void temp_har()
        {
            temp_str = str;
            temp_dex = dex;
            temp_wiz = wiz;
            temp_telo = telo;
            temp_damage = damage;
            temp_block = block;
            temp_crit = crit;
            temp_dodje = dodje;
            temp_resist = resist;
            

        }

    }
}
