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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Program.obj[Program.i].name = textBox1.Text;
            Program.obj[Program.i].phone_num = textBox2.Text;
            
            Program.obj[Program.i].dd = textBox3.Text; 
            Program.obj[Program.i].mm = textBox4.Text;
            Program.obj[Program.i].gg = textBox5.Text;


            Program.baza.Add(Program.obj[Program.i]); //добавление в коллекцию
           
            Program.i += 1; //переход по массиву, чтобы в след раз записать новый элемент
           
           
            Close();
        }

        private void button3_Click(object sender, EventArgs e) //чтение из файла
        {
            StreamReader sr = new StreamReader("info.txt");

            Program.obj[Program.i].name = sr.ReadLine(); 
            Program.obj[Program.i].phone_num = sr.ReadLine(); 
             
            Program.obj[Program.i].dd = sr.ReadLine(); 
            Program.obj[Program.i].mm = sr.ReadLine(); 
            Program.obj[Program.i].gg = sr.ReadLine(); 

            Program.baza.Add(Program.obj[Program.i]);
            Program.i += 1;

            sr.Close();
            Close();
        }
    }
}
