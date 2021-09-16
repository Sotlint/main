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
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();
            string[] fu = { "sin(X)", "cos(x)", "sin(x+П/4)", "cos(x-П/4)" };
            listBox1.Items.AddRange(fu);

            string[] color = { "Красный", "Синий", "Зеленый","Желтый"};
            listBox2.Items.AddRange(color);
            


        }




        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Program.f1.pictureBox1.CreateGraphics();
           
            int x = Program.f1.pictureBox1.Width;
            int y = Program.f1.pictureBox1.Height;
            int cx = Program.f1.pictureBox1.Width/2;
            int cy = Program.f1.pictureBox1.Height/2;

            Pen XY = new Pen(Color.Black, 2);
            g.DrawLine(XY,cx,0,cx,y);//oy
            g.DrawLine(XY, 0, cy, x, cy);//ox
            
            g.DrawLine(XY, cx, 0, 220, 15);//стрелка для oy
            g.DrawLine(XY, cx, 0, 200, 15);

            g.DrawLine(XY, x, cy, x-15, 175);//стрелка для ox
            g.DrawLine(XY, x, cy, x-15, 155);

            g.DrawLine(XY, cx / 2, cy, cx / 2, cy + 5); //разметка на ox
            g.DrawLine(XY, cx / 2, cy, cx / 2, cy - 5);
            g.DrawLine(XY, 315, cy, 315, cy + 5);
            g.DrawLine(XY, 315, cy, 315, cy - 5);
            g.DrawLine(XY, 158, 165, 158, 165 + 5); 
            g.DrawLine(XY, 158, 165, 158, 165 - 5);
            g.DrawLine(XY, 262, 165, 262, 165 + 5);
            g.DrawLine(XY, 262, 165, 262, 165 - 5);


            g.DrawLine(XY, cx, cy / 2, cx - 5, cy / 2);//разметка на oy
            g.DrawLine(XY, cx, cy / 2, cx + 5, cy / 2);
            g.DrawLine(XY, cx, 248, cx + 5, 248);
            g.DrawLine(XY, cx, 248, cx - 5, 248);


            g.DrawLine(XY, 210, 123, 210 - 5, 123);//разметка на oy
            g.DrawLine(XY, 210, 123, 210 + 5, 123);
            g.DrawLine(XY, 210, 207, 210 + 5, 207);
            g.DrawLine(XY, 210, 207, 210 - 5, 207);





            Program.f1.label1.ForeColor =  Color.Black;
             Program.f1.label2.ForeColor = Color.Black;
             Program.f1.label3.ForeColor = Color.Black;
             Program.f1.label4.ForeColor = Color.Black;
            Program.f1.label5.ForeColor = Color.Black;
            Program.f1.label6.ForeColor = Color.Black;
            Program.f1.label7.ForeColor = Color.Black;
            Program.f1.label8.ForeColor = Color.Black;

           
            
            
            if (listBox1.SelectedIndex== 0)   //sin(X)
            {
                if (listBox2.SelectedIndex == 0) //красный
                {
                    Pen myWind = new Pen(Color.Red, 2);
                    Program.f1.label9.ForeColor = Color.Red;

                    g.DrawBezier(myWind, 210, 165, 245, 95, 290, 85, 315, 82);
                    g.DrawBezier(myWind,105,248,  140,235, 175,235,  210,165);
                    

                }
                if (listBox2.SelectedIndex == 1) //синий 
                {
                    Pen myWind = new Pen(Color.Blue, 2);
                    Program.f1.label9.ForeColor = Color.Blue;

                    g.DrawBezier(myWind, 210, 165, 245, 95, 290, 85, 315, 82);
                    g.DrawBezier(myWind, 105, 248, 140, 235, 175, 235, 210, 165);

                }
                if (listBox2.SelectedIndex == 2) //зеленый
                {
                    Pen myWind = new Pen(Color.Green, 2);
                    Program.f1.label9.ForeColor = Color.Green;

                    g.DrawBezier(myWind, 210, 165, 245, 95, 290, 85, 315, 82);
                    g.DrawBezier(myWind, 105, 248, 140, 235, 175, 235, 210, 165);
                }
                if (listBox2.SelectedIndex == 3) //желтый
                {

                    Pen myWind = new Pen(Color.Yellow, 2);
                    Program.f1.label9.ForeColor = Color.Yellow;
                    g.DrawBezier(myWind, 210, 165, 245, 95, 290, 85, 315, 82);
                    g.DrawBezier(myWind, 105, 248, 140, 235, 175, 235, 210, 165);

                }
             }
            if (listBox1.SelectedIndex == 1) //cos(x)
            {

                if (listBox2.SelectedIndex == 0) //красный
                {
                    Program.f1.label10.ForeColor = Color.Red;
                    Pen myWind = new Pen(Color.Red, 2);
                    g.DrawBezier(myWind, 105, 165, 140, 95, 175, 85, 210, 82);
                    g.DrawBezier(myWind, 210, 82, 245, 85, 290, 95, 315, 165);

                }
                if (listBox2.SelectedIndex == 1) //синий 
                {
                    Program.f1.label10.ForeColor = Color.Blue;
                    Pen myWind = new Pen(Color.Blue, 2);
                    g.DrawBezier(myWind, 105, 165, 140, 95, 175, 85, 210, 82);
                    g.DrawBezier(myWind, 210, 82, 245, 85, 290, 95, 315, 165);
                }
                if (listBox2.SelectedIndex == 2) //зеленый
                {
                    Pen myWind = new Pen(Color.Green, 2);
                    Program.f1.label10.ForeColor = Color.Green;
                    g.DrawBezier(myWind, 105, 165, 140, 95, 175, 85, 210, 82);
                    g.DrawBezier(myWind, 210, 82, 245, 85, 290, 95, 315, 165);
                }

                if (listBox2.SelectedIndex == 3) //желтый
                {
                    Pen myWind = new Pen(Color.Yellow, 2);
                    Program.f1.label10.ForeColor = Color.Yellow;
                    g.DrawBezier(myWind, 105, 165, 140, 95, 175, 85, 210, 82);
                    g.DrawBezier(myWind, 210, 82, 245, 85, 290, 95, 315, 165);
                }

            }
            if (listBox1.SelectedIndex == 2) //sin(x+П/4)
            {


                if (listBox2.SelectedIndex == 0) //красный
                {
                    Program.f1.label11.ForeColor = Color.Red;
                    Pen myWind = new Pen(Color.Red, 2);
                    g.DrawBezier(myWind, 105, 224, 120, 225, 145, 185, 158, 165);
                    g.DrawBezier(myWind, 158, 165, 175, 130, 200, 110, 210, 102);
                    g.DrawBezier(myWind, 210, 102, 235, 80, 250, 79, 262, 82);
                    g.DrawBezier(myWind, 262, 82, 260, 80, 287, 79, 315, 100);
                }
                if (listBox2.SelectedIndex == 1) //синий 
                {
                    Program.f1.label11.ForeColor = Color.Blue;
                    Pen myWind = new Pen(Color.Blue, 2);
                    g.DrawBezier(myWind, 105, 224, 120, 225, 145, 185, 158, 165);
                    g.DrawBezier(myWind, 158, 165, 175, 130, 200, 110, 210, 102);
                    g.DrawBezier(myWind, 210, 102, 235, 80, 250, 79, 262, 82);
                    g.DrawBezier(myWind, 262, 82, 260, 80, 287, 79, 315, 100);
                }
                if (listBox2.SelectedIndex == 2) //зеленый
                {
                    Pen myWind = new Pen(Color.Green, 2);
                    Program.f1.label11.ForeColor = Color.Green;
                    g.DrawBezier(myWind, 105, 224, 120, 225, 145, 185, 158, 165);
                    g.DrawBezier(myWind, 158, 165, 175, 130, 200, 110, 210, 102);
                    g.DrawBezier(myWind, 210, 102, 235, 80, 250, 79, 262, 82);
                    g.DrawBezier(myWind, 262, 82, 260, 80, 287, 79, 315, 100);
                }
                if (listBox2.SelectedIndex == 3) //желтый
                {
                    Pen myWind = new Pen(Color.Yellow, 2);
                    Program.f1.label11.ForeColor = Color.Yellow;
                    g.DrawBezier(myWind, 105, 224, 120, 225, 145, 185, 158, 165);
                    g.DrawBezier(myWind, 158, 165, 175, 130, 200, 110, 210, 102);
                    g.DrawBezier(myWind, 210, 102, 235, 80, 250, 79, 262, 82);
                    g.DrawBezier(myWind, 262, 82, 260, 80, 287, 79, 315, 100);
                }




            }
            if (listBox1.SelectedIndex == 3) //cos(x - П / 4)
            {
                if (listBox2.SelectedIndex == 0) //красный
                {
                    Pen myWind = new Pen(Color.Red, 2);
                    Program.f1.label12.ForeColor = Color.Red;
                    g.DrawBezier(myWind, 105, 224, 120, 225, 145, 185, 158, 165);
                    g.DrawBezier(myWind, 158, 165, 175, 130, 200, 110, 210, 102);
                    g.DrawBezier(myWind, 210, 102, 235, 80, 250, 79, 262, 82);
                    g.DrawBezier(myWind, 262, 82, 260, 80, 287, 79, 315, 100);
                }
                if (listBox2.SelectedIndex == 1) //синий 
                {
                    Pen myWind = new Pen(Color.Blue, 2);
                    Program.f1.label12.ForeColor = Color.Blue;
                    g.DrawBezier(myWind, 105, 224, 120, 225, 145, 185, 158, 165);
                    g.DrawBezier(myWind, 158, 165, 175, 130, 200, 110, 210, 102);
                    g.DrawBezier(myWind, 210, 102, 235, 80, 250, 79, 262, 82);
                    g.DrawBezier(myWind, 262, 82, 260, 80, 287, 79, 315, 100);
                }
                if (listBox2.SelectedIndex == 2) //зеленый
                {
                    Pen myWind = new Pen(Color.Green, 2);
                    Program.f1.label12.ForeColor = Color.Green;
                    g.DrawBezier(myWind, 105, 224, 120, 225, 145, 185, 158, 165);
                    g.DrawBezier(myWind, 158, 165, 175, 130, 200, 110, 210, 102);
                    g.DrawBezier(myWind, 210, 102, 235, 80, 250, 79, 262, 82);
                    g.DrawBezier(myWind, 262, 82, 260, 80, 287, 79, 315, 100);
                }
                if (listBox2.SelectedIndex == 3) //желтый
                {
                    Pen myWind = new Pen(Color.Yellow, 2);
                    Program.f1.label12.ForeColor = Color.Yellow;
                    g.DrawBezier(myWind, 105, 224, 120, 225, 145, 185, 158, 165);
                    g.DrawBezier(myWind, 158, 165, 175, 130, 200, 110, 210, 102);
                    g.DrawBezier(myWind, 210, 102, 235, 80, 250, 79, 262, 82);
                    g.DrawBezier(myWind, 262, 82, 260, 80, 287, 79, 315, 100);


                }
            }   


                Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
