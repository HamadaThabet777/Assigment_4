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
            int [] arr1 = { 1, 5, 9 , 4 , 3};
            Console.Write("items in array 1  is : ");
            for (int i = 0; i < arr1.Length; i++) 
            {
                Console.Write($"{arr1[i]} \t ");
            }
            Console.WriteLine();
            Console.Write("items in array 2  is : ");
            int[] arr2 ={ 15, 14, 7 , 30 , 12 };
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]}\t");
            }

            //int[] merge = new int arr1.Length + arr2.Length;
            //Array.merge
            #endregion

            #region problem7

            #endregion

            #region problem8

            #endregion

            #region problem9

            #endregion

            #region problem10

            #endregion

            #region problem11

            #endregion

            #region problem12

            #endregion


        }
    }

}
