using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct289
{
    internal class Candidateagecheck
    {
        int number;
        public void CandidateAgeFunction()
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number < 18)
            {
                Console.WriteLine("Sorry you are not eligible to cast your vote");
                Console.WriteLine("You would be able to caste your vote after {0} year", 18 - number);
            }
            else
            {
                Console.WriteLine("Congratulation . You are eligible for casting your vote");
            }
        }
    }
}
