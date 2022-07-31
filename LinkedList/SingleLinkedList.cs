

namespace Code.PracticeApp.LinkedList
{
    internal class SingleLinkedList
    {
        public Node head;

        public SingleLinkedList InsertFront(SingleLinkedList singleLinkedList, int data)
        {
            Node newNode = new(data);           
        
            newNode.next = singleLinkedList.head;
          
            singleLinkedList.head = newNode;

            return singleLinkedList;
        }

        public SingleLinkedList InsertLast(SingleLinkedList singleLinkedList, int data)
        {
            Node newNode = new Node(data);

            if(singleLinkedList.head == null)
            {               
                singleLinkedList.head = newNode;
                return singleLinkedList;
            }

            Node lastNode = GetLastNode(singleLinkedList);
            lastNode.next = newNode;

            return singleLinkedList;
        }

        private Node GetLastNode(SingleLinkedList sll)
        {
            Node temp = sll.head;
            while(temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }
    }
}
