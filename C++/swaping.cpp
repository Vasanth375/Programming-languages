#include <iostream>
using namespace std;

//display function
/*reference parameters &a and &b is pointers 
pointing to main() a and b normal variable.
Any operations performed on pointer variables
this reflects on a and b normal variable.*/

void swap(int &a, int &b)
{
  int temp=a;a=b;b=temp;
}

int main()
{
  int x=10;int y=20;
  cout<<"values before swap "<<x<<" "<<y<<endl;
  
  swap(x,y);//passing values

  cout<<"values after swap "<<x<<" "<<y<<endl;
}
