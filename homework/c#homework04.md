#Arnold Burnley
##C-Sharp homework04
###July 14th, 2020


1. What are all possible values of Boolean expression?

True or False.

2. List the equality operators. List the relational operators. List the logical operators. How are they the
same? How are they different?

Equality: ==,!=,  Relational: <, <=, >, >= Logical: &&, ||, and NOT


3. What is the general concept of short circuiting? This question has a short and simple answer and you
do not need to have a detailed response.

Short circuiting is a technique of ordering your expressions in a way that the left side expression is
the easier expression. This allows for faster processing because if the first expression to be evaluated
is either true or false the whole expression is that value.


4. What are the difference in how short circuiting works for && and ||?

For logical or if the first expression is false then the 2nd expression must be evaluated,
whereas with && if the first expression is false the entire statement evaluates to false.

5. Look at the list of operators. What operator has the highest precedence? Which has the lowest?

Relational operators have the highest precedence and conditional or has the lowest.

6. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?

Curly braces group statements of code. A block starts a new scope with which you can define a new variable
but they will disappear at the end of the block.

7. In a switch statement, what happens if you omit break?

Without break, the program continues to the next labeled statement, executing the statements until a break or the end of the statement is reached.

8. The four keywords in a switch statement are switch, case, break, and default. Explain what each
keyword does.

Switch declares a switch statement along with a controlling Boolean expression.//specifies a pattern to match

Case statements declare what actions get carried out if the particular case is True.

break tells the compiler to exit the code and continue processing

default is the case that is used if no other case is true

9. Look at the source listing below. It contains two methods: recurr1() and recurr2(). There is a
significant difference between the two methods. What is it?

The second method has 2 parameters and carries its return values with it.


10. (Not in book) What is a recursive method? Using a language you know (such as English), write a
recursive method that adds up the integers in a list of integers. The input to the method is a list of
integers and the output is a scalar value representing a sum.

A recursive method is one that calls itself.

11. (Not in book) Read a short summary of De Morgan’s laws.

(a) Explain how this statement, ”It’s not snowing or raining,” is the same as this statement, ”It’s not
snowing and it’s not raining.”
(b) Explain how this statement, ”I’m not running and walking,” is the same as this statement, ”I’m
not running or I’m not walking."
