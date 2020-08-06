﻿using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ISTA220ProgrammingExercise05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Part 0: The Arrays:");
            int[] ArrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] ArrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };


            Console.WriteLine("\nArrayA: [{0}]", string.Join(", ", ArrayA));
            Console.WriteLine("\nArrayB: [{0}]", string.Join(", ", ArrayB));
            Console.WriteLine("\nArrayC: [{0}]\n", string.Join(", ", ArrayC));
            
            Console.WriteLine("Part 1, finding the mean. The mean of of arrays A,B, and C are as follows:");
            Mean(ArrayA);
            Mean(ArrayB);
            Mean(ArrayC);


            Console.WriteLine("Part 2: Write a method that reverses an array. Array A reversed:");
            ReverseArray(ArrayA);

            Console.WriteLine("Part 2:  Array B reversed:");
            ReverseArray(ArrayB);

            Console.WriteLine("Part 2:  Array C reversed:");
            ReverseArray(ArrayC);

            Console.WriteLine("Part 4: Write a method that sorts an array. Array C sorted:");
            Sort(ArrayC);

           
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
                int temp = 0;
                int count = 0;
                for (int i = 0; i <= arr.Length-1; i++)
                {
                   for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            count++;
                        }
                        if (count == arr.Length)
                        {
                            Console.WriteLine("\nArray: [{0}]\n", string.Join(", ", arr));
                        }
                    }
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
                        Console.WriteLine("\nArray: [{0}]\n", string.Join(", ", newArray));
                    }
                }

                return newArray;
            }

           
                
        }
    }


}

   

