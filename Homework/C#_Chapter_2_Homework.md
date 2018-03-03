## Steven Rhodes
### C# Homework Chapter 2

### 1. What is a local variable?
A variable can be a value. A local variable is one that is in a method or in small blocks of code. A variable declared in a method is defined only in the scope of the method.

### 2. What is a statement?
A statement performs an action. Collections of statements form methods. Ends with a semi colon

### 3. What is an identifier?
An identifier is a name given to an element such as a namespace, method, or class

### 4. What is a variable?
A storage location that holds a value. Variable is a named location in memory

### 5. What is a method?
A named sequence of statements that performs an action. Indicated by ending with ()

### 6. Are primitive types and value types the same thing? (See page 177)
Most primitive types are value types that refer to a specific block of code that was created for the variable that was declared. An exception would be string, which is a class that refers to an address which points to the physical location of the object.

### 7. How are arithmetic operators and variable types related?
Arithmetic operators can be used to perform operations on different variable types. Variables char, int, long, float, double, and decimal can be used with all arthmetic operators. String can use addition (+), and bool can't use arithmetic operators

### 8. How do you turn an integer into a string?
Utilize the .ToString method

### 9. How do you turn a string into an integer?
Utilize Int32.Parse method

### 10. What is the difference between precedence and associativity? Give an example where this make a difference
Precedence refers to the order of operations, in which multiplication and division are handled prior to addition and subtraction. Associativity is the order of handling operators with the same level of precedence. In the case where presidence is the same, operators and handled from left to right. Example: 2+2*3 . In this case, 2*3 is handled first, equalling 6, then added to 2. 4/2*10. 4/2 = 2 *10 = 20.   2*10 = 20. 4/20 = 1/5

### 11. What is a definite assignment rule?
Every variable must be initialized before it is read from

### 12. How are the prefix and postfix increment and decrement  operators evaluated differently?
Prefix forms of increment and decrement are evaluated before the variable is returned in an expression (ie ++x, x is incremented prior to the variable being used in Console.WriteLine(++x);
One the other hand, postfix forms are evaluated after the variable is returned in an expression (ie x++, x is incremented after the variable is displayed in Console.WriteLine(x++);

### 13. What is string interpolation?
String interpolation is a way of constructing strings using the $ symbol, it condenses and simplifies the composite format used when constructing strings. (Plug it in) Hello my name is (X) . X = George. Hello my name is George

### 14. What does the var keyword do?
The var keyword causes the C# compiler to chose the type of variable when you initialize it. For example, var myDecimal = 4.0; creates a variable of type decimal equaling 4.0. Implicit declaration
