using classes;
public class Program{

static void Main(string[] args){

    // New instance of the stack class
    stack stack = new stack();

    // Test case 1  
    Console.WriteLine("======================");
    Console.WriteLine("====Example Output====");
    Console.WriteLine("======================");

    // Creates the new Stack
    Stack<string> words = stack.newStack();

    // Adds a word to the stack
    stack.addWord(words, "This");
    stack.addWord(words, "is");
    stack.addWord(words, "a");
    stack.addWord(words, "stack");

    // Outputs each element in the stack
    foreach (var elem in words){
        Console.WriteLine(elem);    // Should output stack
                                    //               a
                                    //               is
                                    //               This
    } 

    Console.WriteLine("===================");

    // Removes the word from the stack
    stack.removeWord(words);

    // Prints each element in the stack
    foreach (var elem in words){
        Console.WriteLine(elem);    // Should output a
                                    //               is
                                    //               This
    }
    }
}