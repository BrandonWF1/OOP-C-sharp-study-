using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3__v1
{
    public partial class Form1 : Form
    {
        Plane pl = new Plane(); //Создаем плоскость
        public Form1()
        {
            InitializeComponent();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            pl.Clear();                     //Вызываем очистку плоскости
            RhomblistBox.Items.Clear();     //Очищаем список ромбов на форме
            SquarelistBox.Items.Clear();    //Очищаем список квадратов на форме
            pl.Draw(pictureBox1);           //Отрисовываем плоскость
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //Перерисовываем форму при изменении размера окна
           
            //Используем таймер для задержки в 5 миллисекунд
            //чтобы правильно отрисовать плоскость после разворачивания окна на весь экран
            timer1.Start(); //Запускаем таймер
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pl.Draw(pictureBox1);   //Отрисовываем плоскость
            timer1.Stop();          //Останавливаем таймер
        }

        private void RhombShowButton_Click(object sender, EventArgs e)
        {
            if (RhomblistBox.SelectedItem != null)  //Если выбран какой-нибудь элемент
            {
                //Получаем индекс ромба из строкой с названием
                int index = Convert.ToInt32(RhomblistBox.SelectedItem.ToString().Substring(5)) - 1;

                //Изменяем значения NumericUpDown на значения выбранного ромба из массива
                RhombR.Value = pl.rhomblist[index].color.R;
                RhombG.Value = pl.rhomblist[index].color.G;
                RhombB.Value = pl.rhomblist[index].color.B;
                RhombX.Value = pl.rhomblist[index].x;
                RhombY.Value = pl.rhomblist[index].y;
                RhombDiag1.Value = pl.rhomblist[index].D1;
                RhombDiag2.Value = pl.rhomblist[index].D2;
            }
        }

        private void RhombChangeButton_Click(object sender, EventArgs e)
        {
            if (RhomblistBox.SelectedItem != null) //Если выбран какой-нибудь элемент
            {
                //Получаем индекс ромба из строкой с названием
                int index = Convert.ToInt32(RhomblistBox.SelectedItem.ToString().Substring(5)) - 1;

                //Значения из NumericUpDown
                int r = (int)RhombR.Value;
                int g = (int)RhombG.Value;
                int b = (int)RhombB.Value;
                int x = (int)RhombX.Value;
                int y = (int)RhombY.Value;
                int diag1 = (int)RhombDiag1.Value;
                int diag2 = (int)RhombDiag2.Value;

                //Вызываем функцию замены значений в выбранном ромбе из массива
                pl.rhomblist[index].Change(Color.FromArgb(r, g, b), x, y, diag1, diag2);

                //Отрисовываем плоскость после замены значений
                pl.Draw(pictureBox1);
            }
        }

        private void RhombDeleteButton_Click(object sender, EventArgs e)
        {
            if (RhomblistBox.SelectedItem != null) //Если выбран какой-нибудь элемент
            {
                //Получаем индекс ромба из строкой с названием
                int index = Convert.ToInt32(RhomblistBox.SelectedItem.ToString().Substring(5)) - 1;

                //Удаляем выбранный ромб из массива
                pl.rhomblist.RemoveAt(index);
                //Уменьшаем количество ромбов в массиве на 1
                pl.rhombN -= 1;
                //Удаляем ромб из списка на форме
                RhomblistBox.Items.RemoveAt(pl.rhombN);
                //Отрисовываем плоскость
                pl.Draw(pictureBox1);
            }
        }

        private void RhombDraw_Click(object sender, EventArgs e)
        {
            //Создаем новый ромб со значениями из соответствующих элементов NumericUpDown
            Rhomb A = new Rhomb(Color.FromArgb((int)RhombR.Value, (int)RhombG.Value, (int)RhombB.Value), (int)RhombX.Value, (int)RhombY.Value, (int)RhombDiag1.Value, (int)RhombDiag2.Value);
            //Добавляем ромб в массив
            pl.rhomblist.Add(A);
            //Увеличиваем количество ромбов в массиве
            pl.rhombN += 1;
            //Добавляем ромб в список на форме
            RhomblistBox.Items.Add($"Ромб {pl.rhombN}");
            //Отрисовываем плоскость
            pl.Draw(pictureBox1);
        }

        private void SquareDraw_Click(object sender, EventArgs e)
        {
            //Создаем новый квадрат со значениями из соответствующих элементов NumericUpDown
            Square A = new Square(Color.FromArgb((int)SquareR.Value, (int)SquareG.Value, (int)SquareB.Value), (int)SquareX.Value, (int)SquareY.Value, (int)SquareSide.Value);
            //Добавляем квадрат в массив
            pl.squarelist.Add(A);
            //Увеличиваем количество квадратов в массиве
            pl.squareN += 1;
            //Добавляем квадрат в список на форме
            SquarelistBox.Items.Add($"Квадрат {pl.squareN}");
            //Отрисовываем плоскость
            pl.Draw(pictureBox1);
        }

        private void SquareShowButton_Click(object sender, EventArgs e)
        {
            if (SquarelistBox.SelectedItem != null) //Если выбран какой-нибудь элемент
            {
                //Получаем индекс квадрата из строкой с названием
                int index = Convert.ToInt32(SquarelistBox.SelectedItem.ToString().Substring(8)) - 1;

                //Изменяем значения NumericUpDown на значения выбранного квадрата из массива
                SquareR.Value = pl.squarelist[index].color.R;
                SquareG.Value = pl.squarelist[index].color.G;
                SquareB.Value = pl.squarelist[index].color.B;
                SquareX.Value = pl.squarelist[index].x;
                SquareY.Value = pl.squarelist[index].y;
                SquareSide.Value = pl.squarelist[index].Side;
            }
        }

        private void SquareChangeButton_Click(object sender, EventArgs e)
        {
            if (SquarelistBox.SelectedItem != null) //Если выбран какой-нибудь элемент
            {
                //Получаем индекс квадрата из строкой с названием
                int index = Convert.ToInt32(SquarelistBox.SelectedItem.ToString().Substring(8)) - 1;

                //Значения из NumericUpDown
                int r = (int)SquareR.Value;
                int g = (int)SquareG.Value;
                int b = (int)SquareB.Value;
                int x = (int)SquareX.Value;
                int y = (int)SquareY.Value;
                int side = (int)SquareSide.Value;

                //Вызываем функцию замены значений в выбранном квадрате из массива
                pl.squarelist[index].Change(Color.FromArgb(r, g, b), x, y, side);
                //Отрисовываем плоскость после замены значений
                pl.Draw(pictureBox1);
            }
        }

        private void SquareDeleteButton_Click(object sender, EventArgs e)
        {
            if (SquarelistBox.SelectedItem != null) //Если выбран какой-нибудь элемент
            {
                //Получаем индекс квадрата из строкой с названием
                int index = Convert.ToInt32(SquarelistBox.SelectedItem.ToString().Substring(8)) - 1;

                //Удаляем выбранный квадрат из массива
                pl.squarelist.RemoveAt(index); 
                //Уменьшаем количество квадратов в массиве на 1
                pl.squareN -= 1;
                //Удаляем квадрат из списка на форме
                SquarelistBox.Items.RemoveAt(pl.squareN);
                //Отрисовываем плоскость
                pl.Draw(pictureBox1);
            }
        }
    }
}
