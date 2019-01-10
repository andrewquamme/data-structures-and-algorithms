# Insert and shift middle index of array
<!-- Short summary or background information -->
Collaborated with Clarice Costello

## Challenge
<!-- Description of the challenge -->
Write a function called `BinarySearch` which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
Big O Time = O(n) // Big O Space = O(n)

To approach this challenge, we made a new array one index longer than the input array.
After determining the midpoint of the input array, we use two for loops to iterate through
both halves of the new array, inserting the original values before and after the new value.

## Solution
<!-- Embedded whiteboard image -->
![Binary Search](../../assets/BinarySearch.jpeg)