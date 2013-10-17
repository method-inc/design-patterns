# Interface Bloat

"In software design, interface bloat (also called fat interfaces by Bjarne Stroustrup and Refused Bequests by Martin Fowler) is when a computer interface incorporates too many operations on some data into an interface, only to find that most of the objects cannot perform the given operations" - [Wikipedia][1]

# Why its an anti-pattern

+ Encourages tight coupling

# How to avoid this anti-pattern

+ Follow [Interface Segregation Principle](http://en.wikipedia.org/wiki/Interface_segregation_principle)

# How to fix this anti-pattern

+ Refactor interfaces to role specific interfaces.

[1]: http://en.wikipedia.org/wiki/Interface_bloat
