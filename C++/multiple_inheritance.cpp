/* multiple inheritance means a subclass inherits more than one base class
*/
#include<iostream>
using namespace std;
class app2;
class app1
{//base class1             /*MULTIPLE INHERITANCE*/
    public:
        void fun1()
        {
            cout<<"N VASANTH 19124-CM-068\n";
           
        }
};
class app2
{//baseclass2
    public:
        void fun2()
        {
            
            cout<<"SUCCESSFULLY ACCESSED INHERITED CLASS";
        }
};
class app3 :public app2,public app1//inheriting both base classes to subclass(app3)
{//this is subclass
    public:
        void fun3()
        {
            cout<<"app3 method\n";
        }
};
int main()
{
    app3 obj;
    obj.fun3();
    obj.fun1();
    obj.fun2();
}
