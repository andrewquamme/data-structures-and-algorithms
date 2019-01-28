# Trees
<!-- Short summary or background information -->
Implement Binary Trees
## Challenge
<!-- Description of the challenge -->
* Create a `Node` class that has properties for the `value` stored in the node, the `left child` node, and the `right child` node.
* Create a `BinaryTree` class
  * Define a method for each of the depth first traversals called `preOrder`, `inOrder`, and `postOrder` which returns an array of the values, ordered appropriately.
* Create a `BinarySearchTree` class
  * Define a method named `add` that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
  * Define a method named `contains` that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
### Approach
* Created a  Node class.
  * Properties: Value, Left, Right  
* Created a Tree class.
  * Properties: Root 
* Created a BinaryTree class
  * Created a PreOrder method that internally creates a list to hold all of the values then recursively steps through the tree caputuring each nodes value before going left or right. The values are returned as a list.
  * Created an InOrder method that internally creates a list to hold all of the values then recursively steps through the tree caputuring each nodes value after going left and before going right. The values are returned as a list.
  * Created a PostOrder method that internally creates a list to hold all of the values then recursively steps through the tree caputuring each nodes value after going left and right. The values are returned as a list.
* Created a BinarySearchTree class
  * Created an Add method
  * Created a Contains method that traverses the BST and returns a True/False if the value is found our not

### Efficiency
**BinaryTree Traversal**
Time: O(n)
Space: O(h)

**BinarySearchTree Add**
Time: O(log n)
Space: O(1)

**BinarySearchTree Contains**
Time: O(log n)
Space: O(1)


## API
<!-- Description of each method publicly available in each of your trees -->
BinaryTree and BinarySearchTree classes require the Node class to be able to add nodes to the tree.