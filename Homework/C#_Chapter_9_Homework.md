## Steven Rhodes
### C# Homework Chapter 9

### 1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols,like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?
	enum ERanks{AB,Amn,A1C,SrA,SSgt,TSgt,MSgt,SMSgt,CMSgt}

### 2. Using the Ranks enum, assign a rank to yourself or a friend.
ERank steven;
steven = ERank.SrA;

###3. Determine the numeric index of particular ranks, using the Ranks enum.
Console.WriteLine((int)steven);

### 4. How do you select the type of an enum?
enum ERank : double {AB, Amn, A1C ...}

### 5. Are structs stored on the stack or on the heap? What about enums?
Structs are stored on the stack because they hold a value in memory, unlike classes, which are stored on the heap and store references. Enum values are stored on the stack.

### 6. Declare a struct named DOD with four branches.
	struct DOD
	{
		private bool ar, af, ny, mar;
		public DOD(bool army, bool air_force, bool navy, bool marines)
		{
			this.ar = army;
			this.af = air_force;
			this.ny = navy;
			this.mar = marines;
		}
		public bool GetBranch()
		{
		return this.ar;
		return this.af;
		return this.ny;
		return this.mar;
		}
	}

### 7. Why can’t you create a default constructor for a struct?
The C# compiler ALWAYS generates a default constructor for a struct

### 8. What is CIL? What does the CLR do to the CIL?
The common intermediate language is pseudo-machine code. Using a set of instructions, the compiler converts high level code like C# or F#, into an assembly that is further interpretted by the common language runtime into machine code which is readable by the CPU.

