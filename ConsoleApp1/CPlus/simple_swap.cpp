#include <iostream>
using namespace std;

class A
{
public:
	int x;
	int getX() { return x; }
};

void swap(A &a, A &b
	// �ڴ˴�������Ĵ���
)
{
	int  tmp = a.x;
	a.x = b.x;
	b.x = tmp;
}
int simply_swap()
{
	A a, b;
	a.x = 3;
	b.x = 5;
	swap(a, b);
	cout << a.getX() << "," << b.getX();
	return 0;
}