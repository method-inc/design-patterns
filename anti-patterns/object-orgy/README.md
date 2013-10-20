# Object Orgy

"In an object orgy, objects are insufficiently encapsulated, allowing unrestricted access to their internals, usually leading to unmaintainable complexity." - [Wikipedia][1]

# Why its an anti-pattern

Since encapsulation has been violated all the benefits of encapsulation disappear.

+ Reasoning about the system becomes very difficult
+ Leads to spaghetti code or a big ball of mud
+ Makes it difficult to reimplement without disturbing the rest of the system (code is brittle)

# How to avoid this anti-pattern

+ Use appropriate language features to enforce encapsulation like accessor methods
+ Use features like reflection with caution
+ [Chain of Responsibility](../../patterns/chain-of-responsibility/README.md) pattern
+ Discipline - If you find it easier to just make a member accessible consider the long term ramifications on code maintainability.

# How to fix this anti-pattern

+ Refactoring away this anti-pattern takes patience and discipline. You have to track down each direct reference and close each hole in your system.

[1]: http://en.wikipedia.org/wiki/Object_orgy
