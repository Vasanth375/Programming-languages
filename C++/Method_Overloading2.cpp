#include<iostream>
#include<string.h>
using namespace std;

int show(int a)
{
    return a;
}

string show(string n)
{
    string hi="Hi ";
    return (hi + n);
}

float show(float a,float b)
{
    return a+b;
}

int main()
{
    cout<<show("vasanth")<<endl;
    cout<<show(1)<<endl;
    cout<<show(1.2,2.3);
}
