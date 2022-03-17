using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm15._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = a + b; 
            int y = a + c; 
            int z = c + b;
            if (x > c && y > b && z > a)
            {
                label4.Text = "Треугольник реализуется";
            }
            else
            {
                label4.Text = "Треугольник не реализуется";
                return;
            }

            if (a == b && a == c && b == c)
            {
                label5.Text = "Треугольник равносторонний";
            }
            if (a == b || a == c || b == c)
            {
                label6.Text = "Треугольник равнобедренных";
            }
            else
            {
                label5.Text = "Треугольник разносторонний";
            }

            float p = (a + b + c) / 2;
            float s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            s = (float)Math.Round(s, 2);
            label7.Text = "P = " + Convert.ToString(p);
            label8.Text = "S = " + Convert.ToString(s);

            string type = "остроугольный";
            if (a * a == b * b + c * c || b * b == c * c + a * a || c * c == a * a + b * b)
            {
                type = "прямоугольный";
            }
            if (a * a > b * b + c * c || c * c > a * a + b * b || b * b > a * a + c * c)
            {
                type = "тупоугольный";
            }

            label9.Text = "Вид: " + type;
        }
    }
}
