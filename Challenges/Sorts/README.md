# Insertion Sort
<!-- Short summary or background information -->
Write a function for insertion sort that takes in an unsorted array and returns the array sorted using insertion sort.

## Challenge
<!-- Description of the challenge -->
Insertion sort is one of the three common “simple sorts”. The following are generally referred to as simple sorts:

* Bubble Sort
* Selection Sort
* Insertion Sort.
* 
All the simple sorts are brute force algorithm and have worst-case quadratic time complexity. It starts at the left most element in the array and moves right, sorting everything behind the initial pointer as it moves through the array.

Insertion is what we call “stable”. A stable sort means that it will keep the original relative order of the input set. A stable sort guarantees that the relative ordering for equivalent values be maintained, while an unstable sort makes no such promises. Both bubble and insertion sort are stable, while selection sort is not.

An advantage to insertion sort is if you are incrementally building a list, you can do it as items are received. Insertion sort is really only beneficial on small lists. The threshold for this is approximately 50 items.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
### Big O
Time O(n^2)
Space O(1)