# Big Ball of Mud

"A big ball of mud is a software system that lacks a perceivable architecture. Although undesirable from an engineering point of view, such systems are common in practice due to business pressures and developer turnover." - [Wikipedia][1]

# Why its an anti-pattern

The main issue that arises from this pattern is it becomes a maintainability nightmare. This makes it very tough to add new features, track down bugs, and train new developers.

# How to avoid this anti-pattern

+ Design systems with architecture principles in mind. 
+ Do not just start writing code - especially in a team environment.
+ Do not accept fragmented requirements

# How to fix this anti-pattern

There are a couple of things that can be done:

1. Study the current system. Extract requirements. Look for an opportunity to rebuild from scratch. For instance if you want to move from a desktop application to a client-server application.
2. Write a unit test suite. As you write tests you will be forced to rearchitect certain parts of the code. Start with a series of small iterative refactorings. Eventually you start transforming the system to a more maintainable solution.

[1]: http://en.wikipedia.org/wiki/Big_ball_of_mud
