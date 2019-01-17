# Linked List Merge
<!-- Short summary or background information -->
Merge two linked lists

## Challenge
<!-- Description of the challenge -->
Write a function called `mergeLists` which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
To approach this challenge, we created a method called `KthFromEnd`. In this method, we first iterate through the linked list to determine the length of the list. If k is larger than the length of the list or the list is null, an exception is thrown. If everything is valid, the method returns the node value at `k` from the end of the list.

Time O(n)
Space O(1)

## Solution
<!-- Embedded whiteboard image -->
![Linked List Merge](../../assets/LinkedListMerge.jpeg)