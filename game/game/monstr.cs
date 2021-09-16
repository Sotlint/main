using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class monstr

    {
        private static Random rnd = new Random();
        public static string log;
        public static float temp_vin;
        public static float trata_vin = 2;
        public static float vinosl;
        public static float resist;
        public static float hp;
        public static float magic_point;
        public static float dodje;
        public static float block;
        public static float crit;
        public static float damage = 5;

        public static float str = 1;
        public static float dex = 1;
        public static float wiz = 1;
        public static float telo = 1;
        public static void monstr_har()
        {
            vinosl = 10 + telo + str / 2 + dex / 2 + wiz / 3;
            temp_vin = vinosl;
            resist = 5 + telo;
            hp = 10 + telo * 10;
            magic_point = wiz - 1;
            dodje = 10 + dex + telo;
            block = 10 + str + telo;
            crit = 10 + dex;

        }


        public static void AI_monster()
        {
            Random rnd = new Random();
            float temp_block;
            int ch;
            if (vinosl >= trata_vin) //атака
            {
                ch = rnd.Next(1, 101);
                if (hero.dodje >= ch)
                {
                    hero.hp = hero.hp - 0;
                    log = "Монстр провел атаку но герой уклонился";
                    vinosl = vinosl - trata_vin;

                }
                else
                {
                    ch = rnd.Next(1, 101);

                    if (hero.block >= ch)
                    {
                        temp_block = hero.block;
                        hero.block = 95;
                        hero.hp = hero.hp - damage * (1 - (hero.resist / 100));
                        hero.block = temp_block;
                        vinosl = vinosl - trata_vin;
                        log = "Монстр провел атаку но герой блокировал";

                    }

                    else
                    {
                        ch = rnd.Next(1, 101);
                        if (crit >= ch)
                        {
                            hero.hp = hero.hp - damage * 2;
                            vinosl = vinosl - trata_vin;
                            log = "Монстр нанес критический урон";

                        }
                        else
                        {
                            hero.hp = (hero.hp - damage * (1 - (hero.resist / 100)));
                            vinosl = vinosl - trata_vin;
                            log = "Монстр нанес обычный урон";

                        }
                    }
                }

                

            }
            else //защита
            {
                log = "Монстр защищается";
                if (temp_vin <= (temp_vin / 3) + vinosl)
                {

                    vinosl = temp_vin;


                }
                else
                {
                    vinosl = vinosl + (temp_vin / 3);
                }
            }

        }




        public static void gen_monster()
        {
            
            int i = rnd.Next(1, 8);
            if (i<=5)
            {
                int temp;
                temp = rnd.Next(1, 4);
                if (telo - temp < 0)
                {
                    telo = hero.telo - 1;
                }
                else 
                {
                    telo = hero.telo - temp;
                }

                temp = rnd.Next(1, 4);
                if (str - temp < 0)
                {
                    str = hero.str - 1;
                }
                else
                {
                    telo = hero.str - temp;
                }

                temp = rnd.Next(1, 4);
                if (dex - temp < 0)
                {
                    dex = hero.dex - 1;
                }
                else
                {
                    dex = hero.dex - temp;
                }

                temp = rnd.Next(1, 4);
                if (wiz - temp < 0)
                {
                    wiz = hero.wiz - 1;
                }
                else
                {
                    wiz = hero.wiz - temp;
                }


            }
            if ( i==6)
            {
                telo = hero.telo;
                dex = hero.dex;
                str = hero.str;
                wiz = hero.wiz;
            }
            if (i==7)
            {
                telo = hero.telo+ rnd.Next(1, 4);
                dex =  hero.dex+ rnd.Next(1, 4);
                str =  hero.str+ rnd.Next(1, 4);
                wiz =  hero.wiz+ rnd.Next(1, 4);
            }
        }
    }
}

