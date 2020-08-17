## Arnold Burnley
## ISTAHomeworkChp11.md
## August 10th, 2020


Answer the discussion questions in writing.
1. What is a parameter array?

A parameter array is a type of array that allows a procedure to accept an array of values for a parameter.

2. How do you define a method that takes an arbitrary number of arguments?

pubic static int Min(int[] paramList)
if(paramList == null || paramList == 0)
{
throw new ArgumentException("not enough arguments)
}
foreach (int i in paramList)
{
if (i<currentMin)
{
currentMin = i;
}
}
3. How do you call a method that takes an arbitrary number of argiments?

Class name, accessor, method, open parentheses, parameters, close parentheses.

4. Why can’t you use an array to pass an arbitrary number of arguments to a method?

The compiler generates code that inserts the default values onto the stack for any missing arguments before the method runs, and the method is not aware of which 
of the arguments are provided by the caller and which are compiler-generated defaults. 

5. How many parameters can a method have?

Any amount.

6. Do parameter arguments have to have the same type?

No as long as params object[] paramList was used in the argument of the method.

7. What is the difference between a method that takes a parameter argument and one that takes optional
arguments?

Optional parameters on a method is still a fixed list whereas parameter arguments aren't a fixed amount. 

8. How do you define a method that takes different (and arbitrary) types of arguments?

with params object[] paramList

9. Write a method that accepts any number of arguments of a given type.

public static int Min(int[] paramList)

10. Write a method that accepts any number of arguments of any type.

public static void Hole(params object[] paramList)