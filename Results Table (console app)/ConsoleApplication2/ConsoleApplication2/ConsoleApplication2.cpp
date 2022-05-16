#include <iostream>
#include <stdio.h> // библиотека ввода вывода
#include <math.h> // мат функции
#include <locale.h> // рус шрифт
void inputData(int* z1, int* z2, int* t1, int* t2, int n)
{
	do {
		printf("Введите результаты %d студента за два задания и за два теста: ", n);
		scanf_s("%d%d%d%d", &*z1, &*z2, &*t1, &*t2);
	} while (*z1 < 0 || *z1>5 || *z2 < 0 || *z2>5 || *t1 < 0 || *t1>100 || *t2 < 0 || *t2>100);
}
float average(float a, float b, float c)
{
	return (a + b + c) / 3;
}
float average2(float a, float b)
{
	return (a + b) / 2;
}
int calculateTestMark(int a, int b)
{
	int c;
	if (a > b) c = a;
	else c = b;
	if (c < 50) return 2;
	if (c >= 50 && c < 70) return 3;
	if (c >= 70 && c < 90) return 4;
	if (c >= 90 && c <= 100) return 5;
}
float calculateLabMark(int a, int b)
{
	return average2(a, b);
}
void printTable(int z11, int z21, int t11, int t21, int z12, int z22, int t12, int t22, int z13, int z23, int t13, int t23, float lab1, float lab2, float lab3, int test1, int test2,
	int test3, float total1, float total2, float total3, float az1, float az2, float at1, float at2, float alab, float atest, float atotal)
{
	printf("№      Зад.1  Зад.2  Тест 1  Тест 2  Лаб.Раб.  Тест  Тема\n");
	printf("%d%10d%7d%8d%8d%10.0f%6d%6.0f\n", 1, z11, z21, t11, t21, lab1, test1, total1);
	printf("%d%10d%7d%8d%8d%10.0f%6d%6.0f\n", 2, z12, z22, t12, t22, lab2, test2, total2);
	printf("%d%10d%7d%8d%8d%10.0f%6d%6.0f\n", 2, z13, z23, t13, t23, lab3, test3, total3);
	printf("Среднее%4.1f%7.1f%8.0f%8.0f%10.1f%6.1f%6.0f\n", az1, az2, at1, at2, alab, atest, atotal);
}
int main()
{
	int z11, z21, t11, t21;
	int z12, z22, t12, t22;
	int z13, z23, t13, t23;
	float lab1, lab2, lab3;
	int test1, test2, test3;
	float total1, total2, total3;
	float az1, az2, at1, at2, alab, atest, atotal;
	setlocale(LC_ALL, "russian");
	inputData(&z11, &z21, &t11, &t21, 1);
	inputData(&z12, &z22, &t12, &t22, 2);
	inputData(&z13, &z23, &t13, &t23, 3);
	lab1 = calculateLabMark(z11, z21);
	lab2 = calculateLabMark(z12, z22);
	lab3 = calculateLabMark(z13, z23);
	test1 = calculateTestMark(t11, t21);
	test2 = calculateTestMark(t12, t22);
	test3 = calculateTestMark(t13, t23);
	total1 = average2(lab1, test1);
	total2 = average2(lab2, test2);
	total3 = average2(lab3, test3);
	az1 = average(z11, z12, z13);
	az2 = average(z21, z22, z23);
	at1 = average(t11, t12, t13);
	at2 = average(t21, t22, t23);
	alab = average(lab1, lab2, lab3);
	atest = average(test1, test2, test3);
	atotal = average(total1, total2, total3);
	printTable(z11, z21, t11, t21, z12, z22, t12, t22, z13, z23, t13, t23, lab1, lab2, lab3, test1, test2,
		test3, total1, total2, total3, az1, az2, at1, at2, alab, atest, atotal);
	getchar(); getchar();
}
