using System;
using System.Linq;

namespace Lotto
{
    class TicketCalculator
    {
        public int[] ticketNumbers = new int[7];
        TicketGenerator  ticketGenerator = new TicketGenerator();

        public int[] SetTheNumberOfTheTicket(string[] value,int howManyTimes)
        {




            var intValues = new int[7];
            var i = 0;
            foreach (var variable in value)
            {
                int.TryParse(variable, out intValues[i]);
                i++;
            }

            return ScoreCounter(intValues, howManyTimes);
        }

        private int[] ScoreCounter(int[] ticketNumber, int howManyTimes)
        {
            int[] result = {0, 0, 0};

            var rnd = new Random(DateTime.Now.TimeOfDay.Milliseconds);
            for (int i = 0; i < howManyTimes; i++)
            {
                var seriesOfNumbers = new int[7];
                for (var j = 0; j < seriesOfNumbers.Length; j++)
                {
                    seriesOfNumbers[j] = rnd.Next(1, 36);

                }

                var temp = 0;
                for (var a = 0; a < seriesOfNumbers.Length; a++)
                {
                    foreach (var t in ticketNumber)
                    {
                        if (seriesOfNumbers[a].Equals(t))
                        {
                            temp++;
                            seriesOfNumbers[a] = 0;
                        }
                    }
                }

                switch (temp)
                {
                    case 5:
                        result[0]++;
                        break;
                    case 6:
                        result[1]++;
                        break;
                    case 7:
                        result[2]++;
                        break;
                }
            }

            return result;
        }
    }
}
 