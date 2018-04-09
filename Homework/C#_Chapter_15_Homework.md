## Steven Rhodes
### C# Homework Chapter 15

### 1. What is the difference between a property and a field?
Properties are accessed similarly to fields, but the compiler generates accessor methods in the form of getters and setters.

### 2. What is the difference between a property and a method?
Methods represent actions, and properties represent data. Properties can't accept arguments. If you need to perform any calculations on data, methods are the way to go.

### 3. What is your understanding of encapsulation?
Encapsulation is the concept of modularizing functionality in code that hides some inner workings from the user. Certain properties, methods, or fields might be exposed to the users, others might not depending on your needs

### 4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter.C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?
I personally believe that case difference alone would be grounds for many potential headaches. The use of underscore preceeding names seems like a good solution

### 5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use a write-only property.
An example of a read only property might be wheelnumber = 4 for a car. A write only property might be similar to a password, a PIN for an ATM.

### 6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.
Reasons to set get/set private would be to allow users to utilize the property without necessarily having both the functionality of get and set. Maybe setting the value is appropriate for your application, or maybe just retrieving the value (get) is suitable. It would vary by application. I could see wanting to expose the workings (property) values, but not allowing users to change it.

### 7. What are restrictions on the use of properties?
Must be initialized before value is assigned, can't be used as ref or out, only one get/set, no parameters, can't declare const properties

### 8. What is an object initializer? What is the syntax for an object initializer?
Object initializers allow for the construction of new object with default properties "preloaded" and available at the instance of object instantiation. You can also override some default objects, if a corresponding set accessor is available to write to the value.

The syntax is Object object = new Object("Parameter parameter") {property1= 1, property2 = 2}
