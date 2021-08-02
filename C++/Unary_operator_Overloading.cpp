//unary operator overloading
#include<iostream>
using namespace std;
class Base
{
public:
    int a=3,b=3,c;
    
    //prefix 
    void operator ++()
    {
        c=a+b;
    }

    //postfix
    void operator ++(int)
    {
        c=a/b;
    }
    void show()
    {
        cout<<this->c<<endl;
    }
};
int main()
{
    Base b;
    //prefix operator ++a
    ++b;//prefix(++a) 
    
    //postfix operator
    b++;//postfix(a++)
    b.show();
}
