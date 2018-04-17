## Steven Rhodes
### C# Homework Chapter 18

### 1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticked just submitted. What kind of data structure would you use, and why?
You would use a queue so the first in would be first out.

### 2. You are building a tracking system for seasonal agricultural farm labor. Te labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated first, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?
You would use a stack since it is last in, first out

### 3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?
A list so you can add things to the beginning and end

### 4. You are building an analytical database. Your requirement is that the database handle queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?
Sorted lists or hash maps, also dictionaries would work.

### 5. You are building a personnel directory, where searched are performed by last name, first name, middle name. What kind of data structure would you use, and why?
Dictionaries or sorted list are identified and retrieved using keys rather than indexes

### 6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happen extremely quickly. What kind of data structure would you use, and why?
Linked list


### 7. What is a lambda expression? Give an example. Why would we use a lambda expression?
A lambda expression is an expression that returns a method
Person match = personnel.Find(p => p.ID ==3);

### 8. What is the difference between lambda expressions and anonymous methods? What are the advantages of each?
Anonymous methods were added primarily so that you can define delegates without having to create a named method- you simply provide the definition of the method body in place of the method name

