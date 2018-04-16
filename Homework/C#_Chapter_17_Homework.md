## Steven Rhodes
### C# Homework Chapter 17

### 1. What is a type parameter?
Placeholder

### 2. What does a type parameter do?
Proves usability, type safety, and performance

### 3. How many type parameters can a generic class have?
Multiple types. It expects one for keys, and one for values

### 4. What is the difference between a generic class and a generalized class?
Generalized class can accept type object, generic class is specialized on a specific type

### 5. What is a constraint? How do you specify a constraint?
Limits the types of parameters of a generic class to those that implement a particular set of interfaces and provide the methods defined by those interfaces

### 6. What is a generic method? How do you define a generic method?
A method that is declared with a type parameter.

### 7. What do we mean when we cay that a generic type interface is invariant?
Means that you can use only the type originally specified

### 8. What do we mean when we cay that a generic type interface is covariant?
Enables you to use a more derived type than originally specified

### 9. Does covariance work with value types? Does it work with reference types?
No, and no

### 10. What do we mean when we cay that a generic type interface is contravariant?
You can use a generic interface to reference an object of type B through a reference type A as long as type B derives from type A
