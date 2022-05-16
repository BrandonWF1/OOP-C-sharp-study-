using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Nesterov402Lab1
{
    public partial class Form1 : Form
    {
        triangle A = new triangle(10, 15, 40);
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void createTriangle_Click(object sender, EventArgs e)
        {
            /*double a, b, c;
            a = Math.Sqrt(Math.Pow(Convert.ToDouble((secondX.Value - firstX.Value)),2) + Math.Pow(Convert.ToDouble((secondY.Value - firstY.Value)),2));
            b = Math.Sqrt(Math.Pow(Convert.ToDouble((thirdX.Value - firstX.Value)), 2) + Math.Pow(Convert.ToDouble((thirdY.Value - firstY.Value)), 2));
            c = Math.Sqrt(Math.Pow(Convert.ToDouble((secondX.Value - thirdX.Value)), 2) + Math.Pow(Convert.ToDouble((secondY.Value - thirdY.Value)), 2));
            if (a + b > c && a + c > b && b + c > a)
            {
                A.Replace(new Point(Convert.ToInt32(firstX.Value), Convert.ToInt32(firstY.Value)), 0);
                A.Replace(new Point(Convert.ToInt32(secondX.Value), Convert.ToInt32(secondY.Value)), 1);
                A.Replace(new Point(Convert.ToInt32(thirdX.Value), Convert.ToInt32(thirdY.Value)), 2);
                A.Draw(box);
                richTextBox1.Text = "ТРЕУГОЛЬНИК ПОСТРОЕН!";
            }
            else richTextBox1.Text = "НЕПРАВИЛЬНЫЙ ТРЕУГОЛЬНИК";*/


            A.Calculate(Convert.ToInt32(lineLenght.Value), 0, Convert.ToInt32(firstX.Value), Convert.ToInt32(firstY.Value));
            A.Draw(box);
            richTextBox1.Text = "ТРЕУГОЛЬНИК ПОСТРОЕН!";

        }

        private void randomValues_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            firstX.Value= rnd.Next(1, 400);
            firstY.Value = rnd.Next(1, 200);
            lineLenght.Value = rnd.Next(50, 150);


            //ОБЫЧНЫЙ ТРЕУГОЛЬНИК
            //secondX.Value = rnd.Next(0, 600);
            // thirdX.Value = rnd.Next(0, 600);
            // secondY.Value = rnd.Next(0, 300);
            // thirdY.Value = rnd.Next(0, 300);
        }

        private void rotate_Click(object sender, EventArgs e)
        {
           A.Rotate(Convert.ToInt32(angleRotate.Value),box);


        }

        private void createOpOkr_Click(object sender, EventArgs e)
        {
            A.opisOkr(box);
        }

        private void createVpisOkr_Click(object sender, EventArgs e)
        {
            A.vpisOkr(box);
        }
    }
}
