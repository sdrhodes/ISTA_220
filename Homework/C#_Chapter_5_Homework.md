## Steven Rhodes
### C# Homework Chapter 5

### 1. What is a compound assignment operator? How does it work?
A compound assignment assigns a variable to a value and performs a calculation on the value that was assigned. It could immediately add or subtract a value from the variable

### 2. List all the compound assignment operators
*=, /=, %=, +=, -=

### 3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50
x += 5, x = x + 5, x -= 50, x = x - 50

### 4. How long does a while loop run?
Until the Boolean expression in the initial line evaluates to false

### 5. What happens if you don't change the loop variable in the body of the while loop block
If the statement evaluates to true, it will run forever. If it evaluates to false, it won't run at all (terminate instantly)

### 6. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?
A for loop has three parts, initialization, a boolean expression, and update control. All of them can be omitted. If you omit all of them, the boolean expression defaults to true, and there is no update control so it runs forever (infinite loop).

### 7. How do you guarantee that a loop runs at least once?
Use a do while loop. The boolean is evaluated at the end so the statement is guaranteed to run at least once.

### 8. What does the break statement do?
The break statement causes execution to stop and exit the iteration statement, moving directly to the next statement outside of the body.

### 9. What does the continue statement do?
The continue statement causes the program to perform the next iteration of the loop immediately after evaluating the boolean expression