#### Arnold Burnley  
#### ISTA220HomeworkChp13.md  
#### August 17th 2020



**Answer the discussion questions in writing.**  

**1. What is an interface as the term is used in object-oriented programming?**  

An interface is an inheritable object that creates abstract method signatures that derived classes must implement with their own unique fields and method body.

**2. How do you define an interface?** 

You use the *interface* keyoword. Within the interface, you declare methods exactly as in a claass or structure, except that you never specify an access modifier.  
Additionally, the methods in an interface have no implementation; they are simply declarations, and all types that implement the interface must provide their   
own implementations.  

**3. Can an interface have variables, fields, or properties?**  

No.


**4. How do you define a method in an interface?**  

You define a method in an interface with the return type, method name, parameters, and a semi-colon.  

**5. Can you instantiate an object through an interface? Why or why not?**  

No you cannot because then evey class that uses the interface would have to instantiate the object, and interfaces are only for methods.


**6. Using the new keyword, can you declare a reference to an interface?**

No.


**7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?**  

Yes. In the class defintion of the object the class name would be followed by a colon, the parent class, and all inherited interfaces separated by a comma. 
Here is an example of an object calling multiple interfaces:  

Horse horse = new Horse();
...  
Ijourney journeyHorse = horse;  
int legsInJourney = journeyHorse.NumberofLegs();  
ILandBound landBoundHorse = horse;  
int legsOnHorse = landBoundHorse.NumberofLegs();  

**8. What does it mean to explicitly implement an interface?**  

It means explicitly adding the interface name to the method call in the object that uses the interface.  

**9. What are the restrictions on interfaces?**  

* You're not allowed to define any fields in an interface.  
* You're not allowed to define any constructors in an interface.  
* You're not allowed to define a deconstructor.  
* You cannot specify any acces modifiers.  
* You cannot nest any types.  
* An interface is noty allowed to inherit from a structure or class.  

**10. What is the difference between an abstract class and an interface?**  

Abstract classes can contain code and data. However, you can specify certain methods of an abstract class as virtual so that a class that inherits from  
the abstract class can optionally provide its own implementation of these methods.  

**11. What is an abstract method?**  

An abstract method is similar to avirtual method except that it donesnt contain a method body, and a derived class must override this method.  

**12. What is an sealed class?**  

A sealed class is one that cannot be used as a base class.  

**13. What is an sealed method?**  

The sealed keyword can be used to declare that an individual method in an unsealed class is sealed. This means that a derived class cannot override this method.