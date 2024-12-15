using System;
using System.Drawing;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment_session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region problem1
            /* السؤال
             1- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3),
            and determines whether these points lie on a single straight line.*/

            //int[,] numbers = new int[3, 2];
            //Console.WriteLine("Please Enter 3 point (x1, y1), (x2, y2), and (x3, y3) ");

            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter point num{i + 1} ");
            //    Console.Write($"x{i + 1} is ");
            //    numbers[1, 0] = int.Parse(Console.ReadLine());
            //    Console.Write($"y{i + 1} is ");
            //    numbers[1, 1] = int.Parse(Console.ReadLine());
            //}
            ////          x2  y1          x1  y1            x3  y2          x1  y2
            //if ((numbers[1, 0] - numbers[0, 0]) * (numbers[2, 1] - numbers[1, 1]) 
            //                             ==
            ////          x1  y2          x1  y2                x3  y1         x2  y1
            //    (numbers[1, 1] - numbers[0, 1]) * (numbers[2, 0] - numbers[1, 0]))
            //{
            //    Console.WriteLine("The points lie on a straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a straight line.");
            //}
            #endregion

            #region problem2
            /*السؤال
            2- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
            - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
            - If the worker takes more than 5 hours, they are required to leave the company. 
            To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
             */

            //Console.WriteLine("Enter the time you taken for the task");
            //int time = int.Parse(Console.ReadLine());
            //string input = time switch
            //{
            //>= 2 and <= 3 => "Highly efficient",
            //> 3 and <= 4 => "You should increase your speed",
            //> 4 and <= 5 => "Training to enhance their speed",
            //> 5 => "He should leave the company",
            //_ => "Invalid input. Time must be 2 hours or more" 
            //};
            //Console.WriteLine(input); 

            //------------------- if حل تاني باستخدام-------------------- 

            //Console.WriteLine("Enter the time you taken for the task");
            //double hours = double.Parse(Console.ReadLine());
            //Console.Write($"you take {hours} houre and A worker's efficiency level is :");

            //if (hours >= 2 && hours <= 3)
            //    Console.WriteLine(" highly efficient");

            //else if (hours > 3 && hours <= 4)
            //    Console.WriteLine("you should increase your speed");

            //else if (hours > 4 && hours <= 5)
            //    Console.WriteLine("training to enhance their speed");

            //else if (hours > 5)
            //    Console.WriteLine("training to enhance their speed");

            //else
            //    Console.WriteLine("Invalid input. Time must be 2 hours or more");

            #endregion

            #region problem3
            /* السؤال
             * Write a program that prints an identity matrix using for loop,
            in other words takes a value n from the user and shows the identity table of size n * n.
            اللي هي القطر بيساةي 1*/
            //Console.WriteLine("Please enter a matrix n");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Identity Matrix of size {n} x {n}: ");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //            //1,1  2,2  3,3 < عشان القطر بيطلع ب 1 لازم الصف يكون بيساوي بعضو

            //        }
            //        else
            //        {
            //            Console.Write("0 ");

            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region problem20
            /* السؤال
            20- Write a program in C# Sharp to find the sum of all elements of the array.*/

            //Console.WriteLine("please enter elments of array");
            //int ArraySize = int.Parse(Console.ReadLine());
            //int[] elments = new int[ArraySize];
            //int sum = 0;
            //for (int i = 0; i < ArraySize; i++)
            //{
            //    Console.WriteLine($"Please enter element number {i + 1}:");
            //    elments[i] = int.Parse(Console.ReadLine());
            //    sum += elments[i];
            //}
            //// عشان اعرض بقا
            //Console.Write("Array is : ");
            //for (int i = 0; i < elments.Length; i++)
            //{
            //    Console.Write($"{elments[i]} ");
            //}            
            //Console.WriteLine($"\nSum of elements is : {sum}");

            #endregion

            #region problem21
            /* السؤال
             21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
             */
            //Console.Write("please enter size of arrays : ");
            //int SizeArray =int.Parse(Console.ReadLine());

            //int[] arr1 = new int[SizeArray];
            //int[] arr2 = new int[SizeArray];

            //Console.WriteLine("Enter elements of the first sorted array:");
            //for (int i = 0; i < SizeArray; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter elements of the second sorted array:");
            //for (int i = 0; i < SizeArray; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //int[] merge = new int[arr1.Length + arr2.Length];
            //arr1.CopyTo(merge, 0);
            //arr2.CopyTo(merge, arr1.Length);

            //Array.Sort(merge);

            //Console.WriteLine();
            //Console.WriteLine("Merged and sorted array:");
            //for (int i = 0; i < merge.Length; i++)
            //{
            //    Console.Write(merge[i] + " "); // هطبع كل عنصر
            //}

            #endregion

            #region problem22
            /*السؤال
             22- Write a program in C# Sharp to count the frequency of each element of an array.
             */
           
            #endregion

            #region problem23
            /*السؤال
            23- Write a program in C# Sharp to find maximum and minimum element in an array
            */
            //Console.Write("Enter your size of array ");
            //int size=int.Parse(Console.ReadLine()); 
            //int[] items = new int[size];
            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.Write($"item {i + 1} : ");
            //    items[i] = int.Parse(Console.ReadLine());
            //}

            //int maximum = 0;
            //int minimum = int.MaxValue;
            ////اكبر قيمه ممكنه بحيث ان اي رقم هيدخل هيكون اصغر منها smallest  بقوله خلي قيمه ال

            //for (int i = 0; i < items.Length; i++)
            //{
            //    if (items[i]< minimum)
            //    {
            //        minimum = items[i];
            //    }
            //    else if (items[i] > maximum)
            //    {
            //        maximum = items[i];
            //    }
            //}
            //Console.Write("items in array is :");
            //for (int i = 0; i < items.Length; i++)

            //    Console.Write($"{items[i]} ");


            //Console.WriteLine($"\nminimum number is : {minimum}");
            //Console.WriteLine($"maximum number is : {maximum}");


            #endregion

            #region problem24
            /* السؤال
             24- Write a program in C# Sharp to find the second largest element in an array. 
            */
            //Console.Write("Enter your size of array ");
            //int size = int.Parse(Console.ReadLine());
            //int[] items = new int[size];
            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.Write($"item {i + 1} : ");
            //    items[i] = int.Parse(Console.ReadLine());
            //}
            //int Maximum = 0;
            //int SecondMaximum = 0;
            //for (int i = 0; i < items.Length; i++)
            //{ 
            //if (items[i] > Maximum)
            //    {   

            //        SecondMaximum = Maximum; 
            //        Maximum = items[i];
            //    }

            //}
            //Console.Write("items in array is :");
            //for (int i = 0; i < items.Length; i++)

            //    Console.Write($"{items[i]} ");

            //Console.WriteLine($"\nSecond Maximum number is : {SecondMaximum}");
            #endregion

            #region problem25
            /*السؤال
             25-. Consider an Array of Integer values with size N, having values as    
              in this Example write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).
             In the example above, the longest distance is between the first 7 and the
             10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st
              And the 10th 7s.

                Note:
                - Array values will be taken from the user
                - If you have input like 1111111 then the distance is the number of
                Cells between the first and the last cell.

            */

            //Console.Write("Please Enter Size Of Array : ");
            //int size = int.Parse(Console.ReadLine());
            //int count = 0;
            //int[] n = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"item {i + 1} is :");
            //    n[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < size; i++)
            //{

            //    for (int j = 0; j < size; j++)
            //    {
            //        if (n[i] == n[j])
            //        {
            //            int distance = j - i- 1 ;

            //            if (distance > count)
            //            {
            //                count = distance;
            //            }
            //        }

            //    }
            //}
            //Console.WriteLine($"The longest distance between two equal elements is: {count}");
            #endregion

            #region problem26
            /*السؤال
             26- Given a list of space separated words, reverse the order of the words.
            Input: this is a test		Output: test a is this
            Input: all your base		Output: base your all
            Input: Word			Output: Word
            Note : 
            Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine Statement
            */
            //Console.WriteLine("pleas enter num of stetments to get the reverse");
            //string word = Console.ReadLine();
            //string[] stetments = word.Split(' ');

            //Console.Write("Output after reverse: ");
            //for (int i = stetments.Length - 1; i >= 0; i--)
            //{

            //    Console.Write($"{stetments[i]} ");
            //}

            #endregion

            #region problem27
            /*السؤال
27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array. */

            //Console.Write("Enter the size of the square array (rows and columns): ");
            //int size = int.Parse(Console.ReadLine());

            //int[,] sub = new int[size, size];
            //int[,] sub2 = new int[size, size];

            //Console.WriteLine("Enter the elements for the first array:");
            //for (int i = 0; i < size; i++) 
            //{
            //    for (int j = 0; j < size; j++) 
            //    {
            //        Console.Write($"Element at [{i},{j}]: ");
            //        sub[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++) 
            //    {
            //        sub2[i, j] = sub[i, j];
            //    }
            //}

            //Console.WriteLine("\nElements in the second array are:");
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++) 
            //    {
            //        Console.Write(sub2[i, j] + " ");
            //    }
            //    Console.WriteLine(); 
            //}



            #endregion

            #region problem28
            //Console.Write("pleas enter num of item to get the reverse :");
            //int item =int.Parse(Console.ReadLine());
            //int[] reverse = new int[item];
            //Console.WriteLine($"item before reverse is : ");
            //for (int i = 0; i < item; i++)
            //{
            //    Console.Write($"item {i + 1} is :");
            //    reverse[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"item after reverse is : ");
            //for (int i = item - 1; i >= 0; i--)
            //{
            //    Console.Write($"{reverse[i]} \n");
            //}


            #endregion


        }
    }

    }
