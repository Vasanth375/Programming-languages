#include <iostream>
using namespace std;

//Compiler version g++ 6.3.0

//forward declaration
class classB;

class classA
{
  //private data and functions
  int a=4;
  void display();
  
  //friend function of classA and classB as parameters
  friend void add(classA,classB);

};

void classA::display()
  {
    cout<<"enter a ";//cin>>a;
  }
  
class classB
{
  //private data and functions
  int b=6;
  void display()
  {
    cout<<"enter b ";cin>>b;
  }
  
  //friend function of classA and classB as parameters
  friend void add(classA,classB);

};

//friend function definition
void add(classA A,classB B)
{
  A.display();
  B.display();
  cout<<A.a+B.b;
}

int main()
{
  classA A;
  classB B;
  add(A,B);
}
