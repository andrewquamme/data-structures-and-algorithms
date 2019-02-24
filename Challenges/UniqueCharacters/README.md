# Unique Characters in a String
<!-- Short summary or background information -->
Determine if a string is full of unique characters
## Challenge
<!-- Description of the challenge -->
* Write a function that will determine if the given string is full of unique characters.
* Assume that spaces don’t count, and the charactes are not case sensitive (i.e. “A” is the same as “a”).

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
This challenge was approached using a Hashtable created in a previous data structure implementation. The method takes a string as input. Each character is then converted to uppercase and the hashtable is checked to see if it contains the current character. If it does, then the character is not unique and a `false` is returned. If it is not already, the character is placed into the hashtable. If by the end of the string no collision has occurred, then the characters must be unique and the method returns `true`.
### Big O
Time: O(n)
Space: O(n)