using System;
using System.Linq;

namespace Lotto
{
    class TicketCalculator
    {
        public int[] ticketNumbers = new int[7];
        TicketGenerator  ticketGenerator = new TicketGenerator();

        //Set the value of the ticket that user added in the GUI.
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

        //This is the score counter, this will return how many correct numbers the user had.
        private int[] ScoreCounter(int[] ticketNumber, int howManyTimes)
        {
            int[] result = {0, 0, 0};
            //Random gen. with a seed.
            var rnd = new Random(DateTime.Now.TimeOfDay.Milliseconds);
            //This is the brain, loops how many times the user wants.
            for (int i = 0; i < howManyTimes; i++)
            {
                //Function for the number generator for the system. 
                var seriesOfNumbers = new int[7];
                seriesOfNumbers = ticketGenerator.GeneratesATicketSeries();

                //Score calculator.
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

                //This keeps score. 
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
 