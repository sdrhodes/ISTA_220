## Steven Rhodes
### C# Homework Chapter 8

### 1. What is the difference between deep copy and shallow copy?
A deep copy contains copies of all the copied method's values. Shallow copies can contain reference types

### 2. What is the value of a reference after you declare and initialize it?
An address to a location in memory

### 3. How do you declare a value type?
You declare a value type by labeling a variable with int, float, double, or char

### 4. How do you declare a reference type?
Reference types are addresses to a block of memory. The type is determined by the compiler when you use the new keyword to create a new instance of the class. At that point, the new object is stored in memory

### 5. Does C# allow you to assign NULL to a value type?
No

### 6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
No, because you can copy a non-nullable value to a nullable variable, but not vice versa

### 7. What is the difference between the stack and the heap?
The stack contains referenced boxes of memory, the heap contains a random assortment of boxes that might contain multiple references to the same memory. Stack memory holds values or addresses to referenced locations.

### *** 8. What does it mean when we say that all classes are specialized types?
????

### *** 9. What does ref do?
Ref causes the compiler to pass a reference to the actual argument rather than a copy of the argument (it changes the argument)

### *** 10. What does out do?
Out means output, it is a tool for forcing a method to initialize a parameter

### *** 11. Describe boxing and unboxing in your own words.
Boxing is the method of taking values in the stack, and adding a memory location in the heap, which can be referenced. Unboxing is the act of casting a referenced location storing a value in the heap to a memory location on the stack

### 12. What does cast do?
Cast attempts to convert one data type to another. If the data types are compatible, the code compiles okay. Otherwise, it throws an InvalidCastException


