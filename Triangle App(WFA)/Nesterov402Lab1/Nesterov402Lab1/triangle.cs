using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Nesterov402Lab1
{

    class triangle
    {
        Color color = Color.Green;
        PointF[] points = new PointF[3];
        float centerX, centerY;
        public triangle(int R = 0, int G = 0, int B = 0)
        {
            color = Color.FromArgb(R, G, B);
        }
        public void Replace(Point A,int k)
        {
            PointF[] temp = new PointF[3];
                points.CopyTo(temp, 0);
            temp[k] = A;
            points = temp;


        }
        public void Draw(PictureBox A)
        {

            // РАЗНОЕ


            //centerX = points[0].X;
            //centerY = points[0].Y;
            //Pen pen1 = new Pen(color, 1.7F);
            /*for (int i = 0; i < 3; i++)
            {
                gr.DrawEllipse(pen1, points[i].X, points[i].Y, 3, 3);
                if (i >= 1) { gr.DrawLine(pen1, points[i - 1], points[i]); }
                if (i == 2) { gr.DrawLine(pen1, points[i], points[0]); }
            }*/
            /*gr.TranslateTransform(centerX, centerY);
            gr.RotateTransform(r);
            gr.TranslateTransform(-centerX, -centerY);*/


            Graphics gr = A.CreateGraphics();
            SolidBrush brs = new SolidBrush(Color.Black);
            gr.Clear(A.BackColor);
            
            gr.FillPolygon(brs, points);

        }
        public void Calculate(int dist, float ang,int x,int y)

        {
         
            points[0].X = x;

            points[0].Y = y;

            points[1].X = (float)(x + dist * Math.Cos(ang));

            points[1].Y = (float)(y + dist * Math.Sin(ang));

            points[2].X = (float)(x + dist * Math.Cos(ang + Math.PI / 3));

            points[2].Y = (float)(y + dist * Math.Sin(ang + Math.PI / 3));
            centerX = (points[0].X + points[1].X + points[2].X) / 3;
            centerY = (points[0].Y + points[1].Y + points[2].Y) / 3;
            
        }
        public void Rotate(float r,PictureBox B)
        {
            //float angle =(float) (A * (Math.PI / 180));
            // float centerX, centerY;
            // centerX = (points[0].X + points[1].X + points[2].X) / 3;
            // centerY= (points[0].Y + points[1].Y + points[2].Y) / 3;
            //points[0].X = (Math.Cos(angle) * (points[0].X - centerX) - Math.Sin(angle) * (points[0].Y - centerY) + centerX);
            //points[0].Y = (Math.Sin(angle) * (points[0].X - centerX) + Math.Cos(angle) * (points[0].Y - centerY) + centerY);
            //points[1].X = (Math.Cos(angle) * (points[1].X - centerX) - Math.Sin(angle) * (points[1].Y - centerY) + centerX);
            //points[1].Y = (Math.Sin(angle) * (points[1].X - centerX) + Math.Cos(angle) * (points[1].Y - centerY) + centerY);
            // points[2].X = (Math.Cos(angle) * (points[2].X - centerX) - Math.Sin(angle) * (points[2].Y - centerY) + centerX);
            //points[2].Y = (Math.Sin(angle) * (points[2].X - centerX) + Math.Cos(angle) * (points[2].Y - centerY) + centerY);



            Graphics gr = B.CreateGraphics();
            SolidBrush brs = new SolidBrush(Color.Black);
            gr.Clear(B.BackColor);
            gr.TranslateTransform(centerX, centerY);
            gr.RotateTransform(r);
            gr.TranslateTransform(-centerX, -centerY);
            gr.FillPolygon(brs, points);


        }
        public void opisOkr(PictureBox A)
        {
            float c;
            c = (float)Math.Sqrt(Math.Pow((points[1].X - points[0].X), 2) + Math.Pow((points[1].Y - points[0].Y), 2));
            Graphics gr = A.CreateGraphics();
            Pen pen1 = new Pen(color, 1.7F);
            float Radius =(float) (c / (Math.Sqrt(3)));
            gr.DrawEllipse(pen1, centerX - Radius, centerY - Radius, Radius + Radius, Radius + Radius);
    
        }
        public void vpisOkr(PictureBox A)
        {
            float c;
            c = (float)Math.Sqrt(Math.Pow((points[1].X - points[0].X), 2) + Math.Pow((points[1].Y - points[0].Y), 2));
            Graphics gr = A.CreateGraphics();
            Pen pen1 = new Pen(Color.Red, 1.7F);
            float Radius = (float)(c / (2*(Math.Sqrt(3))));
            gr.DrawEllipse(pen1, centerX - Radius, centerY - Radius, Radius + Radius, Radius + Radius);
        }
    }
}
