using System;
using System.Linq;

namespace Lotto
{
    class TicketCalculator
    {
        private int[] ticketNumbers = new int[7];
        private TicketGenerator  ticketGenerator = new TicketGenerator();

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
            
            //This is the brain, loops how many times the user wants.
            for (int i = 0; i < howManyTimes; i++)
            {
                var winner = 0;
                //Function for the number generator for the system. 
                var seriesOfNumbers = new int[7];
                seriesOfNumbers = ticketGenerator.GeneratesATicketSeries();

                //Score calculator.
                for (int j = 0; j < ticketNumber.Length; j++)
                {
                    for (int k = 0; k < seriesOfNumbers.Length; k++)
                    {
                        if (ticketNumber.ElementAt(j) == seriesOfNumbers.ElementAt(k))
                        {
                            winner++;
                        }
                    }
                }

                //This keeps score. 
                switch (winner)
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
 