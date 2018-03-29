## Steven Rhodes
### C# Homework Chapter 12

### 1. How does inheritance promote the principle of don’t repeat yourself (DRY)?
Inheritance allows you to organize classes systematically under umbrellas of similar attributes and functionality. Finding similar behavior allows for the reuse of code amongst derived classes. The second time you write the same functionality, you stop, encapsulate it in a method or subprocedure so you can call it.

### 2. What is the syntax of a derived class that inherits from a base class?
	Class NewClass : OldClass

### 3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
All classes inherit from the System.Object class

### 4. What happens if you do not have a default constructor in a base class when creating a derived class?
If you do not call the correct base-class constructor, it will use the default constructor

### 5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
Yes, because the derived class is a type of the base class type.

### 6. Can you assign a variable of a derived class to another variable of a derived class of its base class? Why or why not?
No, since the classes have their own unique variables, one does not affect the other without changing the value of shared variables common to the base class.

### 7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
Yes, because the derived class is a type of the base class type.

### 8. Under what circumstances would you want to use the new keyword when defining a method in a derived class?
If you create new methods with the same name as methods in a class from which the derived class inherits, you can avoid warnings by using the new keyword.

### 9. What is a virtual method? Why would you want to define a virtual method?
A virtual method allows its functionality to be overwritten by derived classes

### 10. What does override do? Why does it do it?
Override changes the functionality of an inherited method. You override method functionality for the derived method

### 11. How do you define an extension type?
You define an extension type by using the 'this' keyword prior to the type being extended in the method declaration. This must be performed in a static method of a static class

### 12. Why do you define an extension type?
You define extensions to add functionality to existing methods without changing them directly


