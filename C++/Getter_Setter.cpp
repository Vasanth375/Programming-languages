#include<iostream>
#include<string.h>
using namespace std;

class Base
{
private:
    int a;
public:
    int Get_a()
    {
        return a;
    }
    void Set_a(int x)
    {
        a=x;
    }
    //in this situation Get_a and Set_a is perform as get and set method
};

inline int add(int a, int b)
{
    return a>b?a:b;
}

int main()
{
   cout<<"the greater then value "<<add(1,2);
   Base b;
   cout<<"\nSetter routine is to set value setting \n";
   b.Set_a(1);
   cout<<"Getter for getting the value "<<b.Get_a();
}
