// Make a program that gives the student a grade according to the following table,
// the score is asked and the program prints the number. Check that the given value is a number,
// and give an appropriate error message if it is not.

using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

// Variables used

string GradeInput;
int Grade;

// Uncomment multi-line comment (/*  */) code block to try if-statement

/*


Console.WriteLine("Please input the student's grade: ") ;
if (int.TryParse(GradeInput = Console.ReadLine(), out Grade))

if (0 <= Grade && Grade <= 19)
    Console.WriteLine("Grade is: 0 ");
else if (20 <= Grade && Grade <= 29)
    Console.WriteLine("Grade is: 1 ");
else if (30 <= Grade && Grade <= 39)
    Console.WriteLine("Grade is: 2 ");
else if (40 <= Grade && Grade <= 49)
    Console.WriteLine("Grade is: 3 ");
else if (50 <= Grade && Grade <= 59)
    Console.WriteLine("Grade is: 4 ");
else if (60 <= Grade && Grade <= 70)
    Console.WriteLine("Grade is: 5 ");
if (!int.TryParse(GradeInput = Console.ReadLine(), out Grade))
    Console.WriteLine("Not an integer ! Quitting !!");


*/



// Wanted to try switch method

Console.WriteLine("Please input the student's grade: ");
if (!int.TryParse(GradeInput = Console.ReadLine(), out Grade))
    Console.WriteLine("the value must be of integer type! Quitting !! Restart Please.");
else
    switch (Grade)
    {

        case int when (0 <= Grade && Grade <= 19):
            Console.WriteLine("Grade is: 0 ");
            break;
        case int when (20 <= Grade && Grade <= 29):
            Console.WriteLine("Grade is: 1 ");
            break;
        case int when (30 <= Grade && Grade <= 39):
            Console.WriteLine("Grade is: 2 ");
            break;
        case int when (40 <= Grade && Grade <= 49):
            Console.WriteLine("Grade is: 3 ");
            break;
        case int when (50 <= Grade && Grade <= 59):
            Console.WriteLine("Grade is: 4 ");
            break;
        case int when (60 <= Grade && Grade <= 69):
            Console.WriteLine("Grade is: 5 ");
            break;
        case int when (70 <= Grade && Grade <= 100):
            Console.WriteLine("Grade is: 5 ");
            break;
        case int when (100 <= Grade):
            Console.WriteLine("Impossible !!! ");
            break;
    }










