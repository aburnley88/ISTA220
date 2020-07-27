# Arnold Burnley
## c#programmingHomework06.md
### 07/21/2020


### Readings
### Read chapter 6 in the C# Step by Step book.
### Answer the discussion questions for chapter 6 in writing.

1. What is an exception?

An exception is an error.

2. What happens in a try block if the program executes without errors?

All the lines of code runs one after another until completion.

3. How does the catch mechanism work for unhandled exceptions?

If there is no matching catch handler, the calling method immediately exits, and execution returns to its caller, where the process is repeated.

4. What happens in a program if an exception block fails to handle an particular error?

The program will terminate with an unhandled exception.

5. What is the parent class for all exceptions? How does this work?

Exception is the parent class.

6. How do you determine the type of an error?

By using the message property of the exception object. 

7. What is the purpose of integer checking?

To prevent integer overflow.

8. What is the range of values than a signed Int32 type can contain? State the lowest value and the
highest value.

-2,147,483,648 to 2,147,483,648

9. What is the range of values than an unsigned Int32 type can contain? State the lowest value and the
highest value. What is the difference between a signed integer and an unsigned integer? Can signed
integers and unsigned integers represent the same amount of numbers?

0 to 4,294,967,295

10. What does the finally block do?

A finally block occurs immediately aftter a *try block* or immediately after the last catch handler after a try block. 
As long as the program enters the try block associated with a *finally block*, the finally block will always be run.



