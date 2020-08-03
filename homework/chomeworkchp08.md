## Arnold Burnley

## FileName: chomeworkchp08.md

## Date: 07/27/2020


Answer the discussion questions in writing.

1. What is the difference between deep copy and shallow copy?

A deep copy is when an object is copied with all of its contents. A shallow copy is when only the references are copied.

2. What is the value of a reference after you declare and initialize it?

A named memory location on the heap.

3. How do you declare a value type?

Most primitive data types are value types like int, float, double, and char. 
You declare the type, the name, and the value. 

4. How do you declare a reference type?

Use new keyword to create an instance of the object. 

5. Does C# allow you to assign NULL to a value type?

Yes if you append a '?' after the type like so

int? = NULL;

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?

No

7. What is the difference between the stack and the heap?

The stack is for methods and stores the methods loacl variables and the memory for its local variables. When an object is created the memory required to build the object 
is always acquired from the heap.

9. What does ref do?

If you prefix a parameter with the ref keyword, the C# compiler generates code that passes a reference to the actual argument rather than a copy of the argument.
When using a ref parameter, anything you do to the parameter you also do to the original argument beause the parameter and the argument both reference the same data. 

10. What does out do?

You can prefix any parameter with the out keyword so that the parameter becomes an alias for the argument. The keyword stands for output. When you pass
an out parameter to a method, the method must assign a value to it before it finishes or returns.

11. Describe boxing and unboxing in your own words.

Boxing is turning a value type and turn it into a reference type. You place the value type on the heap when boxing. Unboxing is when you take the value type off of the   
heap and change it back into a reference type. 

12. What does cast do?

Casts tells the compiler that the data referenced by an object has a specified type specified in the cast statement.