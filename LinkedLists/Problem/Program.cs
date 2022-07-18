using classes;

namespace program{
    public class program{
        static void Main(string[] args){
            Console.WriteLine("=================================");
            Console.WriteLine("              Problem            ");


            // A company has hired you to fix their queue system. The old one was too slow and they would also
            // like to add the functionality to be able to remove those from the queue that change their mind
            // and no longer want to be in the queue.

            

            // Utilize a Linked List to be able to achieve what this company would like.
            Linkedlist list = new Linkedlist();
            LinkedList<int> List = list.newList();

            LinkedListNode<int> number = new LinkedListNode<int>(52);
            LinkedListNode<int> number1 = new LinkedListNode<int>(56);
            LinkedListNode<int> number2 = new LinkedListNode<int>(89);
            //Add and remove someone from the queue from the first and the middle of the list.

            LinkedListNode<int> number3 = new LinkedListNode<int>(45);
            
            list.AddNumberToFirst(List, number);
            list.AddNumberToFirst(List, number1);
            list.AddNumberToFirst(List, number2);
            list.AddNumberToFirst(List, number3);


            list.RemoveNode(List, number);

            list.printLinkedList(List, number3);
        }
    }
}