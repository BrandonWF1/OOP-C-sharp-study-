using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2Nesterov402
{
    class matrix
    {
        public int N { set; get; }
        int[,] array = null;
        public matrix(int n = 2)
        {
            if (n < 2)
                n = 2;
            N = n;
            array = new int[N, N];
        }
        public void set()
        {
            if (array != null)
            {
                int k = 0;
                bool switcher = false;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (switcher == false)
                            array[i, N - j - 1] = ++k;
                        else array[i, j] = ++k;
                    }
                    if (switcher == false) switcher = true;
                    else switcher = false;
                }
            }
        }
        public void set(matrix A, int V)
        {
            if (array != null && V == 1 && A!=null)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        array[i, j] = A.array[i,N-j-1];
                    }
                }
            }
            if (array != null && V == 2 && A!=null)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                        
                    {
                        for (int k = 0; k <= i; k++)
                        {
                                array[i, j] += A.array[k,j];
                        }
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
      

     
    }
}
