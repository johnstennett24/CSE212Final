namespace example{
public class program{
    public program(){

    }

    static void Main(string[] args){

        // Creates a new instance of the BST class.
        BST tree = new BST();

        Console.WriteLine("==============================");
        Console.WriteLine("========== Examples ==========");
        Console.WriteLine("==============================");

        // Insert()
        Console.WriteLine("==============================");
        Console.WriteLine("=========== Insert ===========");
        Console.WriteLine("==============================");

        tree.Insert(72);
        tree.Insert(12);
        tree.Insert(45);

        Console.WriteLine(tree);

        // Contains()
        Console.WriteLine("==============================");
        Console.WriteLine("========== Contains ==========");
        Console.WriteLine("==============================");

        Console.WriteLine(tree.Contains(12));
        Console.WriteLine(tree.Contains(18));

        // TraverseForward()
        Console.WriteLine("==============================");
        Console.WriteLine("====== Traverse Forward ======");
        Console.WriteLine("==============================");

        List<int> values = new List<int>();
        Node node = new Node(34);

        tree.TraverseForward(node.Left, values);
        
        foreach (var i in values){
            Console.WriteLine(i);
        }

        // Reverse()
        Console.WriteLine("==============================");
        Console.WriteLine("========== Reverse ===========");
        Console.WriteLine("==============================");

        tree.Reverse(node.Left, values);
        
        foreach (var i in values){
            Console.WriteLine(i);
        }
    }
}
}