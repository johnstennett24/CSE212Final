using problem;

public class program{
    static void Main(string[] args){
        
        problems problem = new problems();

        // The following problems are designed to help you practice
        // implementing stacks. You have been hired by a company trying
        // to create a word processor to compete with Microsoft Word, Apple
        // Pages and Google Docs. They have asked you to work on the undo and
        // redo functions.

        // For these problems do not worry about usre input, just functionality

        // Probelm 1. Add the functionality to add a word to the stack.
        // in the addWord() method in the Problems class.

        Console.WriteLine("===========================");
        Console.WriteLine("====Problem 1 Test Case====");
        Console.WriteLine("===========================");

        Stack<string> problem1stack = problem.newStack();

        problem.addWord(problem1stack, "programmer");
        problem.addWord(problem1stack, "best");
        problem.addWord(problem1stack, "the");
        problem.addWord(problem1stack, "is");
        problem.addWord(problem1stack, "programmer");
        problem.addWord(problem1stack, "lazy");
        problem.addWord(problem1stack, "The");

        // Should output
        // The
        // lazy
        //programmer
        //is 

        // Outputs each element in the problem1stack.
        foreach (var elem in problem1stack){
            Console.WriteLine(elem);
        }

        // Problem 2. Add the functionality to remove something from the stack.
        Console.WriteLine("===========================");
        Console.WriteLine("====Problem 2 Test Case====");
        Console.WriteLine("===========================");

        problem.removeWord(problem1stack);
        problem.removeWord(problem1stack);
        problem.removeWord(problem1stack);
        problem.removeWord(problem1stack);

        foreach (var elem in problem1stack){
            Console.WriteLine(elem);
        }

        // Problem 3. Add the functionality to reverse the two last things 
        //in the stack.
        Console.WriteLine("===========================");
        Console.WriteLine("====Problem 3 Test Case====");
        Console.WriteLine("===========================");

        problem.replaceWord(problem1stack);

        foreach (var elem in problem1stack){
            Console.WriteLine(elem);
        }
    }
}
