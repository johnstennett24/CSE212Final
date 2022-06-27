namespace problem{
    public class problems{

        public problems(){

        }

        // Creates a new stack
        public Stack<string> newStack(){

            Stack<string> stack = new Stack<string>();
            return stack;
        }

        // Pushes a new word onto the stack.
        // Problem 1:
        public Stack<string> addWord(Stack<string> stack, string word){
            stack.Push(word);
            return stack;
        }


        // Pops the last word from the stack
        //Problem 2:
        public Stack<string> removeWord(Stack<string> stack){
            stack.Pop();
            return stack;
        }

        public Stack<string> replaceWord(Stack<string> stack){
            // Remove the last two elements from the list
            string word1 = stack.Pop();
            string word2 = stack.Pop();

            // Add the words back in reverse order
            stack.Push(word1);
            stack.Push(word2);
            return stack;
        }
    }
}
