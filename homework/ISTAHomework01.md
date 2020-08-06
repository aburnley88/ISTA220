## Arnold Burnley
## ISTAHomework10.md
## August 4th, 2020



**Discussion Questions**

**Answer the discussion questions in writing.**

1. What does an array look like in memory?

A contiguous(side-by-side) block of memory holding the array elements on the heap.

2. Where is memory allocated to hold an array, on the stack or on the heap?

On the heap.

3. Where is memory allocated to hold an array reference, on the stack or on the heap?

On the stack.

4. Can an array hold values of different types? This is a trick question, the answer is, “It depends.” What
determines the types that an array can hold?

An array can only hold different types if it the type is implicit such as var numbers = new[]{1, 2, 3.5, 99.99};
3.5 and 99.99 are doubles so the compiler coverts the others to doubles. You can also create an array of anonymous types. 

5. Describe the syntax of the condition for a foreach loop.

THe *foreach* statement declares an iteration variable that automatically acquires the value of each element in the array, and performes some block of code
for each index.

6. How do you make a deep copy of a array?

Using a for loop and a CopyTo method. It has to be done element by element.

7. What is the difference in the syntax between a multi-dimensional array and an array of arrays?

int [] pins = {1, 2, 3, 4,};
int [] [] = ArrayOfArrays;
int [,] = MultiDimensionalArray;
8. What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words,
what determines whether you would use one as opposed to the other?

A multi-dimensional array is a with multiple dimensions to the single array, whereas an array of arrays is a list of of other lists.
9. How do you “flatten” a multidimensional array? In other words, take something that looks like a

matrix


1 2 3
4 5 6
7 8 9

 and turn it into an array [1, 2, 3, 4, 5, 6, 7, 8, 9]? Write the code to do this in English.

I would use a cast like so : type.cast<arraytype>().ToArray();

10. (Thought question) When we use a for loop, we can change the values of the array elements inside
the loop. When we use a foreach loop, we cannot change the values of the arry elements inside the
loop. Why not? How is for different from foreach?

The foreach only references thes addresses while the for loop can access and manipulate the data directly. 
