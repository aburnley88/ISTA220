using System;
using System.Security.Cryptography.X509Certificates;

namespace csharpprogrammingexercis02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n Part 1: Sum of 10 numbers.");
             int sum = SumTenInts(0, 0);
             char LetterGrade = 'X';
             Console.WriteLine($"The sum of 10 integers is {sum}");

            
             Console.WriteLine("\n Part 2: , average 10 numbers.");
             double avg = AvgTenInts(0, 0);
             LetterGrade = ConvertToLetterGrade(avg);
             Console.WriteLine($"the average of ten integers is {avg} and the letter grade is {LetterGrade}");
            


             Console.WriteLine("\nPart 3: average user predetermined number of scores");
             Console.WriteLine("How many scores do you wish to enter: ");
             string noScores = Console.ReadLine();
             int numScores = int.Parse(noScores);
             double avg1 = AvgUnkInts(0, 0, numScores);
             LetterGrade = ConvertToLetterGrade(avg1);
             Console.WriteLine($"The average of {numScores} integers is {avg1} and the grade is {LetterGrade}");
            
            
            Console.WriteLine("\n Part 4, average non-predetermined number of scores, \n Please enter \"stop\" to see average.");
            double avg2 = AvgAnyInts(0, 0);
            LetterGrade = ConvertToLetterGrade(avg2);
            Console.WriteLine($"The average of your integers is {avg2} and the letter grade is {LetterGrade}.");
            
           

        }

        private static double AvgTenInts(int sum, int count)
        {
            Console.WriteLine("Please enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count <10)
                return AvgTenInts(sum, count);
            else
                return ((double)sum / count);

        }

        private static int SumTenInts(int sum, int count)
        {
            Console.WriteLine("Please enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return SumTenInts(sum, count);
            else
                return sum;
        }
        private static double AvgAnyInts(int sum, int count)
        {
            Console.WriteLine("Please enter a score: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            if (input == "stop")
                return (double)sum/count;
            else
                sum += int.Parse(input);
                count++;
            return AvgAnyInts(sum, count);
            
         
        }
        private static char ConvertToLetterGrade(double score)
        {
            char LetterGrade = 'X';
            if (score >= 90)

            {
                LetterGrade = 'A';
                return LetterGrade;
            }

            else if (score >= 80)
            {
                LetterGrade = 'B';
                return LetterGrade;
            }
            else if (score >= 70)
            {
                LetterGrade = 'C';
                return LetterGrade;
            }
            else if (score >= 60)
            {
                LetterGrade = 'D';
                return LetterGrade;
            }
            else if (score <= 59)
            {
                LetterGrade = 'F';
                return LetterGrade;
            }
            else
                return LetterGrade;
   
            
        } 
        private static double AvgUnkInts(int sum, int count, int numScores = 0)
        {
            Console.WriteLine("Please enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < numScores)
                return AvgUnkInts(sum, count, numScores);
            else
                return ((double) sum / (numScores));

        }
        
            
        
        
        
        

        
    }
}
