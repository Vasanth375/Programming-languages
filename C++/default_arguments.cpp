//passing object as parameter and returning object
#include<iostream>
#include<string.h>
using namespace std;

class Base
{
public:
    int a;
    
    Base(int x=3,int y=6)//constructor with default arguments
    {
        a=x+y;
    }
    void show(int x=2, int y=9)//function with default arguments
    {
        cout<<x+y;
    }
};

int main()
{
    Base b(1);
    cout<<b.a<<endl;
    b.show(1);
}
