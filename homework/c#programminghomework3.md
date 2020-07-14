1. What is a method?

A method is a named sequence of statements.
A method is a named block of code. Block =  sequence of statements in curly braces.

2. (Not in book) What is the dierence between a function and a procedure/subprocedure/subroutine?
A function must return value while a procedure is a set of commands to be followed and returning value is optional. Functions can be called from procedures
but procedures cannot be called from a function.


3. What does a return statement do?

An avenue to have a method to return information of the same type specified by the method declaration.

4. What is an expression bodied method?
The main difference is the use of the => operator; functionally there is no difference.

5. What is the scope of a variable?
The region of the program in which that variable is usable.

6. What is an overloaded method?
When 2 identifiers have the same name and are declared in the same scope.

7. How do you call a method that requires arguments?

Method name with parentheses and inside those parentheses are the arguments separated by commas, ended by a semi-colon.

8. How do you write a method, that is, specify the method denition, that requires a parameter list?

accessor, if static identify it as so otherwise nothing, return type open parentheses, parameters, close parentheses,
semi-colon.
return type
name
parameter list
body


9. How do you specify a parameter as optional when dening a method?
Specify a parameter as default by assigning it a default value in the definition.

10. How do you pass a argument to a method as a named parameter?
With the ':'. Example nameGenerator(fName: 'Arnold', lName: 'Doesit');

11. How do you return values from a method? Can you return multiple values from a method, and if so,
how?
With a return statement. You can return multiple values by specifying a list of types as part of the method definition.

12. What is a tuple? How do you dene a method that returns multiple values? Give an example of a
method that returns multiple values other than the example in the book.

int list = Tuple.Create("gren", 5, "apple, 9);
return list.Item1 , list.Item2;

A tuple is a data structure that contains a sequence of elements of different data types.

13. Examine the method denition on page 83 of the book. Desk check the execution of this method.
What do you discover? This is called recursion.
long factorial(int dataValue)
2 f
3 i f ( dataValue == 1)
4 r e turn 1 ;
5 el se
6 r e turn dataValue  f a c t o r i a l ( dataValue ?? 1) ;
7 g
Recursion is when a method calls a method.

14. How does the compiler resolve an ambiguity between named arguments and optional parameters?

It compiles the version that most closely matches the method call.

15. The book states: A key feature of C# and other languages designed for the .NET Framework is the
ability to interoperate with applications and components written with other technologies." What is
the COM and how is the CLR dependent on the COM?
