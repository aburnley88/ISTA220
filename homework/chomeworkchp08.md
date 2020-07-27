## Arnold Burnley

## FileName: chomeworkchp08.md

## Date: 07/27/2020


Answer the discussion questions in writing.

1. What is the difference between deep copy and shallow copy?

A deep copy is when an object is copied with all of its contents. A shallow copy is when only the referencees are copied.

2. What is the value of a reference after you declare and initialize it?



3. How do you declare a value type?

Most primitive data types are value types like int, float, double, and char. 

4. How do you declare a reference type?

All objects are reference types and strings are as well.

5. Does C# allow you to assign NULL to a value type?

Yes if you append a '?' after the type like so

int? = NULL;

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?

With the '?' 

7. What is the difference between the stack and the heap?

The stack is for methods and stores the methods loacl variables and the memory for its local variables. When an object is created the memory required to build the object 
is always acquired from the heap.

8. What does it mean when we say that all classes are specialized types?

9. What does ref do?

If you prefix a parameter with the ref keyword, the C# compiler generates code that passes a reference to the actual argument rather than a copy of the argument.
When using a ref parameter, anything you do to the parameter you also do to the original argument beause the parameter and the argument both reference the same data. 

10. What does out do?

You can prefix any parameter with the out keyword so that the parameter becomes an alias for the argument. The keyword stands for output. When you pass
an out parameter to a method, the method must assign a value to it before it finishes or returns.

11. Describe boxing and unboxing in your own words.

Boxing is turning a referene type to a value type and a value type to a reference type. 

12. What does cast do?

Casts tells the compiler that the data referenced by an object has a specified type specified in the cast statement.