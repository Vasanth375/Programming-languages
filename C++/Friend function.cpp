#include <iostream>
using namespace std;

//Compiler version g++ 6.3.0
class sample   //base class declaration
{
    int a,b;
  public:
    void print(int x, int y);   //print function declaration
    friend void display(sample s);  //friend function declaration
};

void sample::print(int x, int y)    //print member function defination
{
  a=x;b=y;cout<<a*b<<endl;
}

void display(sample s)      //defination of friend function
{                          //passed base class object
  cout<<s.a<<endl<<s.b;   //printing data 
}
int main()
{
    sample s;
    s.print(2,3);
    display(s);   //passing sample object "s"
}
