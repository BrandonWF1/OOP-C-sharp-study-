using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3FigureVar6Nesterov402
{
    public partial class Form1 : Form
    {
        public Field field = new Field();//новое поле для рисования

        public Form1()
        {
            InitializeComponent();
        }

        private void KvDrawButton_Click(object sender, EventArgs e)
        {
            //создадим квадрат с введеными данными 
            Kvadrat A = new Kvadrat(Color.FromArgb(Convert.ToInt32(KvRNumUpDown.Value),
                Convert.ToInt32(KvGNumUpDown.Value), Convert.ToInt32(KvBNumUpDown.Value)),
                Convert.ToInt32(KvX.Value), Convert.ToInt32(KvY.Value), Convert.ToInt32(KvLenght.Value));
            //добавляем квадрат
            field.KvList.Add(A);
            field.kAmount += 1;
            KvListBox.Items.Add($"Квадрат №{field.kAmount}");//добавляем фигуру в лист бокс
            field.Draw(MainPictureBox);//прорисовка
        }

        private void KvDelete_Click(object sender, EventArgs e)
        {
            if (KvListBox.SelectedItem != null)
            {

                int n = Convert.ToInt32(KvListBox.SelectedItem.ToString().Substring(9)) - 1; //найдем номер квадрата
                //удаляем квадрат
                field.KvList.RemoveAt(n);
                field.kAmount -= 1;
                KvListBox.Items.RemoveAt(field.kAmount);//удаляем фигуру из листбокса
                field.Draw(MainPictureBox);//прорисовка
            }
        }

        private void KvChange_Click(object sender, EventArgs e)
        {
            if (KvListBox.SelectedItem != null)
            {
                int n = Convert.ToInt32(KvListBox.SelectedItem.ToString().Substring(9)) - 1; //найдем номер квадрата
                //значения RGB и X Y
                int r = Convert.ToInt32(KvRNumUpDown.Value);
                int g = Convert.ToInt32(KvGNumUpDown.Value);
                int b = Convert.ToInt32(KvBNumUpDown.Value);
                int x = Convert.ToInt32(KvX.Value);
                int y = Convert.ToInt32(KvY.Value);
                int lenght = Convert.ToInt32(KvLenght.Value);
                field.KvList[n].KvChange(Color.FromArgb(r, g, b), x, y, lenght);//заменяем значения
                field.Draw(MainPictureBox);//прорисовка
            }
        }

        private void KvShow_Click(object sender, EventArgs e)
        {
            if (KvListBox.SelectedItem != null)
            {
                int n = Convert.ToInt32(KvListBox.SelectedItem.ToString().Substring(9)) - 1; //найдем номер квадрата
                //выводим значения выбраного квадрата
                KvRNumUpDown.Value = field.KvList[n].colour.R;
                KvGNumUpDown.Value = field.KvList[n].colour.G;
                KvBNumUpDown.Value = field.KvList[n].colour.B;
                KvX.Value = field.KvList[n].x;
                KvY.Value = field.KvList[n].y;
                KvLenght.Value = field.KvList[n].KvSide;
            }
        }

        private void RombDrawButton_Click(object sender, EventArgs e)
        {
            //создадим ромб с введеными данными 
            Romb A = new Romb(Color.FromArgb(Convert.ToInt32(RombRNumUpDown.Value),
                Convert.ToInt32(RombGNumUpDown.Value), Convert.ToInt32(RombBNumUpDown.Value)),
                Convert.ToInt32(RombX.Value), Convert.ToInt32(RombY.Value), Convert.ToInt32(RombDiagonal1.Value),
                Convert.ToInt32(RombDiagonal2.Value));
            //добавляем ромб
            field.RombList.Add(A);
            field.rAmount += 1;
            RombListBox.Items.Add($"Ромб №{field.rAmount}");//добавляем фигуру в лист бокс
            field.Draw(MainPictureBox);//прорисовка
        }

        private void RombDelete_Click(object sender, EventArgs e)
        {
            if (RombListBox.SelectedItem != null)
            {

                int n = Convert.ToInt32(RombListBox.SelectedItem.ToString().Substring(6)) - 1; //найдем номер ромба
                //удаляем ромб
                field.RombList.RemoveAt(n);
                field.rAmount -= 1;
                RombListBox.Items.RemoveAt(field.rAmount);//удаляем фигуру из листбокса
                field.Draw(MainPictureBox);//прорисовка
            }
        }

        private void RombChange_Click(object sender, EventArgs e)
        {
            if (RombListBox.SelectedItem != null)
            {
                int n = Convert.ToInt32(RombListBox.SelectedItem.ToString().Substring(6)) - 1; //найдем номер ромба
                //значения RGB и X Y
                int r = Convert.ToInt32(RombRNumUpDown.Value);
                int g = Convert.ToInt32(RombGNumUpDown.Value);
                int b = Convert.ToInt32(RombBNumUpDown.Value);
                int x = Convert.ToInt32(RombX.Value);
                int y = Convert.ToInt32(RombY.Value);
                int d1 = Convert.ToInt32(RombDiagonal1.Value);
                int d2 = Convert.ToInt32(RombDiagonal2.Value);
                field.RombList[n].RombChange(Color.FromArgb(r, g, b), x, y, d1,d2);//заменяем значения
                field.Draw(MainPictureBox);//прорисовка
            }
        }

        private void RombShow_Click(object sender, EventArgs e)
        {
            if (RombListBox.SelectedItem != null)
            {
                int n = Convert.ToInt32(KvListBox.SelectedItem.ToString().Substring(6)) - 1; //найдем номер ромба
                //выводим значения выбранного ромба
                RombRNumUpDown.Value = field.RombList[n].colour.R;
                RombGNumUpDown.Value = field.RombList[n].colour.G;
                RombBNumUpDown.Value = field.RombList[n].colour.B;
                RombX.Value = field.RombList[n].x;
                RombY.Value = field.RombList[n].y;
                RombDiagonal1.Value = field.RombList[n].RombDiagonal1;
                RombDiagonal2.Value = field.RombList[n].RombDiagonal2;

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {   //очищаем листбоксы, поле и выводим новую систему координат
            KvListBox.Items.Clear();
            RombListBox.Items.Clear();
            field.Clearance();
            field.Draw(MainPictureBox);

        }
    }
}
