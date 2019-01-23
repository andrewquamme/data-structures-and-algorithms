# Stacks and Queues
<!-- Short summary or background information -->


## Challenge
<!-- Description of the challenge -->
Create a `Stack` class that has a `top` property. It creates an empty Stack when instantiated.
* This object should be aware of a default empty value assigned to `top` when the stack is created.
* Define a method called `push` which takes any value as an argument and adds a new node with that value to the `top` of the stack with an O(1) Time performance.
* Define a method called `pop` that does not take any argument, removes the node from the `top` of the stack, and returns the node’s value.
* Define a method called `peek` that does not take an argument and returns the value of the node located on the `top` of the stack.

Create a `Queue` class that has a top property. It creates an empty queue when instantiated.
* This object should be aware of a default empty value assigned to `front` when the queue is created.
* Define a method called `enqueue` which takes any value as an argument and adds a new node with that value to the back of the queue with an O(1) Time performance.
* Define a method called `dequeue` that does not take any argument, removes the node from the front of the queue, and returns the node’s value.
* Define a method called `peek` that does not take an argument and returns the value of the node located in the front of the stack.


## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
#### BigO 
**Stack.Push and Queue.Enqueue methods**

Space O(1) / Time O(1)

**Stack.Pop and Queue.Dequeue methods**

Space O(1) / Time O(1)

**Stack.Peek and Queue.Peek methods**

Space O(1) / Time O(1)

## API
### Stack
**Push()** Adds a new node to the top of the stack

**Pop()** Removes and returns the top node from the stack

**Peek()** Returns the top node on the stack

### Queue
**Enqueue** Adds a new node to the back of the queue

**Dequeue** Removes and returns the front node from the queue

**Peek** Returns the front node in the queue