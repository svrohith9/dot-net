# .Net Apps

## **Project 1**

Name this project as **CalculateLetterGrade**.

In this project you’ll design a form that lets the user enter a number grade and then displays the letter grade when the user clicks the Calculate button.

The mapping between number grades and letter grades are shown below:

> =90 but <=100 A
>
> =80 but < 90 B
>
> =70 but < 80 C
>
> =60 but < 70 D
>
> =0 but < 60 F
>
> The project assume the user only enters valid number grades, integers or floating-point numbers, (e.g., 100, 74.8, 55, etc.) between zero and 100.

## **Project 2**

Name this project as **ScoreCalculator**.

In this project you’ll create a form as shown below that accepts one or more scores from the user. Each time a score is added, the score total, score count, and average score are calculated and displayed (i.e., updated).

The form used by the project should look like the one shown above, including a form title, four pairs of labels and textboxes, plus three buttons. Set font size of labels, textboxes, and buttons to 16 points and adjust the form size and position of the controls so they look as shown. Name the textboxes as txtScore, txtTotal, txtCount, and txtAverage. Name the button as btnAdd, btnClear and btnExit. Set the ReadOnly property of the textboxes to be True except txtScore so user won't be able to modify their contents.

Rename the form to frmCalculateScores. When you’re asked if you want to modify any references to the form, click the Yes button.

When the user presses the Enter key on the keyboard, the Click event of the Add button should fire. When the user presses the Esc key on the keyboard, the Click event of the Exit button should fire. Please refer to 'How to set the Enter and Esc keys' of Chapter 2, p.47, and examples on p.48~9.

Different from how and where variables are declared in Project 1, you need two variables to store the score total and the score count in this project and they should not be declared inside a method (or event-handler). Because variables declared inside a method have method scope and will be reset or re-initialized every time the method is fired and executed. Both score total and score count in this project are supposed to accumulate all scores entered from the beginning and they should not be method scoped and reset. They must be a class variable (i.e., class scoped). The way to declare a class variable for this type of purpose is to declare it inside the form class but must be outside of any methods. See variable scope and examples of how to class variables on p.120~1 of Chapter 4.

Create an event handler method for the Click event of the Add button. This event handler should get the score the user enters, calculate and display the score total, score count, and average score, and move the focus to the Score textbox. To set the focus to this textbox, you write txtScore.Focus(); statement in the event handler. It should provide for integer entries, including integer score average, and you can assume that the user will only enter valid integer values.

Create an event handler for the Click event of the Clear button. This event handler should set the two class variables to zero, clear the textboxes on the form, and move the focus to the Score text box. To clear a textbox, you can call its Clear() method or simply assign an empty string (i.e., "") to its Text property.

Create an event handler for the Click event of the Exit button that closes the form, which is the same as the Exit button of Project 1.

## **Project 3**

Name this project as **FiftyRandsoms**.

This project can display up to 50 random integers that satisfy the following rules.

Every time the Get 10 Randoms button is pressed, it displays 10 random integers in a new line with double spaces inserted to separate the numbers. See one of the figures below for an example after three clicks of this button. Hint: Use for-loop.
Every random integer must be drawn between -9 and 9, inclusive. \*See p.108-9 of Chapter 4 for example code of how to generate random numbers in C#.
Duplicates are allowed in each set of ten random integers as long as they do not appear consecutively (i.e., one right after the other). Duplicates are also allowed across sets of 10 random integers. Hint: Use while-loop. Use an additional variable to track value of previous number.
User may click the above button up to five times for a total of 50 random integers. Additional clicking results a red error message in two lines, "Sorry, no more than 50 randoms!" and "Press Clear for another round." Any more clicking on the same button won't change the form display. See one of the figures below for the error message display. Hint: Use a class variable to count the number of times the button is clicked, and another class variable to accumulate new sets of ten numbers.
The Clear button, whenever it is clicked, must clear the display, including all random integers and error message, if exists, and leave only '?' displayed. That is, it turns the form back to its initial state as shown in the first figure below, which allows the user to start another round of up to 50 random integers.
The Exit button will stop the execution of the project and close the form.

Make sure the form and its controls also satisfy the following design requirements:

Let the form's name be frm50Randoms with a title of 'Assignment 2'. Its size should be 550 x 400, and StartPosition property should be 'CenterScreen'.
Use a label object named labRandoms to display up to 50 random numbers, ten per line and double spaced between numbers. Numbers are 20 points in bold face and displayed in navy blue with light blue background. Hint: Concatenate "\n" to a string so next concatenated string will be displayed in a new line.
Use a label object named labErr to display the error message in red, 12 points, and bold face. It should not display anything until the error occurs. When it displays, make sure the message does not overlap the display of random numbers.
Name the three buttons as btnGet, btnClear, and btnExit, respectively.
When the user presses the Enter key on the keyboard, the Click event of the Get 10 Randoms button should fire. When the user presses the Esc key on the keyboard, the Click event of the Exit button should fire.

## **Project 4**

Project Requirements:

Adjust the form's size such that it's not too large or too small to hold other objects. Let the form be displayed at the center of your screen regardless the screen's size. Be sure the form shows 'Simple Calculator' in its title.
Add labels, text boxes, and buttons to the form and set the properties of the form and its controls so they appear as shown above. Be sure the Result text box is read-only. Font size of these controls is suggested to be 16 points. Set 'C' and 'x' to be the access key of Calculate and Exit buttons, respectively, so when Alt key is pressed at run time, the C and x characters of the two buttons are underscored (see p.46-7 of Chapter 2 for access key usage and setting). Also, let the Calculate button be activated when the user presses the Enter key and the Exit button be activated when the user presses the Esc key.
Code a private method named Calculate() that performs the requested operation and returns a decimal value. This method should accept the following arguments:
operand1 (decimal type): it's the value entered for the first operand.
op (string type): it should be one of these four operators: +, -, _, or /.
operand2 (decimal type): it's the value entered for the second operand.
Create an event handler for the Click event of the Calculate button. This event handler should get the two numbers and operator the user enters, call the Calculate() method to get the result of the calculation, display the result rounded to four decimal places (see Math.Round() in Chapter 4), and move the focus to the Operand 1 text box. To avoid invalid input of numbers and operator, you will use TryParse() method of Decimal (see examples on p.116-7) to get the two input numbers and test if the input operator is one of +, -, _, or /. Any invalid input (either a bad numbers like '23Ah6' or bad operator like '@' or '44') will force an error message "Cannot calculate due to invalid input!" to be displayed in a popup dialog by using MessageBox (see the right figure shown above). This dialog should have a title of 'ERROR'.
Create an event handler for the Click event of the Exit button that closes the form.
Create an event handler that clears the Result text box whenever the user changes the text in any of the other three input text boxes (e.g., hitting Backspace or Delete key or inserting more character in text boxes). Hint: let this same event handler be "wired" to the TextChanged event of all three input text boxes.
Test the application to be sure it works correctly.

## **Project 5**

Using any code editor (e.g., Notepad++ or others (Links to an external site.)) to create a new file/program called Ass4.cs. *If you use any IDE, including Visual Studio to make this program, you must know how to "extract" this file and/or modify it from a project, then test if it work with the command line compiler of C# because Ass4.cs will be graded by using this compiler directly. As a requirement of this assignment and if it fails on this compiler, you won't earn credits from this work.
Ass4 let user enter two integers in the command line at the same time when he/she wants to execute the program. Note that, these two integers must be entered together with the command (i.e., the .exe of the program file) before it starts executing. Do not prompt user to enter them during program execution. The integers are used to define a range to generate five random numbers and can be entered in any order such as -5 3 or 3 -5. But invalid integers (e.g., $4, 5.08, 77x6, etc.) or identical numbers (e.g., 41 41) will not be accepted. The program simply ends quietly without doing anything to respond to invalid integers in the command line. See three invalid range inputs as an example shown in the screenshot here. ass4_args.png
Based on the same range, Ass4 will keep generating five random numbers, round after round. In each round, it monitors and accummulates from the beginning of program execution the sum and count of all generated random integers and uses them to update the average value of all random integers generated from the beginning. See the screenshot below for samples of execution of Ass4. The two accummulated values, sum and count, will grow bigger while the overall average will fluctuate from round to round of random integers generation. ass4_typical.png
Ass4 will terminate its execution once the overall average value of all random integers becomes equal to or larger than the midpoint of the range of these random integers. For example, if the range of random integers entered by the user is '-3 4', the midpoint should be 0.5 and Ass4 will stop generating random integers once the overall average is 0.5 or higher. An execution may terminates with only one round of generating five random integers but multiple rounds can be expected in general (as shown in the screenshot above.)
Ass4.cs is estimated to contain between 50 and 60 lines of code in total and it only needs to implement one class called Assignment4.
This class defines five members: one data and four methods, which are all static members because we won't instanitate any objects of this class to run the program while its data and methods, including Main(), need to be accessed or called to complete program execution. *Static members are already introduced in lectures of Module 4 and will be discussed more in Chapter 12 (p.392~3, if you want to visit it for details).
The only static data member is an object of the Random class, which should be declared in the class (normally at the top part) but must not inside any method members so every method of the class can access it when needed. That is, it is shared by all methods of the class.
You will write code in the Ass4.cs file to implement the four static method members of the class that are defined below:
GetRange
return: a tuple of two int members, low and high
parameter 'first': string type
parameter 'second': string type
This method use TryParse() to convert both inputs to an integer. It returns the smaller one in the low member of the tuple and the larger one in high member. If one or both conversion fail, it returns -1 in both tuple members.

EvenOrZero
return: no return
parameter 'number': int type with 'out' 'in' keyword (i.e., whose value is passed by reference without initialization)
parameter 'e': int type with 'ref' keyword
parameter 'z': int type with 'ref' keyword
This method will increment z by one if the value of number is zero; it increments e by one if number is an even value.

Get5Random
return: a tuple of five int members, r1, r2, r3, r4, and r5
parameter 'begin': int type with 'in' keyword
parameter 'end': int type with 'in' keyword
parameter 'even': int type with 'out' keyword (i.e., whose value is passed by reference without initialization)
parameter 'zero': int type with 'out' keyword
parameter 'sum': int type with 'ref' keyword
parameter 'count': int type with 'ref' keyword
This method will generate five random integers in the range specified by its input parameters, begin and end. These random integers are returned in the tuple of r1 ~ r5.

With the five generated random integers, this method will initialize two local variables to zero and use them to record how many of the five random integers are even and how many are zero by calling the EvenOrZero() method, once for each random integer.

This method also update its sum and count parameters by adding all five generated random integers into the sum and incrementing count by five. Because they (and the even and zero parameters) are passed by reference, the caller of this method will be able to retrieve their values.

Main
return: no return
parameter 'arg': string type of array (same as seen in the lecture example MyMath.cs)
Served as the entry point of the program, this method will first retrieve the two arguments user entered in the command line. In case of more than two argument data, they will be ignored and not used. For example, suppose this program is compiled to Ass4.exe, to execute the program user will enter in the command line like C:\.....\....> Ass4 -10 8 55 1200, then all four data will be captured in the arg parameter but only the first two data, i.e., -10 and 8 will be used by Main.

Main() first calls GetRange() to initialize a local named tuple called range.

Once the range is settled, Main() starts calling the Get5Random() in a loop structure to get five random integers and other data returned by this method, including the number of even values and zero of the five random integers, and updated summation and total count (so they can be accummulated from the beginning of execution.) Before end of a loop, Main() must show the updated result which is accociated with the newly generated five random integers. In the same output console line (see the last screenshot above), the five random integers are displayed followed by the total of even (ev), odd (od), and zeros (ze) of the current five numbers, plus the accumulated summation (accu_sum), count (accu_count), and average (avg) of all random integers generated from round 1. To verify more rounds are needed or not, Main() also displays the relationship between the accumulated average and the midpoint value of the range by using '<' or '>='. Every line should end with 'average < midpoint' except the last line when the average becomes larger than the midpoint.

To indicate clearly the total rounds executed by Ass4, the last item displays in each line is the round value beginning with 1 like (1).

Hint: To enable the loop structure to work in Main(), instead of zero, you will initialize the overall or accumulated average to the lower bound of the range. This is because the lower bound of the range could be a very small negative value and setting zero to initialize the average will never be able to start the loops.
