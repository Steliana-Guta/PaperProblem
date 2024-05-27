using System;

namespace PaperProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int report;
            int people;
            int reams;

            int papers;
            int toner;

            int inputreamcost;
            int inputtonercost;
            int reamcost;
            int tonercost;

            int total;
            double total2;
            double total3;

            double discountream = 0;
            double discounttoner= 0;

            report = 140;
            people = 25;
            Console.WriteLine("Joe Roberts has to print the report paper for a board meeting. The report has 140 pages. He has to print it for 25 people.He always prints 5 more copies than the number of people attending. ");
            papers = report * (people + 5);
            reams = papers / 500 + 1;
            Console.WriteLine("Joe is gonna need " + reams + " reams to print all the reports.");
            toner = papers / 1200 + 1;
            Console.WriteLine("The printer can print 1200 papers using one toner cartridge. So Joe is going to need " + toner + " toner cartridges to print all the reports.");

            Console.WriteLine("What is the cost of one ream?");
            inputreamcost = int.Parse(Console.ReadLine());

            Console.WriteLine("And what is the cost for one toner cartridge?");
            inputtonercost = int.Parse(Console.ReadLine());

            reamcost = inputreamcost * reams;
            tonercost = inputtonercost * toner;
            total = reamcost + tonercost;
            Console.WriteLine("Joe is going to pay " + reamcost + " for the reams and " + tonercost + " for the toner cartridges. So he's going to pay a total of " + total + " for both.");
            Console.WriteLine("The local print store offers a 10% discount on bulk purchases of 5 or more reams of paper , and 10% for 5 or more toner cartridges.");
            if (reams > 5)
            {
                discountream = reamcost * (1 - 0.1);
                Console.WriteLine("Joe will have a discount for buying so many reams, he will have to pay " + discountream + " for them.");
                total2 = discountream;
            }

            else
                Console.WriteLine("The discount is not applicable for this amount of reams.");
            if (toner > 5)
            {
                discounttoner = tonercost * (1 - 0.1);
                Console.WriteLine("Joe will have a discount for buys so many toner cartridges, he will have to pay " + discounttoner + " for them.");
                total3 = discounttoner;
            }

            else
                Console.WriteLine("The discount is not applicable for this amount of toner cartridges.");
            Console.ReadLine();

            
            
            // after i solve the formula i have to make it to automatically calculate the discount and alert the user that the discount was made





        }
    }
}
