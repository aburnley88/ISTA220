# Arnold Burnley
## c#homework05.md
## July 19th 2020

C# Programming Homework Homework 05
Chapter 05, C# Step by Step
Readings
Read chapter 5 in the C# Step by Step book.
Discussion Questions
Answer the discussion questions in writing.

1. What is a compound assignment operator? How does it work?

a compound operator is an arithmetic operator coupled with the equal sign (ie: +=,  /+, etc). The operator
takes a variable and a number or string and updates the variable value according to the arithmetic operator and the number.

2. List all the compound assignment operators.
 =, +=,-=, /=, %=

3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50

int numeric =+ 5;
int numeric = numeric + 5;
int numeric -=50;
int numeric = numeric -50;

4. How long does a while loop run?

While the boolean expression in the parentheses evaluates to true.

5. What is an iteration variable? (Not in book)

The test variable.

6. What happens if you don’t change the loop variable in the body of the while loop block?

It runs forever.

7. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of
them? What happens if you omit all of them?

A for loop statement has 3 parts: initialization, Boolean expression, update control variable. You can omit any of the 3 parts, and you
get an infinite loop.

8. How do you guarantee that a loop runs at least once?

By using a do while loop.

9. What does the break statement do?

Exits the body of an iteration statement.

10. What does the continue statement do?

A continue statement causes the program to perform the next iteration of the loop immediately.

11. (Thought question) Can you think of any reason why you would want to have an infinite loop? An
“infinite loop” is a loop without an update variable that in effect runs forever. As you will see, these
kinds of loops are written intentionally to perform various kinds of tasks.

I think you would run a continuous loop for some type of back end processing.
