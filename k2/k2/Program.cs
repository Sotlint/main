using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2
{
    struct NOTE : IComparable
    {
        public string name;
        public string phone_num;

        
        public string dd;
        public string mm;
        public string gg;

        public int CompareTo(object obj)
        {
 
                return name.CompareTo(Convert.ToString(obj));

        }
    }

    static class Program
    {

        public static Form1 f1;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
       public static NOTE[] obj = new NOTE[100];
       public static List<NOTE> baza = new List<NOTE>();
       public static int i=0;

    }
}
