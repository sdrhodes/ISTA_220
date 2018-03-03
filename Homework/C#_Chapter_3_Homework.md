## Steven Rhodes
### C# Homework Chapter 3

### 1. What is a method?
A named location in memory that references a behavior. A sequence of statements

### 2. What does a return statement do?
It returns a value and steps out of the method

### 3. What is an expression bodied method?
An expression bodied method is a simple way to write a method. Example: 
		
	private void newMethod(arg1, arg2) => arg 1 : 0, arg 2 : "red"; 
Default arguments can be set in the same line where the method is created

### 4. What is the scope of a variable?
A scope of a variable is the portion of code where the variable is usable and has a definition (value). Determined by where the variable is nested in relation to methods using the variable

### 5. What is an overloaded method?
An overloaded method is a method with different parameters operating with the same name. Example, 

	newMethod(arg 1, arg 2, arg 3), and newMethod() . newMethod is an overloaded method

### 6. How do you call a method that requires arguments?
You call the method by name, and assign arguments. Example: 

	callMe(red, blue);

### 7. How do you write a method, that is, specify thet method definition, that requires a parameter list?
Methods that require parameters will not assign a value in their method declaration
Example: 

	newMethod(giveValue, giveSecondValue); requires parameters when the method is called

### 8. how do you write a method that contains optional parameters?
Optional parameters are assigned an initial value when the method is declared. For example:
		newMethod(arg1 = 1, arg2 = 2);

### 9. How do you pass an argument to a method as a named parameter?
A named parameter will be specified in the argument when the method is called, Example: 		
		newThing( arg1 : 1, arg2 : "Does This");