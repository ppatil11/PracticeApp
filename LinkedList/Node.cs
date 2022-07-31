

namespace Code.PracticeApp.LinkedList
{
    /*
     The node of a singly linked list contains a data part and a link part. The link will contain the address of next node 
     and is initialized to null. So, we will create class definition of node for singly linked list as follows:
     */
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
