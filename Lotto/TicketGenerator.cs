using System;
using System.Linq;

namespace Lotto
{
    class TicketGenerator
    {
        //This is the number generator for the system. Will ONLY generate unique numbers. 
        public int[] GeneratesATicketSeries()
        {
            var rnd = new Random();
            var seriesOfNumbers = new int[7];
            for (var i = 0; i < seriesOfNumbers.Length; i++)
            {
                //Do-while checks if the number have been used, if so loops again.
                int number;
                do
                {
                    number = rnd.Next(1,36);
                } while (seriesOfNumbers.Contains(number));

                seriesOfNumbers[i] = number;
            }

            return seriesOfNumbers;
        }
    }
}
