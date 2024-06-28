using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp_task_27_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Correct the syntax error:

            int[] ARR = { 1, 7, 9, 45, };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog", };
            //***********************************************************
            Console.WriteLine(" What the index of 'Banana','Tomato' ?");
            String[] fruits = {"Tomato", "Banana", "Watermelon"};
            int index1=Array.IndexOf(fruits, "Tomato");
            int index2 = Array.IndexOf(fruits, "Banana");
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine("index Tomato in array fruits "+ index1);
            Console.WriteLine("index Banana in array fruits " + index2);
            //**************************************************************
            //Then, print each array using foreach, and Loop Through an Array
            Console.WriteLine("3 - Create an multiple arrays that represents your:");
            string[] Food = { "grilled kubba", "kofta" ,"tabbouleh", "hawawshi" , "pizza" };
            string[] Sport = { "Swimming", "Balls and Kondooh", "Tennis" };
            string[] Movie = { "Conan", "Encanto", "Home Alone" };
            Console.WriteLine("/////////////////foreach////////////////////");

            foreach (var item in Food)
            {
                Console.WriteLine("Favorite Food= "+item);
            }
            Console.WriteLine("/////////////////////////////////////");

            foreach (var item1 in Sport)
            {
                Console.WriteLine("Favorite Sport=" + item1);
            }
            Console.WriteLine("/////////////////////////////////////");
            foreach (var item2 in Movie)
            {
                Console.WriteLine("Favorite Movie=" + item2);
            }
            Console.WriteLine("////////////////for/////////////////////");
            for (int i = 0; i < Food.Length; i++)
            {
                Console.WriteLine("for loop food= "+Food[i]);

            }
            Console.WriteLine("/////////////////////////////////////");

            for (int i = 0; i < Sport.Length; i++)
            {
                Console.WriteLine("for loop Sport =" + Sport[i]);

            }
            Console.WriteLine("/////////////////////////////////////");

            for (int i = 0; i < Movie.Length; i++)
            {
                Console.WriteLine("for loop Movie =" + Movie[i]);

            }
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine("4 - Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma");

           //Input three numbers separated by comma: 5,10,15
           //The sum of three numbers: 30.

            int num1 =5,num2=10,num3 = 15;
            int sum = num1 + num2 + num3;
            Console.WriteLine("The sum of three numbers: "+sum);
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine(" 5 - Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. ");

            //The odd numbers are1 3 5 7 9 11 13 15 17 19……
            //The Sum of odd Numbers is: …...
            int sum_odd = 0;
            for (int i = 1; i <= 100; i=i+2)
            {
                Console.WriteLine(i);
               sum_odd += i;

            }
            Console.WriteLine("The Sum of odd Numbers is:" + sum_odd);
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine("6-Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor The pattern like:");
           for(int i = 1;i <= 5; i++)
            {
                Console.WriteLine();
                for ( int j = 1;j < i;  j++)
                {
                    Console.Write("*");


                }
            }

            //Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            //The pattern like :

            /*  1
              2 3
            4 5 6
           7 8 9 10*/
            Console.WriteLine();
            Console.Write("Input number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int K = 1;

            for (int i1 = 1; i1 <= rows; i1++)
            {
                Console.Write("\n");

                for (int j1 = 1; j1 <= i1; j1++)
                {
                    Console.Write("{0} ", K++);
                }
            }



            Console.ReadLine();

        }
    }
}
