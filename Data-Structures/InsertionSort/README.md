# Insertion Sort
<!-- Short summary or background information -->
Write a function for insertion sort that takes in an unsorted array and returns the array sorted using insertion sort.

## Challenge
<!-- Description of the challenge -->
Insertion sort is one of the three common “simple sorts”. The following are generally referred to as simple sorts:

* Bubble Sort
* Selection Sort
* Insertion Sort.

All the simple sorts are brute force algorithm and have worst-case quadratic time complexity. It starts at the left most element in the array and moves right, sorting everything behind the initial pointer as it moves through the array.

Insertion is what we call “stable”. A stable sort means that it will keep the original relative order of the input set. A stable sort guarantees that the relative ordering for equivalent values be maintained, while an unstable sort makes no such promises. Both bubble and insertion sort are stable, while selection sort is not.

An advantage to insertion sort is if you are incrementally building a list, you can do it as items are received. Insertion sort is really only beneficial on small lists. The threshold for this is approximately 50 items.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
This function looks at the value at `array[0]` and compares it to the value at `array[1]`. If `array[1]` is less than `array[0]`, the two values are "swapped". The function then compares `array[1]` to `array[2]`. If `array[2]` is less than `array[1]`, the two values are "swapped" and `array[0]` is once again compared to `array[1]` and swapped if required. This process continues to the end of the array, each time working backwards through the "front end" of the array to ensure values are in order. A sorted array is not returned, as the sort is done in place on the original array itself.

### Big O
Time O(n^2)
Space O(1)