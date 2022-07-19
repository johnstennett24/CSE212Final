# Instrucitons: Binary Search Tree #

## **Content**:

![Toy](../assets/BSTSearch.png "Toy")

I. <span style = "color:yellow"> Trees </span>
   * Trees are DataStructures that are like Linked Lists, they have nodes and those nodes contain values. The difference is that a Tree has two pointers that goes to two different nodes at once.

   <span style = "color:red"> Node </span>: Node contains three things. data or the value of the Node, left or the pointer to the next left node, and right or the pointer to the next right node.

II. <span style = "color:yellow"> Recursion </span>
   * Recursion is when you put a method call inside of itself. This creates a loop until the method is complete.

   1. <span style = "color:yellow"> Insert() </span>
        * This will create a new Node and insert it into the tree. This is a recursive method.

        Effeciency: Insert() is O(log n) because it has to recursivley search the tree for the next available spot.
        
![Code](../assets/BSTinsert.png "Code")

   2. <span style = "color:yellow"> Contains() </span>
        * We use Contains() to see what the value of a Node is.

        Effeciency: Contains() is also O(log n) because it has to recursivley search the tree for the value.

![Code](../assets/Contains.png "Code")

   4. <span style = "color:yellow"> TraverseForward() </span>
        * This will iterate forward through the tree. This is also a recursive method.

        Effeciency: TraverseForward() is O(n) because it searches the left and right sides of the tree.

![Code](../assets/TraverseForward.png "Code")

   5. <span style = "color:yellow"> Reverse() </span>
        * Reverse() goes backwards through the tree.

        Effeciency: This recursivley traverses the tree backwards therefore it is O(n).

![Code](../assets/Reverse.png "Code")