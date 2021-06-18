
#include<iostream>
using namespace std;
class app2;

class app1
{//base class1           
    public:
        void fun1()
        {
            cout<<"function1\n";
           
        }
};

class app2:public app1
{//baseclass2
    public:
        void fun2()
        {
            
            cout<<"function2\n";
        }
};

class app3 : public app1,public app2
{
    public:
        void fun3()
        {
            cout<<"function3\n";
        }
};

class app4 
{
    public:
        void fun4()
        {
            cout<<"function4\n";
        }
};

class app5 : public app1,public app4
{
    public:
        void fun5()
        {
            cout<<"function5\n";
        }
};
int main()
{
    app3 obj;
    app5 obj2;
    obj.fun3();//calling its own method 
    obj.fun2();//calling subclass of app2
    obj2.fun4();//calling function of multiple subclass method
    obj2.fun5();//calling it own fuction
}
