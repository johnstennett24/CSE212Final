using System.Collections;

namespace example{

    public class BST : IEnumerable<int> {
        private Node? root;

        /// <summary>
        /// Insert a new node at the front (i.e. the head) of the linked list.
        /// </summary>
        public void Insert(int value) {
            // Create new node
            Node newNode = new Node(value);

            // If the list is empty, then point both head and tail to the new node.
            if (root is null)
                root = newNode;
            // If the list is not empty, then only head will be affected.
            else
                root.Insert(value);
        }

        public bool Contains(int value)
        {
            return NodeContains(root, value);
        }

        private bool NodeContains(Node? node, int value)
        {
            // TODO Start Problem 2
            return false;
            // End Problem 2
        }

        /// <summary>
        /// Yields all values in the linked list
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            // call the generic version of the method
            return GetEnumerator();
        }

        /// <summary>
        /// Iterate forward through the BST
        /// </summary>
        public IEnumerator<int> GetEnumerator()
        {
            var numbers = new List<int>();
            TraverseForward(root, numbers);
            foreach (var number in numbers)
            {
                yield return number;
            }
        }

        public void TraverseForward(Node? node, List<int> values)
        {
            if (node is not null)
            {
                TraverseForward(node.Left, values);
                values.Add(node.Data);
                TraverseForward(node.Right, values);
            }
        }

        /// <summary>
        /// Iterate backward through the Linked List
        /// </summary>
        public void Reverse(Node? node, List<int> values){
            if (node is not null){

                TraverseForward(node.Right, values);
                values.Add(node.Data);
                TraverseForward(node.Left, values);

            }
        }

        public override string ToString() {
            return "Bst[" + String.Join(", ", this.Select(i => i.ToString())) + "]";
        }
    }
}