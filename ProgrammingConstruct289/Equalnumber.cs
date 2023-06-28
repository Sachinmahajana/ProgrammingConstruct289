using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct289
{
    internal class Equalnumber
    {
        int num1, num2;  
        public void EqualNumberFunction()
        {
            Console.WriteLine("Enter the Num1 and Num2");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("Number is Equal ");
            }
            else
            {
                Console.WriteLine("Number is not Equal");
            }
        }
    }
}
