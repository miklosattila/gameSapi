using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catolog.Migrations
{
    class Question
{
    public string Text { get; set; }
    public List<string> Answers { get; set; }
    public string CorrectAnswer { get; set; }
    public string Justification { get; set; }
    public string Hint { get; set; }
    public int Score { get; set; }
}
    /// <inheritdoc />
    public partial class InitialData3 : Migration
    {
        public string text = @"
        1 Question: Can a variable name start with number in C? 	
        Answers: 
        Yes 
        No 
        Correct answer: No 
        Justification: The first letter of a variable can be a letter or an underscore.
        Hint: 
        Score: 10
        
        
        2 Question: Int data type’s format specifiers are the %d and %I? 	
        Answers:
        Yes
        No
        Correct answer: No 
        Justification: The int data types has 2 format specifiers: %d and %I.
        Hint:
        Score: 10
        ";
        public string text2 = @"
1 Question: Can a variable name start with number in C? 	
Answers: 
Yes 
No 
Correct answer: No 
Justification: The first letter of a variable can be a letter or an underscore.
Hint: 
Score: 10


2 Question: Int data type’s format specifiers are the %d and %I? 	
Answers:
Yes
No
Correct answer: No 
Justification: The int data types has 2 format specifiers: %d and %I.
Hint:
Score: 10




3 Question: Which data type is used to store whole numbers in C?
Answers:
Int
Float
Correct answer:  int
Justification: The 'int' data type is used to store whole numbers (integers) in C.
Hint: 
Score: 10

4 Question: What is the size of the 'float' data type in C?
Answers: 
 4 bytes 
 8 bytes 
Correct answer: 4 bytes
Justification: The 'float' data type in C typically occupies 4 bytes of memory.
Hint: 
Score: 10

5 Question: Which data type is used to store characters in C?
Answers: 
 Float
 Char 
Correct answer: char
Justification: The 'char' data type is used to store individual characters in C.
Hint: Characters in C are enclosed in single quotation marks, such as 'A' or '5'.
Score: 10



6 Question: What is the size of the 'double' data type in C?
Answers: 
4 bytes 
8 bytes 
Correct answer: 8 bytes
Justification: The 'double' data type in C typically occupies 8 bytes of memory.
Hint: The 'double' data type is used to store double-precision floating-point numbers.
Score: 10

7 Question: Which data type is used to store large whole numbers in C?
Answers: 
int
long 
Correct answer: long
Justification: The 'long' data type is used to store large whole numbers (integers) in C.
Hint: The 'long' data type typically uses 8 bytes of memory.
Score: 10

8 Question: Which format specifier is used to print a floating-point number in C?
Answers: 
%d 
 %f 
Correct answer: %f
Justification: The format specifier %f is used to print a floating-point number in C.
Hint: %f is used for single precision; 
Score: 10



9 Question: What is the format specifier used to print an unsigned integer in C?
Answers: 
%d 
%u 
Correct answer: %u
Justification: The format specifier %u is used to print an unsigned integer in C.
Hint: Remember to use the correct format specifier to avoid printing incorrect values.
Score: 10

10 Question: Which of the following statements is incorrect regarding file handling in C?
Answers:
The fprintf() function is used to write formatted data to a file. 
The fopen() function is used to read formatted data.
Correct answer: The fopen() function is used to read formatted data.
Justification: The fopen() function is used to open a file,  the fscanf() function is used to read data. 
Hint: Make sure to use the appropriate function to close a file after performing file operations.
Score: 10










11 Question: What is the format specifier used to print a character in C?
Answers: 
%c 
%d 
%f
Correct answer:  %c
Justification: The format specifier %c is used to print a character in C.
Hint: Use %c along with the corresponding character variable or value to print a character.
Score: 15


12 Question: Which data type is used to store true/false values in C?
Answers: 
float 
Char
bool
Correct answer: bool
Justification: The 'bool' data type is used to store true/false values in C.
Hint: The 'bool' data type was introduced in the C99 standard.
Score: 15








13 Question: What is the role of 	double data type?
Answers:
Double is used to hold real numbers 
Double is used to hold characters
Double is used to hold integers 
Correct answer: Double is used to hold real numbers 
Justification: The main role of double is to hold real numbers.
Hint:
Score: 15


14 Question: What is the size of a char variable?	
Answers:
1 byte
2 bytes 
4 bytes 		
Correct answer: 2 bytes
Justification: The size of a char is 1 byte.
Hint:
Score: 15









15 Question: Which function is used to open a file in C?
Answers: 
fopen()  
fread() 
fwrite()
Correct answer: fopen()
Justification: The fopen() function is used to open a file in C and returns a pointer to the opened file.
Hint: The fopen() function requires specifying the file name and the mode in which the file should be opened.
Score: 15



16 Question: The wrong statement indicates what direction you must go.	
Answers:
The printf() sends formatted output to the screen 
The scanf() is an output function 
To use printf() we need to include the stdio.h library 
Correct answer: 
Justification: The scanf() is an input function, reads data from the standard input.
Hint:
Score: 15






2)Flow Control (Loops)
17 Question: What is the difference between the while and the do-while loop?
Answers: 
The body of the do-while is executed at least once, while loop’s body is executed when the test expression is true 
The body of the do-while is executed always more times than the body of the while loop 
Correct answer:  The body of the do-while is executed at least once, while loop’s body is 			    executed when the test expression is true 
Justification:   The body of the do-while is executed always at least once, then comes the 			the test expression. The body of the while loop is executed when the test 		            expression is true.
Hint: 
Score:  10


18 Question: Which statement is true?
Answers: 
The break statement skips the current loop and continues with the next iteration 
The break statement is used to jump out of a loop 
Correct answer:  The break statement is used to jump out of a loop 
Justification:   The break statement ends the loop and the continue statement skips the 			current loop.
Hint: 
Score:  10




19 Question: When the expression in the if-else statement is true, what’s happening? 
Answers: 
The codes inside the if body are executed 
The codes inside the if body are skipped from execution 
Correct answer:  The codes inside the if body are executed 
Justification: The codes inside the if body are skipped only when the expression in the 		           statement is false.  
Hint: 
Score:  10



20 Question: The expression in the if-else is false, which statement is true?
Answers: 
The codes inside the else body are skipped 
The codes inside the else body are executed 
Correct answer:  The codes inside the else body are executed 
Justification:  The codes inside the else body are executed when if-else statement is 		            false.
Hint: 
Score:  10








21 Question: What is the correct syntax for the while loop in C?
Answers:  
while (condition) { // loop body } 
while { // loop body } (condition) 
Correct answer: while (condition) { // loop body }
Justification: The correct syntax for the while loop in C is to specify the condition in parentheses followed by the loop body in curly braces.
Hint: The condition is checked before each iteration of the loop.
Score: 10


22 Question: Which loop control statement is used to prematurely terminate a loop iteration in C?
Answers: 
break 
continue 
Correct answer: break
Justification: The break statement in C is used to prematurely terminate a loop iteration and exit the loop.
Hint: The break statement is commonly used in combination with conditional statements to break out of a loop based on certain conditions.
Score: 10







23 Question: Which loop control statement is used to restart the current iteration of a loop in C?
Answers: 
continue 
return 
Correct answer: continue
Justification: The continue statement in C is used to restart the current iteration of a loop, skipping the remaining code within the loop body.
Hint: The continue statement is useful when you want to skip certain iterations based on specific conditions.
Score: 10

24 Question: What is the purpose of the 'do-while' loop in C?
Answers: 
To check a condition before executing the loop body 
To execute the loop body at least once, regardless of the condition 
Correct answer: To execute the loop body at least once, regardless of the condition
Justification: The 'do-while' loop is used to execute the loop body at least once, regardless of the condition. The condition is checked at the end of the loop.
Hint: Use a 'do-while' loop when you want to ensure that a specific action is performed before checking the condition.
Score: 10








	25 Question: Which loop in C is executed based on a condition at the end of the loop?
Answers: 
for loop 
while loop 
do-while loop 
Correct answer: do-while loop
Justification: The do-while loop in C is executed based on a condition at the end of the loop, ensuring that the loop body is executed at least once.
Hint: The condition is evaluated after the loop body in a do-while loop.
Score: 15





26 Question:  What is the correct syntax of the for loop?
Answers: 
for (initialization statement; update expression; test statement) 
for (initialization statement; test expression; update statement) 
for (test statement; update statement; initialization statement) 
Correct answer:  for (initialization statement; test expression; update statement) 
Justification:  The correct statement order in the for loop is: initialization 	         			            statement, test expression, update statement.
Hint: 
Score:  15

27 Question: Which loop in C executes its body at least once, even if the condition is initially false?
Answers: 
for  
while loop 
do-while loop 
Correct answer: do-while loop
Justification: The do-while loop in C executes its body at least once because the condition is evaluated after the loop body.
Hint: The syntax of the do-while loop is: do { // loop body } while (condition);
Score: 15





28 Question: Which loop in C is primarily used when the number of iterations is known in advance?
Answers: 
for loop 
while loop 
do-while loop 
Correct answer: for loop
Justification: The for loop in C is primarily used when the number of iterations is known in advance and provides a concise way to express looping.
Hint: The syntax of the for loop is: for (initialization; condition; increment/decrement) { // loop body }
Score: 15

29 Question: Which loop in C is most suitable for iterating over elements in a collection?
Answers: 
for loop 
do-while loop 
if statement
Correct answer: for loop
Justification: The for loop is most suitable for iterating over elements in a collection as it provides a compact structure for controlling the loop variable.
Hint: 
Score: 15







3)Functions
30 Question: Every function in C has a return type.	
Answers: 
The statement is false 
The statement is true 
Correct answer: The statement is true.
Justification: In C every function has got a return type (int, bool, void etc.)
Hint: 
Score: 10







31 Question: Every function in C has a return value.	
Answers: 
The statement is true 
The statement is false 
Correct answer: The statement is false.
Justification: When the function has void return type then the function doesn’t have return value.
Hint: 
Score: 10


32 Question: Which statement is true?	
Answers: 
The recursion makes the code more elegant but not so effective 
Loop iteration use more memory as the recursion 
Correct answer:  The recursion makes the code more elegant but no so effective. 
Justification:  The recursion makes the code more elegant but not so effective and use 		            more memory.
Hint: 
Score: 10











33 Question:  Which statement is true?	
Answers: 
Every function name is an identifier 
Every function must have at least one argument 
Correct answer: Every function name is an identifier
Justification: Every function name is an identifier and should be unique. A function can  		          be implemented without arguments.
Hint: 
Score: 10





34 Question: What is the return type of a function in C if it doesn't return any value?
Answers: 
void  
int 
Correct answer: void
Justification: If a function in C doesn't return any value, its return type is specified as void.
Hint: Void return type indicates that the function does not return a value.
Score: 10





35 Question: What is a recursive function in C?
Answers: 
A function that can only be called once in a program 
A function that calls itself during its execution  
Correct answer: A function that calls itself during its execution
Justification: A recursive function in C is a function that calls itself during its execution, either directly or indirectly.
Hint: Recursive functions are often used for solving problems that can be broken down into smaller sub-problems.
Score: 10

36 Question: How do you define a function in C?
Answers: 
Using the 'func' keyword followed by a function name 
Using the return type, function name, parentheses, and curly braces
Correct answer: Using the return type, function name, parentheses, and curly braces
Justification: A function in C is defined by specifying the return type, followed by the function name, parentheses for parameters (if any), and curly braces containing the function body.
Hint: The return type determines the type of value the function will return (if any).
Score: 10







4)Arrays 
37 Question: How do you find the average value of elements in an integer array in C?
Answers: 
By dividing the sum of all elements by the array size 
By using the sizeof() function to calculate the total size of the array
Correct answer: By dividing the sum of all elements by the array size
Justification: To find the average value of elements in an integer array in C, you need to calculate the sum of all elements and divide it by the array size.
Hint: Make sure to use floating-point division to get an accurate average value.
Score: 10

38 Question: How to declare a matrix with multidimensional array which has 2 rows and 3   		     columns? 	
Answers: 
int matrix [2][3]; 
int matrix [3][2];
Correct answer: int matrix [2][3]; 
Justification: Elements in two-dimensional arrays are commonly referred to by x[i][j] 		          where ‘i’ is the row number and ‘j’ is the column number.
Hint: 
Score: 10







39 Question: How to access the first element of an array?	
Answers: 
ArrayName[0] 
ArrayName[1] 
Correct answer:  ArrayName[0] 
Justification:  The first index of an array is always the 0.
Hint: 
Score: 10







40 Question: What is the index of the first element in an array in C?
Answers:
 0 
1 
Correct answer: 0
Justification: In C, the index of the first element in an array is 0. Array indexing starts from 0.
Hint: Keep in mind that array indices are zero-based.
Score: 10







41 Question: Can the size of an array be changed once it is declared in C?
Answers: 
 No, the size of an array is fixed and cannot be changed 
 Yes, by assigning a new size to the array variable
Correct answer: No, the size of an array is fixed and cannot be changed
Justification: In C, once an array is declared, its size is fixed and cannot be changed. It occupies a fixed amount of memory.
Hint: If you need dynamic resizing, consider using dynamic memory allocation with pointers.
Score: 10

42 Question: Can arrays in C store elements of different data types?
Answers: 
Yes, C arrays can store elements of different data types 
 No, arrays can only store elements of the same data type 
Correct answer: No, arrays can only store elements of the same data type
Justification: In C, arrays can only store elements of the same data type. The type of elements is determined at the time of array declaration.
Hint: If you need to store elements of different data types, consider using a structure or an array of structures.
Score: 10





43 Question: How do you access elements in a two-dimensional array in C?
Answers: 
Using a single index 
Using two indices separated by a comma Correct answer: Using two indices separated by a comma
Justification: In C, you can access elements in a two-dimensional array by using two indices separated by a comma, representing the row and column indices.
Hint: The first index represents the row, and the second index represents the column.
Score: 10



44 Question: How to declare an array?	
Answers: 
dataType [arraySize] arrayName; 
dataType arrayName [arraySize]; 
arrayName [arrayName]; 
Correct answer:  dataType arrayName [arraySize]; 
Justification:  The correct order for declare an array is: dataType [arraySize] arrayName;
Hint: 
Score: 15







45 Question: What is the index of last element in array?	
Answers: 
Array[ArraySize] 
ArraySize-1 
Array[ArraySize-1] 
Correct answer: ArraySize-1 
Justification: The last index in array is the arraySize-1 because the first index is at 0.
Hint: 
Score: 15


46 Question: How to initialize an array during the declaration?	
Answers: 
int array[5] = (1,2,3,4,5); 
int  array[] = {4,1,2,3,0}; 
int array[] = (1,3,5,3,1); 
Correct answer: int array[] = {4,1,2,3,0}; 
Justification: During the declaration we can initialize an array with { };
Hint: 
Score: 15









47 Question: What is an array in C?
Answers: 
A collection of random values 
A data structure that stores a fixed-size sequence of elements of the same type 
A keyword used to declare variables
Correct answer: A data structure that stores a fixed-size sequence of elements of the same type
Justification: An array in C is a data structure that can store a fixed-size sequence of elements of the same type in contiguous memory locations.
Hint: Arrays are commonly used to store and manipulate collections of data.
Score: 15



48 Question: How do you access elements in an array in C?
Answers: 
Using the index of the element enclosed in square brackets [] 
Using the element's name directly 
Using the address of the element 
Correct answer: Using the index of the element enclosed in square brackets []
Justification: In C, you can access elements in an array by using the index of the element enclosed in square brackets [], starting from index 0.
Hint: Array indexing starts from 0, so the first element is accessed with index 0.
Score: 15





5)Pointers
49 Question:  How to print the address of a variable?	(int var = 3;)
Answers: 
printf('%i', var); 
printf('%i', &var); 
Correct answer: printf('%i', &var); 
Justification: If you have a var variable the %var will give you its address in memory.
Hint: 
Score: 10


50 Question: What is the NULL pointer in C?
Answers: 
A pointer with a value of zero 
A pointer that cannot be modified 
Correct answer: A pointer with a value of zero
Justification: The NULL pointer in C is a special pointer that has a value of zero, indicating that it does not point to any valid memory address.
Hint: The NULL pointer is commonly used to indicate the absence of a valid pointer.
Score: 10








51 Question: Can a pointer in C point to multiple variables?
Answers: 
Yes, a pointer can point to multiple variables simultaneously 
b) No, a pointer can only point to a single variable at a time 
Correct answer: No, a pointer can only point to a single variable at a time
Justification: In C, a pointer can only point to a single variable at a time. It holds the memory address of that variable.
Hint: If you want to point to multiple variables, you can use an array of pointers.
Score: 10


52 Question: What is a void pointer in C?
Answers: 
 A pointer that can only point to functions 
A pointer that can point to any data type 
Correct answer:  A pointer that can point to any data type
Justification: A void pointer in C is a special type of pointer that can point to any data type, but it cannot be directly dereferenced.
Hint: Void pointers are often used in situations where you need to work with generic data types or pass pointers of different types to a function.
Score: 10








53 Question: If we have an array (int x[10]; ) then &x[0] and x is the same address?	
Answers: 
Yes 
No 
Correct answer:  Yes 
Justification: The variable name x points to the first element of the array(x[]).
Hint: 
Score: 10




54 Question: If we have an array (int x[10]; ) then x[0] is equivalent to *x?	
Answers: 
Yes
No 
Correct answer: Yes 
Justification: (int x[4]; ) x point to the first element of the array =>  x=&x[0] => *x = x[0] 
Hint: 
Score: 10







55 Question: What is the purpose of the '&' operator in C?
Answers: 
To declare a pointer variable 
To access the value stored at a memory address 
To perform arithmetic operations on pointers 
Correct answer: To access the value stored at a memory address
Justification: The '&' operator in C is used to obtain the memory address of a variable, allowing you to access or modify the value stored at that address.
Hint: The '&' operator is also known as the 'address-of' operator.
Score: 15









56 Question: What is a pointer in C?
Answers: 
 A variable that stores the memory address of another variable 
A reserved keyword in C 
An arithmetic operator in C 
Correct answer: A variable that stores the memory address of another variable
Justification: A pointer in C is a variable that stores the memory address of another variable. It allows direct access to the value stored at that memory location.
Hint: Pointers are powerful tools for memory manipulation and dynamic memory allocation.
Score: 15



57 Question: How to pass the arguments to a function which swaps the values?(int x=1, 		      y=3;)	
Answers: 
swap(x, y); 
swap(&x, &y); 
swap(*x,*y); 
Correct answer: swap(&x, &y);
Justification: When we pass a variable by reference, the function receives the address of the original variable, and can directly access and modify its value.
Hint: 
Score: 15

58 Question: How to assign address to pointer?	
Answers: 
int x,*p; x = 12; p = x;
int p, x; x = 13; p = &x;
int *p, x; x= 14; p = &x;
Correct answer: int *p, x; x = 14; p = &x;
Justification: We can assign variable's memory address(&var) to a pointer (p*) with the 		           following action: p=&x; 
Hint: 
Score: 15







59 Question: How do you declare a pointer in C?
Answers: 
int *ptr; 
pointer int; 
ptr = &var;
Correct answer: int *ptr;
Justification: In C, you can declare a pointer by using the * symbol followed by the pointer name and the data type it points to.
Hint: The * symbol indicates that the variable is a pointer.
Score: 15




6)Strings
60 Question: Which function is used to concatenate strings?	
Answers: 
strcmp() 
strcpy() 
strcat() 
Correct answer: strcat()
Justification: The strcat() function is used to concatenate strings. 
Hint: 
Score:15


61 Question: Which function gives the length of a string?	
Answers: 
strlen() 
strcmp() 
strlwr() 
Correct answer: strlen() 
Justification: The strlen() function calculates the length of a given string.
Hint: 
Score:15


62 Question: What is the role of the strtok() function?
Answers: 
The strtok() function is used to concatenate two strings in C. 
The strtok() function is used to convert a string to an integer in C. 
The strtok() function is used to tokenize a string in C by breaking it down into smaller pieces based on a delimiter character. 
Correct answer: The strtok() function is used to tokenize a string in C by breaking it      			    down into smaller pieces based on a delimeter character. 
Justification: The strtok() function in C is used to tokenize a string, which means   			     breaking it down into smaller pieces or tokens based on a delimiter character.
Hint: 
Score: 15







63 Question: Which header file should be included to work with strings in C?
Answers: 
<stdio.h> 
<stdlib.h> 
<string.h> 
Correct answer:  <string.h>
Justification: The <string.h> header file in C provides functions and macros for working with strings.
Hint: The <string.h> header file is essential for string manipulation in C.
Score: 15


64 Question: Which function is used to concatenate two strings in C?
Answers: 
strcat() 
strncat() 
strlcat() 
Correct answer: strcat()
Justification: The strcat() function in C is used to concatenate (join) two strings together.
Hint: The strcat() function modifies the destination string directly.
Score: 15







65 Question: What is the purpose of the strlwr() function in C?
Answers: 
The strlwr() is used to convert all uppercase characters in a string to lowercase.
The strlwr() is used to reverse the order of the characters in a string 
Correct answer: The strlwr() is used to convert all uppercase characters in a string to   			   lowercase. 
Justification: the strlwr() converts string to lowercase.
Hint: 
Score: 10


66 Question: What is the role of the strcpy() in C?
Answers: 
Computes string's length.  
Copies a string to another. 
Correct answer: Copies a string to another. 
Justification: The strcpy() is used to copy the contents of one string to another string.
Hint: 
Score: 10








7)Structure

67 Question: Which two types of operators are used for accessing members of a structure?
Answers: 
“.” and “[ ]” 
“.” and “->” 
Correct answer: “.” and “->”  
Justification: We can access members of a structure with “.” and “->” operators.
Hint: 
Score: 10

68 Question: What is the correct syntax of a struct?	
Answers: 
struct name{ dataType member1; dataType member2 ..}; 
struct name(){ dataType member1, dataType member2 ..}; 
Correct answer: struct name{ dataType member1; dataType member2 ..}; 
Justification: 
Hint: 
Score: 10

69 Question: Can a struct contain another struct as a member?
Answers: 
Yes 
No
Correct answer: Yes
Justification: In C, a struct can contain another struct as a member, allowing for nested structures.
Hint: Nested structs provide a way to represent complex relationships between data.
Score: 10

70 Question: Can a struct have an array as a member?
Answers: 
Yes 
No
Correct answer: Yes
Justification: In C, a struct can have an array as a member, allowing for storing multiple values of the same data type within the struct.
Hint: Arrays can be useful for representing lists or collections of related data within a struct.
Score: 10







71 Question: What is a struct in C?
Answers: 
A data type that allows you to store multiple variables of different types together 
A data type used for string manipulation
Correct answer:  A data type that allows you to store multiple variables of different types together
Justification: In C, a struct is a composite data type that allows you to group multiple variables of different types together.
Hint: Structs are often used to represent real-world entities by grouping related data.
Score: 10


        ";
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
    //         List<Question> questions = new List<Question>();
    //     string[] lines = text.Split('\n');
    //     Question currentQuestion = null;

    //     for (int i = 0; i < lines.Length; i++)
    //     {
    //         var sor=false;
    //         string line = lines[i].Trim();
    //         if (line.Length >= 3)
    //             {
    //                 sor=line.Substring(2).StartsWith("Question:");
    //             }
                
    //         if (sor)
    //         {
    //             currentQuestion = new Question();
    //             currentQuestion.Text = line.Substring(line.IndexOf(':') + 1).Trim();
    //             questions.Add(currentQuestion);
    //         }
    //         else if (line.StartsWith("Correct answer:"))
    //         {
    //             currentQuestion.CorrectAnswer = line.Substring(line.IndexOf(':') + 1).Trim();
    //         }
    //         else if (line.StartsWith("Answers:"))
    //         {
    //             List<string> answers = new List<string>();
    //             string answerLine = lines[++i].Trim();
    //             while (!answerLine.StartsWith("Correct answer:") && !answerLine.StartsWith("Score:") && i < lines.Length)
    //             {
    //                 answers.Add(answerLine);
    //                 answerLine = lines[i++].Trim();
    //             }
    //             i--; // Decrement i to process the correct answer line in the next iteration
    //             if (currentQuestion != null)
    //                 {
    //                     currentQuestion.Answers = answers;
    //                 }

    //         }
           
        
    // }

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Name","Title","CurrentLife","Score","MapId", "CreatedDate", "CreatedAT" },
                values: new object[,]
                {
                    { "Introduction", "This is the first quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" },
                    { "Flow Control (Loops)", "This is the second quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" },
                    { "Functions", "This is the third quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" },
                    { "Arrays ", "This is the third quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" },
                    { "Pointers ", "This is the third quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" },
                    { "Strings ", "This is the third quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" },
                    { "Structure ", "This is the third quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" },
                    
                });
            


            // int quizId=1;
            // List<object> questionsAdd= new List<object>();
            // List<object> answerAdd= new List<object>();
           
            // for (int i = 0; i < questions.Count-1; i++)
            // {
            //     switch (i)
            //     {
            //         case 15:
            //             ++quizId;
            //             break;
            //         case 28:
            //             ++quizId;
            //             break;
            //         case 35:
            //             ++quizId;
            //             break;
            //         case 47:
            //             ++quizId;
            //             break;
            //         case 58:
            //             ++quizId;
            //             break;
            //         case 65:
            //             ++quizId;
            //             break;
            //         default:
                       
            //             break;
            //     }
                
                
            //          var question =new object[,]
            //         {
            //             {questions[i], "Choice", 1, quizId, DateTimeOffset.Now, "Mackotestver" },
            //         };
            //         questionsAdd.Add(question);
            //     foreach (var item in questions[i].Answers)
            //     {
            //         var answer = new object[,]
            //         {
            //             { item, "Type 1", item == questions[i].CorrectAnswer, ++i, DateTimeOffset.Now, "Mackotestver" },
            //         };
            //         answerAdd.Add(answer);
            //     }
                
            // }

            //     int rowCount = questionsAdd.Count;
            //     int colCount = 6; 

            //     object[,] values = new object[rowCount, colCount];
            //     for (int i = 0; i < rowCount; i++)
            //     {
            //         var data = questionsAdd[i];
            //         values[i, 0] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item1;
            //         values[i, 1] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item2;
            //         values[i, 2] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item3;
            //         values[i, 3] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item4;
            //         values[i, 4] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item5;
            //         values[i, 5] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item6;
            //     }

            //     migrationBuilder.InsertData(
            //      table: "Questions",
            //      columns: new[] {"Content", "Type", "Rank", "QuizId", "CreatedDate", "CreatedAT" },
            //      values: values);

            //     rowCount = answerAdd.Count;
            //     colCount = 6; 

            //     object[,] values1 = new object[rowCount, colCount];
            //     for (int i = 0; i < rowCount; i++)
            //     {

            //         var data = answerAdd[i];
            //         values1[i, 0] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item1;
            //         values1[i, 1] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item2;
            //         values1[i, 2] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item3;
            //         values1[i, 3] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item4;
            //         values1[i, 4] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item5;
            //         values1[i, 5] = ((ValueTuple<int, int, int, int, DateTimeOffset, string>)data).Item6;
            //     }
                
            //     migrationBuilder.InsertData(
            //      table: "QustionAnswers",
            //      columns: new[] { "Content", "Type", "Corrrect", "QuestionId", "CreatedDate", "CreatedAT" },
            //      values: values1);     
            // migrationBuilder.InsertData(
            //     table: "Questions",
            //     columns: new[] {"Content", "Type", "Rank", "QuizId", "CreatedDate", "CreatedAT" },
            //     values: new object[,]
            //     {
            //         {"Can a variable name start with number in C?", "Choice", 1, 1, DateTimeOffset.Now, "Mackotestver" },
            //         {"Int data type’s format specifiers are the %d and %I?", "Choice", 1, 1, DateTimeOffset.Now,"Mackotestver" },
            //         {"Which data type is used to store whole numbers in C?", "Choice", 1, 1, DateTimeOffset.Now, "Mackotestver" },
            //         {"What is the size of the 'float' data type in C?", "Choice", 1, 1, DateTimeOffset.Now, "Mackotestver" },
            //         {"Which data type is used to store characters in C?", "Choice", 1, 1, DateTimeOffset.Now, "Mackotestver" },
            //         {"What is the size of the 'double' data type in C?", "Choice", 1, 1, DateTimeOffset.Now,"Mackotestver" },
            //         {"Which data type is used to store large whole numbers in C?", "Choice", 1, 1, DateTimeOffset.Now, "Mackotestver" },
            //         {"Which format specifier is used to print a floating-point number in C?", "Choice", 1, 1, DateTimeOffset.Now, "Mackotestver" },

            //     });

            // migrationBuilder.InsertData(
            //     table: "QuizAnswers",
            //     columns: new[] { "Id", "Name", "Title", "CurentLife", "Score", "QuizId", "CreatedDate", "CreatedAT" },
            //     values: new object[,]
            //     {
            //         { 1, "Answer 1", "Title 1", 3, 100, 1, DateTimeOffset.UtcNow, "Mackotestver" },
            //         { 2, "Answer 2", "Title 2", 2, 50, 1, DateTimeOffset.UtcNow, "Mackotestver" },
            //         { 3, "Answer 3", "Title 3", 1, 25, 2, DateTimeOffset.UtcNow, "Mackotestver" },
            //         { 4, "Answer 4", "Title 4", 3, 75, 2, DateTimeOffset.UtcNow, "Mackotestver" }
            //     });
            
            // migrationBuilder.InsertData(
            //     table: "QustionAnswers",
            //     columns: new[] { "Content", "Type", "Corrrect", "QuestionId", "CreatedDate", "CreatedAT" },
            //     values: new object[,]
            //     {
            //         { "Válasz 1", "Type 1", true, 1, DateTimeOffset.Now, "Mackotestver" },
            //         { "Válasz 2", "Type 2", false, 1, DateTimeOffset.Now, "Mackotestver" },
            //         { "Válasz 3", "Type 3", false, 2, DateTimeOffset.Now, "Mackotestver" },
            //         { "Válasz 4", "Type 4", true, 2, DateTimeOffset.Now, "Mackotestver" }
            //     });

            // migrationBuilder.InsertData(
            //     table: "QustionAnswersPicked",
            //     columns: new[] { "Id", "Corrrect", "QuestionId", "CreatedDate", "CreatedAT" },
            //     values: new object[,]
            //     {
            //         { 1, true, 1, DateTimeOffset.Now, "Mackotestver" },
            //         { 2, false, 1, DateTimeOffset.Now, "Mackotestver" },
            //         { 3, true, 2, DateTimeOffset.Now, "Mackotestver" },
            //         { 4, false, 2, DateTimeOffset.Now, "Mackotestver" },
            //     });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Quizzes");
            migrationBuilder.Sql("DELETE FROM Questions");
            migrationBuilder.Sql("DELETE FROM QuizAnswers");
            migrationBuilder.Sql("DELETE FROM QustionAnswers");
            migrationBuilder.Sql("DELETE FROM QustionAnswersPicked");
        }
    }
}
