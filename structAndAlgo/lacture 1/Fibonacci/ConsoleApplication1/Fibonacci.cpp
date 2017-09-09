// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "conio.h"
#include <iostream>
using namespace std;

double getFibanacciNumV1(int n);
double getFibanacciNumV2(int n);
double getFibanacciNumV3(int n);
double cache[100] = { 0,1 };
int countIteration = 0;

int main()
{

	cout << countIteration <<" " << getFibanacciNumV1(30)<<endl;//наивное рекурсивное решение
	countIteration = 0;
	cout << countIteration <<" " << getFibanacciNumV2(30)<<endl;//кеширование результатов
	countIteration = 0;
	cout << countIteration << " " << getFibanacciNumV3(30) << endl;//без рекурсии и кеширования
	_getch();
    return 0;
}
double getFibanacciNumV1(int n) {//наивное рекурсивное решение
	countIteration++;
	if (n == 0)return 0;
	if (n == 1)return 1;
	return getFibanacciNumV1(n - 1) + getFibanacciNumV1(n - 2);
}
double getFibanacciNumV2(int n) {//кеширование результатов
	countIteration++;
	if ((cache[n]==0)&&(n>1)) {
		cache[n]=getFibanacciNumV2(n - 1) + getFibanacciNumV2(n - 2);
	}
	return cache[n];
}
double getFibanacciNumV3(int n) {//без рекурсии и кеширования
	int prev1 = 0,prev2 = 1,curr;
	if (n == 0)return 0;
	for (int i = 2; i <n; i++) {
		countIteration++;
		curr = prev1 + prev2;
		prev1 = prev2;
		prev2 = curr;
	}
	return prev1+prev2;
}