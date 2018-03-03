## Steven Rhodes
# C# Homework Chapter 4

### 1. What are all possible values of a boolean expression?
True or false

### 2. List eight Boolean operators
== equal to, != not equal to, < less than, <= less than or equal to, > greater than, >= greater than or equal to, && and operator, || or operator

### 3. What are the differences in how short circuiting works for && and ||
If one condition evaluates to false, the AND outcome cannot possibly be true, therefore the comparison stops evaluating. Likewise, if one condition evaluates to true for the OR operator ||, the evaluation stops, and the outcome is true.

### 4. look at the list of operators. What operator has the highest precedence? Which has the lowest?
() precedence override, ++ post-increment, -- post-decrement have the highest precedence, the assignment operator = has the lowest.

### 5. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?
Using curly braces after an if/or statement creates a block which is a sequence of statements that execute if the if/or statement evaluate to true

### 6. In a switch statement, what happens if you omit break?
If you forget the break statement, it allows the execution to fall through to the code preceding the next break statement. Following cases could evaluate as true since