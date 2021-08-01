#include<iostream>
using namespace std;
class Base
{
public:
    virtual void show()//overriding method
    {
        cout<<"base class";
    }
};
class Derived: public Base
{
public:
    void show()//overriden method 
    {
        cout<<"derived classs";
    }
    void dis()
    {
        cout<<"fell";
    }
};
int main()
{
    Base *b;
    Derived d;
    b=&d;
    b->show();
    d.show();    //derived class
    /*
    with virtual keyword
    normally it calls baseclass method but now it overrides and displays derived class method using virtual keyword
    */
}
