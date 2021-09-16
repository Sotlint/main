using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            string[] temp = new string[Program.baza.Count];
            InitializeComponent();
            for (int i = 0; i < Program.baza.Count; i++)
            {
                temp[i] = Program.baza[i].name;
                
            }
            listBox1.Items.AddRange(temp);
        }

        private void button2_Click(object sender, EventArgs e) //закрыть
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e) 
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//удаление
        {
            int del = listBox1.SelectedIndex;
            Program.baza.Remove(Program.baza[del]);
            Close();
        }
    }
}
