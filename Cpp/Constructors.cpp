#include <iostream>
using namespace std;

class application    //class created
{
  public:           //access specifier
    string name;    //data member
    void display(string n)   //parameters 
    {
      name=n;
      cout<<"name is "+name<<endl;
    }
};
int main()
{
  application obj1;          //object1 created
  application obj2;          //object2 created
  obj1.display("VASANTH");   //using obj calling method
  obj2.display("Sai");
}
