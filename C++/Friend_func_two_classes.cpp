#include<iostream>
#include<string.h>
using namespace std;
class Derived;
class Base
{
    private:
        int a;
        int b;
    public:
        void show()
        {
            a=2;
            b=4;
        }
        friend int add(Base,Derived);
};

class Derived
{
    private:
        int a;
        int b;
    public:
        void show()
        {
            a=4;
            b=4;
        }
        friend int add(Base,Derived);
};


int add(Base bas,Derived de)
{
    int c=bas.a+bas.b;
    int z=de.a+de.b;
    return c+z;
}

int main()
{
    Base base;
    base.show();

    Derived der;
    der.show();
    cout<<endl <<add(base,der);
}
