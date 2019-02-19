# Hashtables
<!-- Short summary or background information -->
Create a personal implementation of a hash table

## Challenge
<!-- Description of the challenge -->
Implement a Hashtable with the following methods:

* `add` takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed
* `get` takes in the key and returns the value from the table
* `contains` takes in the key and returns a boolean, indicating if the key exists in the table already
* `hash` takes in an arbitrary key and returns an index in the collection

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
### Big O
Space O(n)

Time O(1) at best, O(n) if there are collisions and key is not first in the linked list

## API
<!-- Description of each method publicly available in each of your hashtable -->

* `add` Takes in both the key and value. This method hashes the key, and adds the key and value pair to the table, handling collisions by adding the new value to the "front" of a linked list
* `get` Takes in the key and returns the value from the table
* `contains` Takes in the key and returns a boolean, indicating if the key exists in the table already
* `hash` Takes in an arbitrary key and returns an index in the collection