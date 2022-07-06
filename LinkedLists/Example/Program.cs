using classes;

public class Program{
    static void Main(string[] args){
        // Main method for entrance

        Console.WriteLine("==================");
        Console.WriteLine(" ====Examples====");
        Console.WriteLine("==================");

        // Create a new Linked List.
        Linkedlist ll = new Linkedlist();
        LinkedList<int> list = ll.newList();

        // Then fill it with numbers add the last number then the first.
        // Adding the number to the last repeatedly just inserts the numbers
        // one after the other in the order in which you called the functions

        Console.WriteLine("=================");
        Console.WriteLine(" ==Add to Last==");
        Console.WriteLine("=================");


        ll.AddNumberToLast(list, 130);
        ll.AddNumberToLast(list, 67);
        ll.AddNumberToLast(list, 56);
        ll.AddNumberToLast(list, 23);
        ll.AddNumberToLast(list, 9);
        ll.AddNumberToLast(list, 7);
        ll.AddNumberToLast(list, 3);
        ll.AddNumberToLast(list, 56);
        ll.AddNumberToLast(list, 78);
        ll.AddNumberToLast(list, 45);
        ll.AddNumberToLast(list, 10);

        foreach (var elem in list) {
            Console.WriteLine(elem);
        }

        Console.WriteLine("==================");
        Console.WriteLine(" ==Add to First==");
        Console.WriteLine("==================");



        // Now if we add the numbers using the add first method the number go in the first
        // spot everytime.
        ll.AddNumberToFirst(list, 120);
        ll.AddNumberToFirst(list, 121);
        ll.AddNumberToFirst(list, 122);
        ll.AddNumberToFirst(list, 123);
        ll.AddNumberToFirst(list, 124);
        ll.AddNumberToFirst(list, 125);

        foreach (var elem in list) {
            Console.WriteLine(elem);
        }

        Console.WriteLine("===============");
        Console.WriteLine(" ==Add Nodes==");
        Console.WriteLine("===============");

        // In order to add the node before and after we have
        // to do things a little differently. First you need 
        // to assign the value to a variable that has the type of a
        // LinkedListNode<int>.

        LinkedListNode<int> node = list.AddLast(124);
        LinkedListNode<int> otherNode = new LinkedListNode<int>(127);

        ll.AddNumberAfter(list, node, otherNode);

        foreach (var elem in list){
            Console.WriteLine(elem);
        }


        // Then remove the last and first numbers.

        Console.WriteLine("==================");
        Console.WriteLine(" ==Remove Nodes==");
        Console.WriteLine("==================");

        // Removes first node
        ll.RemoveFirst(list);

        foreach (var elem in list) {
            Console.WriteLine(elem);
        }
        
        // Removes last node
        ll.RemoveLast(list);

        foreach (var elem in list) {
            Console.WriteLine(elem);
        }

        // Then remove a specific number in the list.

        LinkedListNode<int> newNode = list.First;

        ll.RemoveNode(list, newNode);

    }
}