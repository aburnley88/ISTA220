using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double fee = calculateFee(theDailyRate: 375.0);
            Console.WriteLine($"Fee is {fee}");


            //double fee = calculateFee(noOfDays: 4);
            //Console.WriteLine($"Fee is {fee}");
            // double fee = calculateFee(dailyRate: 375.0);
            //Console.WriteLine($"Fee is {fee}");
            //double fee = calculateFee(500.0, 3);
            //Console.WriteLine($"Fee is {fee}");
            //double fee = calculateFee(650.0);
            //Console.WriteLine($"Fee is {fee}");

            // double fee = calculateFee();
            // Console.WriteLine($"Fee is {fee}");

        }
        private double calculateFee(double theDailyRate = 500.0, int noOfDays = 1)
        {
          
            Console.WriteLine("CalculateFee using 2 optional parameters");
            return theDailyRate * noOfDays;
        }
        private double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("CalculateFee using 1 optional paramenter");

            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }
        private double calculateFee()
        {
            Console.WriteLine("CalculateFee using hardcoded values");
            double defaultDailyRate = 400.0;
            int defaultNoOfDays = 1;
            return defaultDailyRate * defaultNoOfDays;
        }
    }
}
