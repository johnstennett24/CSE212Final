using classes;
public class program{
    public program(){

    }

    static void Main(string[] args){

        BST tree = new BST();

        int number = 72;
        tree.Insert(number);

        Console.WriteLine(tree);
    }
}