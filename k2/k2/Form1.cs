using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace k2
{
    

    public partial class Form1 : Form
    {

        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //ввод с клавиатуры
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int j = 1;
            StreamWriter sr = new StreamWriter("baza.txt", true);
            for (int i = 0; i < Program.baza.Count; i++)
            {
                sr.WriteLine("№ " + j) ;
                sr.WriteLine("Имя: "+ Program.baza[i].name);
                sr.WriteLine("Телефон: "+ Program.baza[i].phone_num);
                sr.WriteLine("Дата рождения: "+ Program.baza[i].dd + "." + Program.baza[i].mm + "." + Program.baza[i].gg);
                sr.WriteLine("");
                sr.WriteLine("");
                sr.WriteLine("");
                j += 1;
            }

            sr.Close();
        }

        public void button5_Click(object sender, EventArgs e) //удаление
        {
            
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e) //сортировка по имени
        {
            
            Program.baza.Sort();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        //  private void button7_Click(object sender, EventArgs e)
        //   {


        //  }

        // private void button8_Click(object sender, EventArgs e)
        //   {

        //    }

        //  private void button9_Click(object sender, EventArgs e)
        //   {

        //  }
    }
}
