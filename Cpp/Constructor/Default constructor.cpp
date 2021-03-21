#include <iostream>

using namespace std;

class myClass 

{     // The class

  public:           // Access specifier

   void MyClass() 

    {              // Constructor

      cout << "Hello World!";

    }

};

int main() 

{

  myClass myObj;    // Create an object of MyClass

                   // (this will call the constructor)

  myObj.MyClass();

  return 0;

}

