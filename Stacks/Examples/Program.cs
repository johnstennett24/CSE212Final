using classes;
public class Program{

static void Main(string[] args){

    // New instance of the stack class
    stack stack = new stack();

    // Test case 1
    Console.WriteLine("====Test Case 1====");

    // Creates the new Stack
    Stack<string> words = stack.newStack();

    // Adds a word to the stack
    string word = ("Word");
    stack.addWord(words, word);
    Console.WriteLine(words);


    Console.WriteLine("===================");
    }
}