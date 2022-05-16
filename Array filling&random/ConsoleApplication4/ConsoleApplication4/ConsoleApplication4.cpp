#include <stdio.h> // библиотека ввода вывода
#include <math.h> // мат функции
#include <locale.h> // рус шрифт
#include <time.h> // генерация
#include <stdlib.h> // случайные числа
int random(int a, int b)
{
	return (rand() % (b - a + 1) + a);
}
void inputRandom(int* a, int N)
{
	int i;
	for (i = 0; i < N; i++)
		a[i] = random(-50,50);
}
void input_mas(int a[], int N)
{
	int i;
	for (i = 0; i < N; i++)
	{
		printf("a[%d]= ", i);
		scanf_s("%d", &a[i]);
	}
}
void output_mas(int *a, int N)
{
	int i;
	for (i = 0; i < N; i++)
		printf("%4d", a[i]);
	printf("\n");
}
int main()
{
	int N,i,dir,k;
	int *a,*b;
	k = 0;
	setlocale(LC_ALL, "russian");
	srand(clock());
	do
	{
		printf("Введите размерность массива: ");
		scanf_s("%d", &N);
	} while (N <= 0);
	a = (int*)malloc(N * sizeof(int));
	printf("Для ввода с клавиатуры введите цифру отличную от нуля, иначе массив заполнится случайным образом \n");
	scanf_s("%d", &dir);
	if (dir)
		input_mas(a, N);
	else inputRandom(a, N);
	printf("Исходный массив:\n");
	output_mas(a, N);
	for (i = 0; i < N-1; i++)
	{	

		if (a[i] == a[i + 1])
			k++;

	}
	b = (int*)malloc((N-k) * sizeof(int));
	k = 0;
	for (i = 0; i < N; i++)
	{
		if (a[i] != a[i + 1])
		{
			b[k] = a[i];
			k++;
		}
	}
	printf("Новый массив: \n");
	output_mas(b, k);
	getchar(); getchar();
} 