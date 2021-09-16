using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public static class generator
    {
        public static float ring = 0;
        public static float armor = 0;
        public static float weapon = 0;
        private static Random rnd = new Random();


        public static void gen_w()
        {
           
        
            int t = rnd.Next(1, 4);
            
            int v = rnd.Next(1, 5);

            if (v == 1)  //sword 
            {
                if (t == 1)
                {
                    weapon = 11;
                }
                if (t == 2)
                {
                    weapon = 12;
                }
                if (t == 3)
                {
                    weapon = 13;
                }
            }

            if (v == 2) // dagger 
            {
                if (t == 1)
                {
                    weapon = 21;
                }
                if (t == 2)
                {
                    weapon = 22;
                }
                if (t == 3)
                {
                    weapon = 23;
                }
            }

            if (v == 3) // spear 
            {
                if (t == 1)
                {
                    weapon = 31;
                }
                if (t == 2)
                {
                    weapon = 32;
                }
                if (t == 3)
                {
                    weapon = 33;
                }
            }


            if (v == 4)  //  pstaf 
            {
                if (t == 1)
                {
                    weapon = 41;
                }
                if (t == 2)
                {
                    weapon = 42;
                }
                if (t == 3)
                {
                    weapon = 43;
                }
            }
        }
        public static void gen_ring()
        {
           
            int t = rnd.Next(1, 4);
            int v = rnd.Next(1, 6);

            if(v == 1) //ring str
            {
                if(t == 1)
                {
                    ring = 11;
                }
                if (t == 2)
                {
                    ring = 12;
                }
                if (t == 3)
                {
                    ring = 13;
                }

            }


            if (v == 2) //ring dex
            {
                if (t == 1)
                {
                    ring = 21;
                }
                if (t == 2)
                {
                    ring = 22;
                }
                if (t == 3)
                {
                    ring = 23;
                }
            }


            if (v == 3) //ring telo
            {
                if (t == 1)
                {
                    ring = 31;
                }
                if (t == 2)
                {
                    ring = 32;
                }
                if (t == 3)
                {
                    ring = 33;
                }
            }


            if (v == 4) //ring wiz
            {
                if (t == 1)
                {
                    ring = 41;
                }
                if (t == 2)
                {
                    ring = 42;
                }
                if (t == 3)
                {
                    ring = 43;
                }
            }


            if (v == 5) //ring hp
            {
                if (t == 1)
                {
                    ring = 51;
                }
                if (t == 2)
                {
                    ring = 52;
                }
                if (t == 3)
                {
                    ring = 53;
                }
            }

        }
        public static void gen_armor()
        {
            
            int t = rnd.Next(1, 4);
            int v = rnd.Next(1, 4);

            if (v == 1) //light
            {
                if (t == 1)
                {
                    armor = 11;
                }
                if (t == 2)
                {
                    armor = 12;
                }
                if (t == 3)
                {
                    armor = 13;
                }

            }


            if (v == 2) //med
            {
                if (t == 1)
                {
                    armor = 21;
                }
                if (t == 2)
                {
                    armor = 22;
                }
                if (t == 3)
                {
                    armor = 23;
                }
            }


            if (v == 3) //heav
            {
                if (t == 1)
                {
                    armor = 31;
                }
                if (t == 2)
                {
                    armor = 32;
                }
                if (t == 3)
                {
                    armor = 33;
                }
            }


        }






    }
}
