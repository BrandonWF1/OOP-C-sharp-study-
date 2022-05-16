#include <stdio.h>
#include <math.h>
#include <locale.h>
#include <stdlib.h>
#include <time.h>


int random(int a, int b)
{
    return (rand() % (b - a + 1) + a);
}
void input_random(int** a, int n, int m)
{
    int i, j;
    for (i = 0; i < n; i++)
        for (j = 0; j < m; j++)
            a[i][j] = random(-50, 50);
}
void input_mas(int** a, int n, int m)
{
    int    i, j;
    for (i = 0; i < n; i++)
        for (j = 0; j < m; j++)
        {
            printf("a[%d][%d]=", i, j);
            scanf_s("%d", &a[i][j]);
        }
}
void output_mas(int** a, int n, int m)
{
    int i, j;
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < m; j++)
            printf("%5d", a[i][j]);
        printf("\n");
    }
}


int main()
{
    int i, N, M, dir, j;
    int** a;
    int min1, min2, min3, min4,mid;
    setlocale(LC_ALL, "rus");
    srand(clock());
    do
    {
        printf("Введите размерность квадратичного массива A[i][j]: ");
        scanf_s("%d%d", &N, &M);
    } while (N <= 0 || M <= 0 || N!=M);
    a = (int**)malloc(N * sizeof(int));
    for (i = 0; i < N; i++)
        a[i] = (int*)malloc(M * sizeof(int));
    printf("Для ввода с клавиатуры введите любую цифру, отличную от нуля, иначе массив заполнится случайно: \n");
    scanf_s("%d", &dir);
    if (dir)
    {
        input_mas(a, N, M);
    }
    else
        input_random(a, N, M);
    printf("Исходный массив:\n");
    output_mas(a, N, M);
    mid = (N - 1) / 2 + 1;
    min1 = a[0][0];
    for (i = 0; i <= N - 1; i++)
    {
        for (j = 0; j <= N - i - 1; j++)
        {
            if (a[i][j] < min1)
                min1 = a[i][j];
        }
    }
    printf("Минимальное число на первой области: %d\n", min1);
    min2 = a[0][0];
    for (i = N - 1; i >= mid; i--)
    {
        for (j = i; j >= N - 1 - i; j--)
        {
            if (a[i][j] < min2)
                min2 = a[i][j];
        }
    }
    printf("Минимальное число на второй области: %d\n", min2);
    min3 = a[0][0];
    for (i = 0; i <= mid; i++)
    {
        for (j = i; j <= N - 1 - i; j++)
        {
            if (a[i][j] < min3)
                min3 = a[i][j];
        }
    }
    printf("Минимальное число на третьей области: %d\n", min3);
    min4 = a[0][0];
    for (i = N - 1; i >= 0; i--)
    {
        for (j = N - 1; j >= N - 1 - i; j--)
        {
            if (a[i][j] < min4)
                min4 = a[i][j];
        }
    }
    printf("Минимальное число на четвертой области: %d\n", min4);

    getchar(); getchar();
}