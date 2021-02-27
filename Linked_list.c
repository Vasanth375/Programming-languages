       /*N.Vasanth*/

// data and link must be grouped
#include<stdlib.h>
#include<stdio.h>
struct node
{

    int data; // it stores data
    struct node *link; // it must point to address of next node
}*first,*last,*newnode;

typedef struct node node;
/*it gives user name to struct node as
node ;*/

void insert()
{
    int data;
    newnode=(struct node*)malloc(sizeof(struct node));
    // create the node using malloc
    printf("enter the data :");
    scanf("%d",&data);

    newnode->data=data;
    // inserting data

    newnode->link=NULL;
    //by created node link will be NULL
    if (first==NULL) //no node exist in memory

    {   //if this condition true we can
        //assume only one node is created

        printf("no node in memory,it creates node\n");
        first=newnode;
        //points to first node
        last=newnode;
        //points tho last node
    }

    else

    {

        last->link=newnode;
        // link the nodes
        last=newnode ;
        // to point to last node

    }

}

void display()
{
    node *temp=NULL;
//struct node as node
    temp=first;// temp points to first
    printf("list of nodes \n");
    while(temp!=NULL)
    {
        printf("\n %d",temp->data);
        //print the data
        temp=temp->link; // it will move
        //to next node

    }

}
void main()
{
    int n=4,i;
    printf("enter number nodes :");
    scanf("%d",&n);
    for(i=1; i<=n; i++)
    {

        insert(); // insert function
        //to insert nodes

    }
    display();
    //function to print list
}

