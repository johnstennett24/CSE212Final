namespace classes{
public class Linkedlist{
   public Linkedlist(){
   }
   public LinkedList<int> newList(){
       LinkedList<int> list = new LinkedList<int>();
       return list;
   }
   public LinkedList<int> AddNumberToLast(LinkedList<int> list, LinkedListNode<int> number){
       list.AddLast(number);
       return list;
   }
   public LinkedList<int> AddNumberToFirst(LinkedList<int> list, LinkedListNode<int> number){
       list.AddFirst(number);
       return list;
   }
   public LinkedList<int> AddNumberAfter(LinkedList<int> list, LinkedListNode<int> number, LinkedListNode<int> otherNumber){
       list.AddAfter(number, otherNumber);
       return list;
   }
   public LinkedList<int> AddNumberBefore(LinkedList<int> list, LinkedListNode<int> number, LinkedListNode<int> otherNumber){
       list.AddBefore(number, otherNumber);
       return list;
   }
   public LinkedList<int> RemoveFirst(LinkedList<int> list){
       list.RemoveFirst();
       return list;
   }
   public LinkedList<int> RemoveLast(LinkedList<int> list){
       list.RemoveLast();
       return list;
   }
   public LinkedList<int> RemoveNode(LinkedList<int> list, LinkedListNode<int> number){
       list.Remove(number);
       return list;
   }

   public void printLinkedList(LinkedList<int> list, LinkedListNode<int>? node){
    
       while (node is not null){
           Console.WriteLine(node.Value);
           node = node.Next;
       }
   }
}
   }

