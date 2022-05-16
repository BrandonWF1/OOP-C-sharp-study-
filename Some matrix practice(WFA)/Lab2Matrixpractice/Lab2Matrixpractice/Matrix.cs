using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Matrixpractice
{
    public class Matrix
    {
        public int N { set; get; }
        int[,] array = null;
        public Matrix(int n = 2)
        {
            if (n < 2)
                n = 2;
            N = n;
            array = new int[N, N];
        }
        public void set(int min, int max)
        {
            if (array != null)
            {
                Random R = new Random();
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        array[i, j] = R.Next(min, max);
                    }
                }
            }
        }
        public void set(int V = 1)
        {
            if (array != null && V == 1)
            {
                Random R = new Random();
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        array[i, j] = N - i;
                    }
                }
            }
            if (array != null && V == 4)
            {
                Random R = new Random();
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (i < j)
                            array[i, j] = 0;
                        else
                            array[i, j] = N - i + j;
                    }
                }
            }

        }
        //Вывод матрицы на форму
        public void print(DataGridView T)
        {
            if (array != null)
            {
                //Настраиваем таблицу под вывод матрицы: задаем количество строк и столбцов в таблице
                T.RowCount = T.ColumnCount = N;
                //Выводим в определенную ячейку таблицы элемент матрицы
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        T.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
                //Настраиваем ширину строк и столбцов под содержимое ячеек
                T.AutoResizeColumns();
                T.AutoResizeRows();
            }
        }
        //Перегрузка операторов для работы с матрицей
        public static Matrix operator +(Matrix A, Matrix B)
        {
            if (A.N == B.N && A != null && B != null)
            {
                Matrix C = new Matrix(A.N);
                for (int i = 0; i < C.N; i++)
                {
                    for (int j = 0; j < C.N; j++)
                    {
                        C.array[i, j] = A.array[i, j] + B.array[i, j];
                    }
                }
                return C;
            }
            else
            {
                Matrix C = new Matrix(2);
                C.set(0, 0);
                return C;
            }

        }
        public static Matrix operator -(Matrix A, Matrix B)
        {
            if (A.N == B.N && A != null && B != null)
            {
                Matrix C = new Matrix(A.N);
                for (int i = 0; i < C.N; i++)
                {
                    for (int j = 0; j < C.N; j++)
                    {
                        C.array[i, j] = A.array[i, j] - B.array[i, j];
                    }
                }
                return C;
            }
            else
            {
                Matrix C = new Matrix(2);
                C.set(0, 0);
                return C;
            }
        }
        public static Matrix operator *(Matrix A, Matrix B)
        {
            if (A.N == B.N && A != null && B != null)
            {
                Matrix C = new Matrix(A.N);
                for (int i = 0; i < C.N; i++)
                {
                    for (int j = 0; j < C.N; j++)
                    {
                        C.array[i, j] = 0;
                        for (int k = 0; k < C.N; k++)
                        {
                            C.array[i, j] += A.array[i, k] * B.array[k, j];
                        }
                    }
                }
                return C;
            }
            else
            {
                Matrix C = new Matrix(2);
                C.set(0, 0);
                return C;
            }

        }

        //Реверс элементов матрицы
        public static Matrix Reverse(Matrix A, int v = 1)
        {
            if (A != null && v == 1)
            {
                Matrix C = new Matrix(A.N);
                for (int i = 0; i < C.N; i++)
                {
                    for (int j = 0; j < C.N; j++)
                    {
                        C.array[i, j] = A.array[A.N - i - 1, j];
                    }
                }
                return C;
            }
            if (A != null && v == -1)
            {
                Matrix C = new Matrix(A.N);
                for (int i = 0; i < C.N; i++)
                {
                    for (int j = 0; j < C.N; j++)
                    {
                        C.array[i, j] = A.array[i, A.N - j - 1];
                    }
                }
                return C;
            }
            else
                return A;
        }
    }
}
