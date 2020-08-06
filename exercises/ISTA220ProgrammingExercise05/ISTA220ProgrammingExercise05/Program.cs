using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ISTA220ProgrammingExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] ArrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };


            Console.WriteLine("\nArrayA: [{0}]", string.Join(", ", ArrayA));
            Console.WriteLine("\nArrayB: [{0}]", string.Join(", ", ArrayB));
            Console.WriteLine("\nArrayC: [{0}]", string.Join(", ", ArrayC));
            Console.WriteLine("Part 1, finding the mean. The mean of of arrays A,B, and C are as follows:");
            Mean(ArrayA);
            Mean(ArrayB);
            Mean(ArrayC);


            Console.WriteLine("Part 2: Write a method that reverses an array. Array A reversed:");
            ReverseArray(ArrayA);

            Console.WriteLine("Part 2: Write a method that reverses an array. Array B reversed:");
            ReverseArray(ArrayB);

            Console.WriteLine("Part 2: Write a method that reverses an array. Array C reversed:");
            ReverseArray(ArrayC);


            
            int Sum(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }              
                return sum;
            }
            double Mean(int[] arr)
            {
                double avg = Sum(arr) / arr.Length;
                Console.WriteLine(avg);
                return avg;
            }

            int[] Sort(int[] arr)
            {
                Array.Sort(arr);
                foreach (int i in arr)
                {
                    Console.Write(i);
                }
                return arr;
            }
             int[] ReverseArray(int[] arr)
            {               
                var newArray = new int[arr.Length];
                int count = 0;

                for (int i = arr.Length-1; i >= 0; i--)
                {
                    newArray[count] = arr[i];
                    count++;

                    if (count == arr.Length)
                    {
                        Console.WriteLine("\nArray: [{0}]", string.Join(", ", newArray));
                    }
                }

                return newArray;
            }
            int[] RotateArray(int[] arr, int index, bool isRight)
            {
        

                if (index > arr.Length)
                    throw new IndexOutOfRangeException();

                var newArray = new int[arr.Length];
                int count = 0;

                if (isRight)
                {
                    //this loop starts at the index itself
                    for (int i = index; i < arr.Length; i++)
                    {
                        newArray[count] = arr[i];
                        count++;
                    }
                    //this loops starts at the beginning of the array
                    for (int j = 0; j < index; j++)
                    {
                        newArray[count] = arr[j];
                        count++;
                    }
                }
                else
                {
                    if (index - 1 < 0)
                        throw new IndexOutOfRangeException();

                    for (int i = index - 1; i >= 0; i--)
                    {
                        newArray[count] = arr[i];
                        count++;
                    }
                    for (int j = arr.Length - 1; j >= index; j--)
                    {
                        newArray[count] = arr[j];
                        count++;
                    }
                }


                return newArray;
            }
        }
    }


}

   

