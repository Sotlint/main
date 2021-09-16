using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k3
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
           


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)  //информация о разработчике
        {
            Form2 newForm = new Form2();
            newForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Graphics g = Program.f1.pictureBox1.CreateGraphics();
            g.Clear(DefaultBackColor);
            Program.f1.label1.ForeColor = Color.WhiteSmoke;
              Program.f1.label2.ForeColor = Color.WhiteSmoke;
            Program.f1.label3.ForeColor =Color.WhiteSmoke;
            Program.f1.label4.ForeColor = Color.WhiteSmoke;
            Program.f1.label5.ForeColor = Color.WhiteSmoke;
            Program.f1.label6.ForeColor = Color.WhiteSmoke;
            Program.f1.label7.ForeColor = Color.WhiteSmoke;
            Program.f1.label8.ForeColor = Color.WhiteSmoke;
            Program.f1.label9.ForeColor = Color.WhiteSmoke;
            Program.f1.label10.ForeColor = Color.WhiteSmoke;
            Program.f1.label11.ForeColor = Color.WhiteSmoke;
            Program.f1.label12.ForeColor = Color.WhiteSmoke;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
