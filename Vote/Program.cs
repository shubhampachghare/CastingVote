using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthNumber
{
    class Vote
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter To Age check Voting Eligibility");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("You are Eligible to cast your vote");
            }
            else
            {
                Console.WriteLine("You are not Eligible");
            }
        }
    }
}