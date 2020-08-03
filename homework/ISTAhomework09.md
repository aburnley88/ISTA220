## Arnold Burnley
## August 3rd, 2020
## ISTAhomework09.md



### Read chapter 9 in the C# Step by Step book.Discussion Questions
### Answer the discussion questions in writing.

1. What is an enum?

A programable value type whose values are limitied to a set of symbolic names. 

2. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols,
like Private, Corporal, Sergeant or Lieutenant, Captain, Major?

enum AfEnlisted { AB, Amn, A1C, SrA, SSgt, TSgt, MSgt, SMSgt, CMSgt }

3. Using the Ranks enum, assign a rank to yourself and a friend.

AfEnlisted Burnley = AfEnlisted.SSgt;
AfEnlisted Torretti = AfEnlisted.A1C;

4. Determine the numeric index of particular ranks, using the Ranks enum.

enum AfEnlisted { AB = 1, Amn, A1C, SrA, SSgt, TSgt, MSgt, SMSgt, CMSgt }

5. How do you select the type of an enum?

enum AfEnlisted : string { AB, Amn, A1C, SrA, SSgt, TSgt, MSgt, SMSgt, CMSgt }

6. What is a struct?

A structure is very similar to a class except that it is a value type. 
7
. List some differences between classes and structs.

* Instaces of class are on the heap and instances of structs are on the stack
* Compiler desn't automatically initialize fields with structs but does with classes
* Cannot declare default constructor for struct but you can for class

8. Are structs stored on the stack or on the heap? What about enums?

Both structs and enums are stored on the heap.

9. Review the documentation for the C# System.Int32 struct. List the fields. List the methods.

fields = MaxValue and MinValue
methods = comparesto, equals, gethascode, gettypecode, parse, tostring, tryformat, tryparse

10. Declare a struct named DOD with four branches.

Struct DOD
{ private string USMC = "U.S. Marine Corps";
private string USAF = "United States Air Force";
private string USA = "United States Army"
privaet string USCG = "US Couast Guard"}

11. Why can’t you create a default constructor for a struct?

The reason you cant declare your own default constructor for a structure is because the compiler always generates one.
The conpiler generated default constructor for a struct always sets the fields to 0, flase, or null just as for a class. 

12. What is CIL? What does the CLR do to the CIL?

Cmommon intermeddiate language.
CKR compiles CIL to machine-readable code that can be executed on the current platform.

