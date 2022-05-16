using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3FigureVar6Nesterov402
{
    public abstract class FigureEdit
    {
        //Задаем координаты и начальный цвет
        public Color colour = Color.Purple;
        public int x = 0, y= 0;
        public abstract void Draw(PictureBox mainBox);//функция "рисовать"
        public FigureEdit(Color colour1,int x1,int y1)//конструктор
        {
            colour = colour1;
            x = x1;
            y = y1;
        }

    }
    public class Kvadrat : FigureEdit
    {
        public int KvSide = 50;//стандартное значение стороны квадрата
        //прорисовка квадрата
        public override void Draw(PictureBox mainBox)
        {
            Pen kvPen = new Pen(colour, 5f); //Создаем кисть
            Graphics gr = mainBox.CreateGraphics();
            gr.ResetTransform();
            //создадим координаты и перенесем их в центр
            int kvadratX = Convert.ToInt32(mainBox.Width / 2);
            int kvadratY = Convert.ToInt32(mainBox.Height / 2);
            gr.TranslateTransform(kvadratX, kvadratY);
            gr.ScaleTransform(1, -1);//исправляем направление оси Y
            //прорисовка
            gr.DrawLine(kvPen, x - KvSide / 2, y - KvSide / 2, x - KvSide / 2, y + KvSide / 2);
            gr.DrawLine(kvPen, x - KvSide / 2, y + KvSide / 2, x + KvSide / 2, y + KvSide / 2);
            gr.DrawLine(kvPen, x + KvSide / 2, y + KvSide / 2, x + KvSide / 2, y - KvSide / 2);
            gr.DrawLine(kvPen, x + KvSide / 2, y - KvSide / 2, x - KvSide / 2, y - KvSide / 2);
        }
        public void KvChange(Color colour1,int x1, int y1,int KvSide1)
        {
            //проверка стороны на неотрицательность
            if (KvSide >= 0) KvSide = KvSide1;
            colour = colour1;
            x = x1;
            y = y1;
            
        }
        public Kvadrat(Color colour1, int x1, int y1,int KvSide1): base(colour1,x1,y1)//конструктор
        {
            KvSide = KvSide1;
        }

    }
    public class Romb : FigureEdit
    {
        public int RombDiagonal1 = 50;//задаем стандартные значения диагоналей ромба
        public int RombDiagonal2 = 75;
        //прорисовка ромба
        public override void Draw(PictureBox mainBox)
        {
            Pen RombPen = new Pen(colour, 5f); //Создаем кисть
            Graphics gr = mainBox.CreateGraphics();
            gr.ResetTransform();
            //создадим координаты и перенесем их в центр
            int rombX = Convert.ToInt32(mainBox.Width / 2);
            int rombY = Convert.ToInt32(mainBox.Height / 2);
            gr.TranslateTransform(rombX, rombY);
            gr.ScaleTransform(1, -1);//исправляем направление оси Y
            //прорисовка
            gr.DrawLine(RombPen, x, y + RombDiagonal2 / 2, x + RombDiagonal1 / 2, y);
            gr.DrawLine(RombPen, x + RombDiagonal1 / 2, y, x, y - RombDiagonal2 / 2);
            gr.DrawLine(RombPen, x , y  - RombDiagonal2/2, x - RombDiagonal1/2, y );
            gr.DrawLine(RombPen, x  - RombDiagonal1/2, y , x , y  + RombDiagonal2/2);
        }
        public void RombChange(Color colour1, int x1, int y1, int RombDiagonal11,int RombDiagonal22)
        {
            //проверка диагоналей на неотрицательность
            if (RombDiagonal1 >= 0) RombDiagonal1 = RombDiagonal11;
            if (RombDiagonal2 >= 0) RombDiagonal2 = RombDiagonal22;
            colour = colour1;
            x = x1;
            y = y1;
        }
        public Romb(Color colour1, int x1, int y1, int RombDiagonal11, int RombDiagonal22):base(colour1,x1,y1)//конструктор
        {
            RombDiagonal1 = RombDiagonal11;
            RombDiagonal2 = RombDiagonal22;
        }
         

        
    }

    public class Field //класс поля с фигурами
    {
        public int kAmount = 0;//кол-во фигур(квадраты)
        public int rAmount = 0;//кол-во фигур(ромбы)
        //создадим листы для фигур, чтобы внести их в ListBox'ы
        public List<Kvadrat> KvList = null;
        public List<Romb> RombList = null;
        //создадим необходимые функции
        //очистка:
        public void Clearance()
        {
            kAmount = 0;
            rAmount = 0;
            KvList.Clear();
            RombList.Clear();
        }
        //прорисовка(подготовка поля для рисование и создание визуальной системы координат)
        public void Draw(PictureBox mainBox)
        {

            Pen FieldPen = new Pen(Color.Black, 3f); //Создаем кисть
            Graphics gr = mainBox.CreateGraphics();
            gr.Clear(mainBox.BackColor);
            gr.ResetTransform();
            //создадим координаты и перенесем их в центр
            int fieldX = Convert.ToInt32(mainBox.Width / 2);
            int fieldY = Convert.ToInt32(mainBox.Height / 2);
            gr.TranslateTransform(fieldX, fieldY);
            gr.ScaleTransform(1, -1);//исправляем направление оси Y
            //отрисуем визуальную систему координат для удобства
            gr.DrawEllipse(FieldPen, -5f, -5f, 10, 10);
            gr.DrawLine(FieldPen, -fieldX, 0, fieldX, 0);
            gr.DrawLine(FieldPen, 0, -fieldY, 0, fieldY);
            //построим квадраты и ромбы
            foreach(var x in KvList)
            {
                x.Draw(mainBox);
            }
            foreach(var x in RombList)
            {
                x.Draw(mainBox);
            }
        }
        public Field()
        {
            KvList = new List<Kvadrat>();
            RombList = new List<Romb>();
        }

    }
}
