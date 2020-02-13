using System;
using static System.Console;

namespace S3Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int peakRate = 30, offPeakRate = 20, totoalCost = 0;

            DateTime fromDate = Convert.ToDateTime(ReadLine());
            DateTime toDate = Convert.ToDateTime(ReadLine());

            
            DateTime tempStartDate = fromDate;
            while(tempStartDate < toDate)
            {
                int cost = 0;
                DateTime nextDate = tempStartDate.AddSeconds(20);
                if(nextDate > toDate)
                {
                    nextDate = toDate;
                }

                // Peek hour chceck
                if(nextDate.Hour >= 9 && nextDate.Hour <= 22)
                {
                    cost = peakRate;
                }
                else
                {
                    cost = offPeakRate;
                }


             
                WriteLine("{0} + 20 second({1}) = {2} paisa", tempStartDate, nextDate, cost);

                totoalCost += cost;

                tempStartDate = nextDate.AddSeconds(1);
            }

            double costInTaka = (double)totoalCost / 100;
            WriteLine("{0} taka", costInTaka);


            ReadLine();
        }
    }
}
