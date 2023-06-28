namespace ProgrammingConstruct289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Programming construct Program");
            Console.WriteLine("Please choose the program given below");
            Console.WriteLine("\n1:CheckEqual\n2:Evenoddnumber\n3:Candidateagechecking");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Equalnumber myObj = new Equalnumber();
                    myObj.EqualNumberFunction();
                    break;
                case 2:
                    EvenOdd myObj1 = new EvenOdd();
                    myObj1.EvenOddFunction();
                    break;
                case 3:
                    Candidateagecheck myObj2 = new Candidateagecheck();
                    myObj2.CandidateAgeFunction();
                    break;
            }
        }
    }
}