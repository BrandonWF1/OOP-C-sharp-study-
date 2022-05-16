using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3__v1
{
    //Класс плоскости
    public class Plane
    {
        public List<Rhomb> rhomblist = null;    //Массив ромбов
        public int rhombN = 0;                  //Количество ромбов
        public List<Square> squarelist = null;  //Массив квадратов
        public int squareN = 0;                 //Количество квадратов
        //Конструктор
        public Plane()
        {
            rhomblist = new List<Rhomb>();
            squarelist = new List<Square>();
        }
        //Очистка плоскости
        public void Clear()
        {
            rhomblist.Clear();  //Очищаем массив ромбов
            rhombN = 0;         //Обнуляем количество ромбов
            squarelist.Clear(); //То же самое для квадратов
            squareN = 0;
        }
        //Отрисовка плоскости
        public void Draw(PictureBox box)
        {
            int midX = (int)(box.Width / 2);    //Координата X центра picturebox
            int midY = (int)(box.Height / 2);   //Координата Y центра picturebox

            Pen pen1 = new Pen(Color.Black, 2.5f);
            Graphics gr = box.CreateGraphics();

            gr.Clear(box.BackColor); //Очищаем picturebox
            gr.ResetTransform();
            
            //Переносим начало координат в центр pictureBox
            gr.TranslateTransform(midX, midY);
            
            //Разворачиваем ось Y вниз
            gr.ScaleTransform(1, -1);
            
            //Рисуем точку по центру и оси координат
            gr.DrawEllipse(pen1, -2.5f, -2.5f, 5, 5);
            gr.DrawLine(pen1, -midX, 0, midX, 0);
            gr.DrawLine(pen1, 0, -midY, 0, midY);

            //Рисуем все ромбы из массива
            foreach (var x in rhomblist)
            {
                x.Draw(box);
            }
            //Рисуем все квадраты из массива
            foreach (var x in squarelist)
            {
                x.Draw(box);
            }
        }
    }

    //Абстрактный класс фигуры
    public abstract class Shape
    {
        //Координаты
        public int x = 0;
        public int y = 0;
        //Цвет
        public Color color = Color.Black;

        //Функция для рисования
        public abstract void Draw(PictureBox box);

        //Конструктор
        public Shape (Color color, int x, int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
        }
    }

    //Класс ромба
    public class Rhomb : Shape
    {
        int d1 = 10;    //Первая диагональ
        int d2 = 30;    //Вторая диагональ
        public int D1 { get { return d1; } }
        public int D2 { get { return d2; } }

        //Конструктор
        public Rhomb(Color c, int x, int y, int d1, int d2) : base(c, x, y)
        {
            this.d1 = d1;
            this.d2 = d2;
        }

        //Функция для изменения значений на новые
        public void Change(Color color, int x, int y, int d1, int d2)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            if (d1 >= 0)    //Диагонали должны быть больше 0
                this.d1 = d1;
            if (d2 >= 0)
                this.d2 = d2;
        }

        //Функция для отрисовки ромба
        public override void Draw(PictureBox box)
        {
            int midX = (int)(box.Width / 2);    //Координата X центра picturebox
            int midY = (int)(box.Height / 2);   //Координата Y центра picturebox

            Pen pen1 = new Pen(color, 2.5f);    //Берём цвет для карандаша из color

            Graphics gr = box.CreateGraphics();
            gr.ResetTransform();

            //Переносим начало координат в центр pictureBox
            gr.TranslateTransform(midX, midY);

            //Разворачиваем ось Y вниз
            gr.ScaleTransform(1, -1);

            //Рисуем ромб с помощью четырех линий между углами
            gr.DrawLine(pen1, x * 2, y * 2 + d2, x * 2 + d1, y * 2);
            gr.DrawLine(pen1, x * 2 + d1, y * 2, x * 2, y * 2 - d2);
            gr.DrawLine(pen1, x * 2, y * 2 - d2, x * 2 - d1, y * 2);
            gr.DrawLine(pen1, x * 2 - d1, y * 2, x * 2, y * 2 + d2);
        }
    }

    //Класс квадрата
    public class Square : Shape
    {
        int side = 20;  //Сторона квадрата
        public int Side { get { return side; } }

        //Функция для отрисовки квадрата
        public override void Draw(PictureBox box)
        {
            int midX = (int)(box.Width / 2);    //Координата X центра picturebox
            int midY = (int)(box.Height / 2);   //Координата Y центра picturebox

            Pen pen1 = new Pen(color, 2.5f);    //Берём цвет для карандаша из color

            Graphics gr = box.CreateGraphics();
            gr.ResetTransform();

            //Переносим начало координат в центр pictureBox
            gr.TranslateTransform(midX, midY);

            //Разворачиваем ось Y вверх
            gr.ScaleTransform(1, -1);

            //Рисуем квадрат с помощью четырех линий между углами
            gr.DrawLine(pen1, x * 2 - side, y * 2 - side, x * 2 - side, y * 2 + side);
            gr.DrawLine(pen1, x * 2 - side, y * 2 + side, x * 2 + side, y * 2 + side);
            gr.DrawLine(pen1, x * 2 + side, y * 2 + side, x * 2 + side, y * 2 - side);
            gr.DrawLine(pen1, x * 2 + side, y * 2 - side, x * 2 - side, y * 2 - side);
        }

        //Функция для изменения значений на новые
        public void Change(Color color, int x, int y, int side)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            if (side >= 0)  //Сторона квадрата не может быть меньше 0
                this.side = side;
        }

        //Констуктор
        public Square(Color color, int x, int y, int side) :base(color,x,y)
        {
            this.side = side;
        }
    }
}
    