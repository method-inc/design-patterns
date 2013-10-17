# Inner Platform Effect

"The inner-platform effect is the tendency of software architects to create a system so customizable as to become a replica, and often a poor replica, of the software development platform they are using." - [Wikipedia][1]

# Why its an anti-pattern

Typically the inner platform effect leads to poor performance and low reliability (typically they are implemented worse than the systems they are replicating).

# How to avoid this anti-pattern

+ This one is an easy trap. Under the guise of configurability the inner platform effect can sneak in. The best way to avoid this is to be vigilant and question yourself when you start making claims about flexibility and configurability. It is rare when users need this level of configurability.

# How to fix this anti-pattern

+ Typically if you have already implemented a system that reflects an inner platform effect there is not much to be done. It ultimately depends on how far down the path you are. You can refactor yourself back to a system that performs better and is more reliable.

[1]: http://en.wikipedia.org/wiki/Inner-platform_effect
