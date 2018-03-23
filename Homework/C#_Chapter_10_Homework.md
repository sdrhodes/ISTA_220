## Steven Rhodes
### C# Homework Chapter 10

### 1. What does an array look like in memory?
An array is a bundled contiguous block of memory stored on the heap, with the memory address on the stack pointing to the heap

### 2. Where is memory allocated to hold an array, on the stack or on the heap?
Memory is allocated to hold an array in the heap, with the memory address on the stack

### 3. Where is memory allocated to hold an array reference, on the stack or on the heap?
An array reference is allocated in the stack

### 4. Can an array hold values of different types? This is a trick question, the answer is, “It depends.”
An array can hold objects, objects can be references or values

### 5. Describe the syntax of the condition for a foreach loop.
int[] pins = {9,3,7,2};
foreach (int pin in pins)
{Console.WriteLine(pin)}

int[] pins creates an array and initializes it with values 9,3,7,2
the foreach line creates a variable "pin" and states for each value in the pins array, print the value to screen, and continue until you print all values in the array

### 6. How do you make a deep copy of a array?
You have to serialize the array and copy the binary.

	public static class GenericCopier<T>    //deep copy a list
    {
        public static T DeepCopy(object objectToCopy)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, objectToCopy);
                memoryStream.Seek(0, SeekOrigin.Begin);
                return (T)binaryFormatter.Deserialize(memoryStream);
            }
        }
    }

### 7. What is the difference between a multi-dimensional array and an array of arrays?
A multi-dimensional array can have more than two coordinates, for example, x,y,z
An array of arrays causes the index in an array to point to the start of another array
	multi[x,y]
	arrofarr[x],[y]

### 8. How do you “flatten” a multidimensional array? In other words, take something that looks like a matrix and turn it into an array [1, 2, 3, 4, 5, 6, 7, 8, 9]?
You can use a foreach loop to iterate through all the items in the array



