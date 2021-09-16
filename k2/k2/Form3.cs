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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details; //каждый элемент в отдельной строке
            listView1.GridLines = true; //отоброжение сетки

            listView1.Columns.Add("Имя");
            listView1.Columns.Add("Телефон");
            listView1.Columns.Add("Дата рождения");

            listView1.Items.Clear();


            listView2.View = View.Details; //каждый элемент в отдельной строке
            listView2.GridLines = true; //отоброжение сетки

            listView2.Columns.Add("Имя");
            listView2.Columns.Add("Телефон");
            listView2.Columns.Add("Дата рождения");

            listView2.Items.Clear();



            for (int i = 0; i < Program.baza.Count; i++)
            {

                listView1.Items.Add(Program.baza[i].name);
                listView1.Items[i].SubItems.Add(Program.baza[i].phone_num);
                listView1.Items[i].SubItems.Add(Program.baza[i].dd+"."+ Program.baza[i].mm+"."+ Program.baza[i].gg);

                
            }
        }

        private void button2_Click(object sender, EventArgs e) //поиск по имени
        {
            listView2.Items.Clear();
            for (int i = 0; i < Program.baza.Count; i++)
            {
                if(Program.baza[i].name == textBox1.Text)
                {
                    listView2.Items.Add(Program.baza[i].name);
                    listView2.Items[i].SubItems.Add(Program.baza[i].phone_num);
                    listView2.Items[i].SubItems.Add(Program.baza[i].dd + "." + Program.baza[i].mm + "." + Program.baza[i].gg);
                }
                
            }




        }

        private void button3_Click(object sender, EventArgs e) //поиск по телеону
        {
            listView2.Items.Clear();
            for (int i = 0; i < Program.baza.Count; i++)
            {
                if (Program.baza[i].phone_num == textBox2.Text)
                {
                    listView2.Items.Add(Program.baza[i].name);
                    listView2.Items[i].SubItems.Add(Program.baza[i].phone_num);
                    listView2.Items[i].SubItems.Add(Program.baza[i].dd + "." + Program.baza[i].mm + "." + Program.baza[i].gg);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)//посик по году рождения
        {
            listView2.Items.Clear();
            for (int i = 0; i < Program.baza.Count; i++)
            {
                if (Program.baza[i].gg == textBox3.Text)
                {
                    listView2.Items.Add(Program.baza[i].name);
                    listView2.Items[i].SubItems.Add(Program.baza[i].phone_num);
                    listView2.Items[i].SubItems.Add(Program.baza[i].dd + "." + Program.baza[i].mm + "." + Program.baza[i].gg);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)//посик по месяцу  рождения
        {
            listView2.Items.Clear();

            for (int i = 0; i < Program.baza.Count; i++)
            {
                if (Program.baza[i].mm == textBox4.Text)
                {
                    listView2.Items.Add(Program.baza[i].name);
                    listView2.Items[i].SubItems.Add(Program.baza[i].phone_num);
                    listView2.Items[i].SubItems.Add(Program.baza[i].dd + "." + Program.baza[i].mm + "." + Program.baza[i].gg);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)//посик по дню рождения
        {
            listView2.Items.Clear();
            for (int i = 0; i < Program.baza.Count; i++)
            {
                if (Program.baza[i].dd == textBox5.Text)
                {
                    listView2.Items.Add(Program.baza[i].name);
                    listView2.Items[i].SubItems.Add(Program.baza[i].phone_num);
                    listView2.Items[i].SubItems.Add(Program.baza[i].dd + "." + Program.baza[i].mm + "." + Program.baza[i].gg);
                }

            }
        }
    }

        
    }
