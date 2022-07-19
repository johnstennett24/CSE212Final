namespace problem{
    public class program{
        static void Main(string[] args){
            // Google uses Binary Trees to be able to search through mass amount of data as
            // possible. 

            // Google has hired you to implement a tree and add data to it. Then display the data from
            // the tree.


            // Add some data to the tree.
            BST tree = new BST();
             List<int> values = new List<int>();

            tree.Insert(45);
            tree.Insert(52);
            tree.Insert(15);

            tree.printTree(root, values);
        }
    }
}