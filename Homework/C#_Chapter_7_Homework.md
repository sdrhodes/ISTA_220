## Steven Rhodes
### C# Homework Chapter 7

### 1. What is a class? According to the book, what does a class “arrange?”
A classification - arranges information and behavior into meaningful entities

### 2. What are the two purposes of encapsulation?
To combine methods and data within a class - supports encapsulation
Control accessibility of the data and methods in a class

### 3. How do you instantiate an instance of a class? How do you access that instance?
You instantiate an instances of a class by using the new keyword, example - 
	
		Class newclass = new Class();

### 4. What is the default access of the fields and methods of a class? How do you change the default?
Fields and methods are defaulted to private (only usable by the class itself). You change this by using the following keywords in the creation of them - public, sealed, etc

### 5. What is the syntax for writing a constructor?
		Class Cars
		{ 
			Cars();
				{ ...}
		}

### 6. What is the difference between class fields and methods, and instance fields and methods? How do you create class fields and methods?
Instance fields and methods can be inherited from class fields and methods, but not vice versa. Class fields and methods are declared in the body of the class

### 7. How do you bring a static class in scope? Why would you want to bring a static class in scope?
Static classes can be brought into scope with Using statements, or by using a fully qualified name when you reference objects of the class. Example, Math.Sqrt(); You might bring static classes into scope to reference utilities available to that class

### 8. Can you think of a good reason to create an anonymous class? What is it?
Perhaps anonymous classes could return the value of "username" to the user, but not to any developer or database admin. They would only know that there is a username, but not the objects name.

### 9. What is polymorphism as this term is used in computer science? This is not in the book.
Polymorphism comes from using methods to overwrite the methods from the virtual class from which they're derived. It is a way of passing new arguments to methods with similar function

### 10. What is message passing as this term is used in computer science? This is not in the book.
Message passing is giving parameters to a method

### 11. What was the first object-oriented programming language?
Smalltalk

### 12. Consider this quote by Alexander Stepanov:

I find OOP technically unsound. It attempts to decompose the world in terms of interfaces
that vary on a single type. To deal with the real problems you need multisorted algebras
— families of interfaces that span multiple types. I find OOP philosophically unsound. It
claims that everything is an object. Even if it is true it is not very interesting — saying that everything is an object is saying nothing at all.

Who is Alexander Stephanov? What do you think about this quote?

Alexander Stephanov is the creator of the C++ standard template Library, and a proponent of generic programming, or not programming based around concepts such as objects. After doing a bit of reading regarding object oriented programs, it seems that they create layers of complexity to enforce the relationships between objects and their behaviors. I can understand how to an expert in computer science, this would be a limitation, but to a notice, thinking about real world objects is a reassuring familiarity amidst a torrent of confusing new information. Does the effect of having so many bad programmers using OOP outweigh having so many new ideas from that new blood?
