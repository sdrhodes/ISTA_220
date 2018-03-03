## Steven Rhodes
### C# Homework Chapter 1

### 1. What is a console app?
A console application is a command line interface that writes and accepts user input from typed commands. In command prompt

### 2. what does main () do in a console application? 
When code is compiled, main() determines the starting point of the application

### 3. what is the purpose of a namespace? 
namespaces are containers or repositories used to organize classes. they allow for classes of the same name to be used in a program by invoking the fully qualified class name, ie system.console

### 4.Describe specifically what using statements do. 
using statements allow developers to use multiple namespaces. It allows the use of classes without fully qualified names. Bring namespace into scope

### 5.What is an assembly?
An assembly is a collection of classes with related functionality that can be used in programs. Programs can be use classes from multiple assemblies. Contains compiled code.

### 6. What is the relationship between assemblies and namespaces?
An assembly can consist of classes used in multiple namespaces. A namespeace can use classes from many assemblies Remember to add a reference to the assembly you wish to use before adding a using statement for the namespaces

### 7.What is a graphical app?
 A graphical app uses images and text, elements in an interface that displays information and accepts input from users

### 8. What is the starting point in a graphical app? 
App.xaml contains code in the OnLaunched method that initializes the program


### 9. What does build do? 
Build compiles the code and creates an executable that can be ran by users

### 10. What does debug do? 
Debug checks the code for runtime errors