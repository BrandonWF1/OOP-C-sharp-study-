using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Matrixpractice
{
    public partial class Form1 : Form
    {
        //Создание глобальных объектов
        Matrix A = null;
        Matrix B = null;
        Matrix C = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            //Получаем значения размерности и заполняем матрицы A и B, выводим их на форму.
            int n = Convert.ToInt32(mSize.Value);
            A = new Matrix(n);
            B = new Matrix(n);
            A.set(1);
            B.set(4);
            A.print(mA);
            B.print(mB);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(A!=null&&B!=null)
            {
                C = A + B;
                C.print(mC);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (A != null && B != null)
            {
                C = A - B;
                C.print(mC);
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (A != null && B != null)
            {
                C = A * B;
                C.print(mC);
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (A != null)
            {
                A=Matrix.Reverse(A, 1);
                A.print(mTA);
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (B != null)
            {
                B=Matrix.Reverse(B, -1);
                B.print(mTB);
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            //if (C != null)
            //{
            //    Matrix.Reverse(A, 1);
            //    A.print(mTA);
            //}
        }
    }
}
