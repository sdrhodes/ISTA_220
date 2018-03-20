## Steven Rhodes
### C# Homework Chapter 11

### 1. How do you define a method that takes an arbitrary number of arguments?
You use the param list to accept a parameter array as an argument with n values in the array.
Example:
	int myMethod{params int[] myArray}

### 2. How do you call a method that takes an arbitrary number of arguments?
		myMethod{0, 1, 2, 3 ... n} 

### 3. Why can’t you use an array to pass an arbitrary number of arguments to a method?
Because you have to populate an array, and the array has a limited number of indexes which are defined in the creation of the array.

### 4. How many parameters can a method have?
Using a param array, a method can accept any amount of arguments of a specific type, such as int

### 5. Do parameter arguments have to have the same type?
Parameters arrays must be of the same defined type, unless you create a params object array, which accepts arguments of any type

### 6. What is the difference between a method that takes a parameter argument and one that takes optional arguments?
Optional arguments are still written by the compiler at runtime, using default arguments. The method will still have a fixed parameter list. Param arrays passed to a method use an arbitrary list of parameters, none of which have a default value.

### 7. How do you define a method that takes different (and arbitrary) types of arguments?

myMethod(params object [] myList)

