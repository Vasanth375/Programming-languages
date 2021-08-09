//passing object as parameter and returning object
#include<iostream>
#include<string.h>
using namespace std;

class Base
{
public:
    string name;
};

Base show(Base b)
{
    Base temp;
    string mess="Hi ";
    temp.name=mess+b.name;
    return temp;
}

int main()
{
    Base b,result;
    b.name="Vasanth";
    result=show(b);
    cout<<result.name;
}
