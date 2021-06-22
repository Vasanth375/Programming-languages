#include<iostream>
using namespace std;
class student              /*operator overloading using member functions no parameters*/
{
    public:
        int a;
        int b;
    int operator-();//declaration of - overloading
};
int student::operator-()//- overloading defined here
{
    // int c=a+b;
    // cout<<c;
    return a+b;
}
int main()
{
    student s1;
    s1.a=1;s1.b=2;
    cout<<-s1;//calling - operator overloading 
}
