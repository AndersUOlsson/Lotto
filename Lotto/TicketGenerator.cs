using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class TicketGenerator
    {

        public int[] GeneratesATicketSeries()
        {
            var rnd = new Random();
            var seriesOfNumbers = new int[7];
            for (var i = 0; i < seriesOfNumbers.Length; i++)
            {
                seriesOfNumbers[i] = rnd.Next(1, 36);
                rnd = new Random(i);
            }

            return seriesOfNumbers;
        }
    }
}
