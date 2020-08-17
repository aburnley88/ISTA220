## Arnold Burnley
## ISTA220HomeworkChp12.md
## August 11th, 2020


1. How does inheritance promote the principle of don’t repeat yourself (DRY)?

The DRY principle is stated as "Every piece of knowledge must have a single, unambiguous, authoritative representation within a system". 
When the DRY principle is applied successfully, a modification of any single element of a system does not require a change in other logically unrelated elements. 
Additionally, elements that are logically related all change predictably and uniformly, and are thus kept in sync. 
Inheritance is an avenue to enforce these principles in C# programming.

2. What is the syntax of a derived class that inherits from a base class?

Class DerivedClass :nBaseClass
{
//Code goes here
}

3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?

All structs inherit from the System.ValueType class and the System.Object class is the root of all classes. 

4. What happens if you do not have a default constructor in a base class when creating a derived class?

If you don't explicitly call a base class-class constructor in a derived-class constructor, the compiler attempts to silently insert a call to the base class's 
default constructor before executing the code in the derived-class constructor. 

5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?

No you cannot because the derived method may not have access to that variable. 

6. Can you assign a variable of a derived class to another variable of of a derived class of its base class?
Why or why not?

Sill no because they are comletely different objects. 

7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?

Yes 
8. Under what circumstances would you want to use the new keyword when defining a method in a
derived class?

When the method of subject has the exact name and signatures as another method in the base class. This is called hiding. The new keyword turns off a warning message.

9. What is a virtual method? Why would you want to define a virtual method?

A method that is intended to be overriden. One would want to define a virtual method to override that method in a derived class and give the method new functionality
specific to the dervied class. 

10. What does override do? Why does it do it?

The override keyword declares another implementation of that method.  It does it so that new code (separate and new code from the original virtual method) can be
written into the method and the owning class can use the method according to it's needs. 

11. How do you define an extension type?

You define an extension method in a static class and specify the type to which the method appplies as the first parameter to the method , along
with the this keyword.

12. Why do you define an extension type?

To quickly extend a type without affecting existing code. 

13. (Not in book) Explain the Liskov substitution principle.

The principle defines that objects of a superclass shall be replaceable with objects of its subclasses without breaking the application. 
That requires the objects of your subclasses to behave in the same way as the objects of your superclass. 