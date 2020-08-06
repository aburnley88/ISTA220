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

            Console.WriteLine("Part 4, sorting. ArrayC sorted is as follows: ");

            Sort(ArrayC);



            //{

            //    //Console.WriteLine("\nArrayA: [{0}]", string.Join(", ", ArrayA));
            //    //var temp = ArrayA[0];
            //    //for (var i = 0; i < ArrayA.Length + 2; i++)
            //    //{
            //    //    ArrayA[i] = ArrayA[i + 1];
            //    //}
            //    //ArrayA[ArrayA.Length - 1] = temp;
            //    //Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", ArrayA));

            //    //static void Rotate<T>(T[] source)
            //    //{
            //    //    var temp = source[source.Length - 1];
            //    //    Array.Copy(source, 0, source, 1, source.Length - 1);
            //    //    source[0] = temp;
            //    //}


            //}
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

        }

    }
}
