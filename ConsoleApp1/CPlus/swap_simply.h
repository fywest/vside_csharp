#pragma once
#include<iostream>
class A
{
public:
	int x;
	int getX() { return x; }
};

void swap(A &a, A &b
	// 在此处补充你的代码
)
{
	int  tmp = a.x;
	a.x = b.x;
	b.x = tmp;
}
void simply_swap()
{
	A a, b;
	a.x = 3;
	b.x = 5;
	swap(a, b);
	std::cout << a.getX() << "," << b.getX();
}
