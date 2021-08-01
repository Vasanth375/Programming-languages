#include<iostream>
using namespace std;
class Base
{
public:
        void show()
        {
            cout<<"base class\n";
        }
};
class Derived:public Base
{
private:
    /* data */
public:
    void show()
    {
        cout<<"Derived class";
    }
};
int main()
{
    Base *b;
    Derived d;
    b=&d;
    b->show();
    //base class
    /*
    without virtual 
    baseclass pointer in c++ can only access by its own data members only 
    baseclass pointer can't access data members from other objects to resolve this issue
    virtual concept is introduced
    */

}
