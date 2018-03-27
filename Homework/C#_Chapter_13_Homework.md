## Steven Rhodes
### C# Homework Chapter 13

### 1. What is an interface as the term is used on object-oriented programming?
An interface specifies methods and properties that a class that inherits from the interface must provide

### 2. How do you define an interface?
I define an interface as a meeting layer between two entities

### 3. Can an interface have variables, fields, or properties?
No, a layer cannot contain data

### 4. How do you define a method in an interface?
A method is defined by name, and return type. Methods that correspond to interface methods must match parameters exactly, and must be publicly accessible

### 5. Can you instantiate an object through an interface? Why or why not?


### 6. Using the new keyword, can you declare a reference to an interface?
Yes, indirectly. You can create a new variable. Then set the variable equal to an interface if it's under the original variables hierarchy.

### 7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?
A class can implement multiple interfaces by listing them behind a colon in the class definition.

### 8. What does it mean to explicitly implement an interface?
You use a fully qualified reference to the object through an appropriate interface

### 9. What are the restrictions on interfaces?
An interface cannot contain data, cannot contain constructors/destructors, cannot specify access modifiers, cannot nest any types, interfaces cannot inherit from structs or classes

### 10. What is the difference between an abstract class and an interface?
Abstract classes are classes with functionality that are used for inheritance - they are a default implementation of a class - it is an abstraction of functionality rather than an entity

### 11. What is an abstract method?
Abstract methods are methods that do not contain method bodies, and are meant to be overwritten with their own functionality when used in an inheritted class

### 12. What is an sealed class?
A sealed class cannot be the base class - it cannot be derived from

### 13. What is an sealed method?
A sealed method cannot be overrided by a derived class

