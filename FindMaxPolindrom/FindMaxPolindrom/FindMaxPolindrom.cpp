// FindMaxPolindrom.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;
int findMaxPolindromFromProduct2Num(int firstNumber, int secondNumber);
bool isPolindrom(int num);
int countPolindroms = 0;
int main()
{
	cout<<findMaxPolindromFromProduct2Num(999, 999);
	system("pause");
    return 0;
}
int findMaxPolindromFromProduct2Num(int firstNumber, int secondNumber) {
	int max = 0, temp, count = 0;
	for (int i = firstNumber; i > 0; i--) {
		for (int j = secondNumber; j > 0; j--) {
			temp = i*j;
			count++;
			if (temp < max) {
				j = 0; //break reference loop
				continue;
			}
			if (isPolindrom(temp)){	
				max = temp;
			}
		}
	}
	cout << "Count iteration= " << count << endl;
	cout << "Count polindroms= " << countPolindroms << endl;
	return max;
}
bool isPolindrom(int num) {
	countPolindroms++;
	string temp;
	temp = to_string(num);
	unsigned int size = temp.size();
	for (unsigned int i = 0; i < size / 2; i++) {
		if (temp[i] != temp[(size - 1) - i]) {
			return false;
		}
	}
	return true;
}
