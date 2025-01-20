namespace Yalung_Problem_No._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the Factorial of a number");
            Console.WriteLine("Enter an integer");
            int number = int.Parse(Console.ReadLine());     //Converts the input to an integer

            long factorial = 1; 

            for (int i = 1; i <= number; i++)               //for loop until ma reach yung no. of int na kinuha
            {
                factorial *= i;                             //function for the factorial
            }

            Console.WriteLine($"{number}! is {factorial}");
        }
    }
}
