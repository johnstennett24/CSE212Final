namespace classes{

    // Class that will create a stack
    public class stack{
        public stack(){

        }

        // This example contains a list of words in a stack that must
        // be either removed or added from the list. There are many
        // applications that this could be implemented into. One big one is
        // undo and redo in a word processing software or text editor.

        public Stack<string> newStack() {
            // Creates a new list for us to work with.
            Stack<string> words = new Stack<string>();
            return words;
        }

        // We use Push() to add something to a stack. This adds it to the next
        // position in the stack. If you remember from the reading, stacks use
        // LIFO or last in first out.
        public Stack<string> addWord(Stack<string> words, string word){
            words.Push(word);
            return words;
        }


        // We then can use Pop() to remove the last item in the Stack
        public Stack<string> removeWord(Stack<string> words){
            words.Pop();
            return words;
        }
    }
}