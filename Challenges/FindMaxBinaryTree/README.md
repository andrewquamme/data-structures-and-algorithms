# Find the Maximum Value in a Binary Tree
<!-- Short summary or background information -->
Find the Maximum Value in a Binary Tree

## Challenge
<!-- Description of the challenge -->
Write a function called `FindMaxValue` which takes binary tree as its only input. Without utilizing any of the built-in methods available to your language, return the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
#### Approach
This approach takes in a tree as input. If the tree is empty, null is returned. Otherwise, a max variable is set to the Root Value of the tree. The Root is then sent into an `InOrder` traversal metod along with the max value. The `InOrder` method performs an in-order traversal of the tree, comparing each node to the current max value. If the node's value is greater, max is updated. After completion of the traversal, the current max is returned to the `FindMaxValue` method and returned to the user.
#### Efficiency
Time: O(n)
Space: O(h)

## Solution
<!-- Embedded whiteboard image -->
![Find Max Binary Tree](../../assets/FindMaxBinaryTree.jpeg)