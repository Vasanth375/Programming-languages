#include<stdio.h>
  struct NODE
  {
    struct NODE *prev;//previous member
    int data;//data member
    struct NODE *next;//next member
  }*first,*last;//structure members
  typedef struct NODE node;
  void main()
  {
    for(int i=0;i<4;i++)//creating four nodes
    push();
  }
  void push()//insertion method
  {
    node *new;
    int d=4;
    new=(node*)malloc(sizeof(node));
    //creating memory for new member
    
    new->data=d;
    printf("%d\n",new->data);
    if(first==NULL)
    {
      new->prev=NULL;
      first=new;
      last=new;
    }
    else
    {
      first->next=new;
      
      last=new;
    }
  }
  void display()
  {
    node *temp;
    temp=first;
    for(i=0;i<4;i++)
    {
      printf("%d",temp->data);
    }
  }
