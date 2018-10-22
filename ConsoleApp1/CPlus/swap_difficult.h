#pragma once
#include <iostream>
using namespace std;

void swap(int *&a, int *&b)
// 在此处补充你的代码
{
	cout << "swap " << a << " " << b << endl;
	//printf("swap %x %x \n", a, b);
	int * tmp = a;
	a = b;
	b = tmp;
	cout << "swap " << a << " " << b << endl;
	//printf("swap %x %x \n", a, b);
}
void swap_difficult()
{
	int a = 3, b = 5;
	int * pa = &a;
	int * pb = &b;

	cout << "main "<<pa << " " << pb << endl;
	//printf("main %x %x \n", pa, pb);
	swap(pa, pb);
	cout << "main " << pa << " " << pb << endl;
	//printf("main %x %x \n", pa, pb);
	cout << *pa << "," << *pb;
}
