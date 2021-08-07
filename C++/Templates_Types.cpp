#include<iostream>
#include<string.h>
using namespace std;

template<typename Type>
void Print(Type a) //function template
{
    cout<<a<<endl;
}

template<typename T>
class Base
{
public:
    T show()
    {
        cout<<23<<endl;
        return 0;
    }
};
int main()
{
    //class template
    cout<<"Class template"<<endl;
    Base<int> b;
    b.show();

    //function template
    cout<<"function template"<<endl;
    Print("vasu");
    Print(1);
    Print(1.2);
}
