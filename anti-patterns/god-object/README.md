# God Object

"In object-oriented programming, a god object is an object that knows too much or does too much." - [Wikipedia][1]

# Why its an anti-pattern

A god object is the epitamy of tight coupling. A god object holds an extreme amount of state and methods. This makes the coder hard to test, brittle (hard to modify features or implementation details), and it is more difficult to understand. 

# How to avoid this anti-pattern

+ Consider the [Law of Demeter](http://en.wikipedia.org/wiki/Law_of_Demeter)
+ Follow the [Single Responsability Principle](http://en.wikipedia.org/wiki/Single_responsibility_principle)

# How to fix this anti-pattern

+ Study the god object. Understand all the god object knows and does. Once you understand that you can being to break out the implementation details one responsability at a time. As you do this its a great opportunity to write unit tests for the new objects.

[1]: http://en.wikipedia.org/wiki/God_object
