# Linked List Merge
<!-- Short summary or background information -->
Merge two linked lists. Collaborated with Sean Miller.

## Challenge
<!-- Description of the challenge -->
Write a function called `mergeLists` which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
To approach this challenge, we created a method called `mergeLists`. Using a while loop, we iterate through each linked list and create a temporary node to hold the current next node. The current Node.Next of list1 is changed to the Node.Current of list 2, Node.Next of list2 is changed to the temporary node, and list1 moves to the next node. This process is repeated until the end of the lists. In the case of uneven lists, the "remainder" of the longer list is already linked.

Time O(n)
Space O(1)

## Solution
<!-- Embedded whiteboard image -->
![Linked List Merge](../../assets/LinkedListMerge.jpeg)