#include<iostream>
using namespace std;
class constructor
{
public:
    int data;
    constructor();
     ~constructor();
};

constructor::constructor()
{
    int count=3;
    data =1;
    for (int i = 0; i < count; i++)
    {
        /* code */
        data++;
    }
     cout<<data<<endl;
}
constructor::~constructor()
{//destructor is similar to constructor but one difference is some times constructor be like parameterised but destructor not
//destructor called after constructor 
    data=0;
    cout<<data<<endl;
}
int main()
{
    constructor c;
    cout<<c.data;
}
