## Steven Rhodes
### C# Homework Chapter 14

### 1. What is the difference between a managed resource and an unmanaged resource?
A managed resource is something managed by the CLR. Unmanaged resources are not managed by the CLR.

### 2. When is memory for an object (reference type) allocated? When is the memory deallocated?
Memory for an object is allocated when "new" is used. Memory is deallocated when the garbage collector runs and the CLR chooses to deallocate memory

### 3. What is a destructor?
A destructor is a method that the CLR calls after references to an object have disappeared. Clears out the heap.

### 4. What is the difference in syntax between a constructor and a destructor?
a constructor uses a tilde ~, and can never be called. Destructors cannot accept parameters and cannot list access types

### 5. Give some examples of scarce resources. Why would you want to manage scarce resources?
Scarce resources may include bandwidth, a phone line (for fax), connection to a printer. These resources are accessed by many programs, and possibly other users. They must be managed appropriately

### 6. What is exception-safe disposal?
Exception-safe disposal refers to ensuring disposal occurs even if an exception is thrown in the middle of a process. A finally block can be a solution to this

### 7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.
Using statements define scope, just like namespaces or classes. They ensure that resources are freed when the block runs and the resources drop out of scope

### 8. What ill effects could result from attempting to dispose of a resource more than once?
Disposal of a resource while multiple threads are accessing it could result in serious errors

### 9. We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a sufficient answer to this question.
Threads are multiple processes occurring simultaneously. A resource could be accessed by multiple threads depending on how the compiler determines which processes execute most efficiently

### 10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?
The book mentions using GC.Collect as being inefficient and potentially dangerous. I assume forced garbage collection could be run before closing a program.


