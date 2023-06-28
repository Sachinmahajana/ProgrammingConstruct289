namespace ProgrammingConstruct289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Programming construct Program");
            Console.WriteLine("Please choose the program given below");
            Console.WriteLine("\n1:CheckEqual");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Equalnumber myObj = new Equalnumber();
                    myObj.EqualNumberFunction();
                    break;
            }
        }
    }
}