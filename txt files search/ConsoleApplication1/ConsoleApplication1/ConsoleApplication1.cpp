#define _CRT_SECURE_NO_WARNINGS
#include <windows.h>
#include <stdio.h>
#include <string.h>
void main() {
	int x, count = 0, n;
	char string[80];
	FILE* f1, * f2, * f3;
	SetConsoleCP(1251);		// включить кодировку Win1251 при вводе с консоли
	SetConsoleOutputCP(1251);	// включить кодировку Win1251 при выводе на консоль
	f1 = fopen("fileodin.txt", "r");
	if (f1 == NULL) {
		puts("Файл не найден");
		return;
	}
	f2 = fopen("filedva.txt", "r");
	if (f2 == NULL) {
		puts("Файл не найден");
		return;
	}
	f3 = fopen("tri.txt", "r");
	if (f3 == NULL) {
		puts("Файл не найден");
		return;
	}
	n = fscanf(f2, "%d", &x);
	while (feof(f1)) {
		fgets(string, 80, f1);
		count++;
		if (x != count) {
			fputs(string, f3);
		}
		else
		{
			n = fscanf(f2, "%d", &x);
		}
	}
	system("pause");
}

