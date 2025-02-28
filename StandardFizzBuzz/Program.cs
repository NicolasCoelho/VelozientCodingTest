using TwistedFizzBuzz;

namespace StandardFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new TwistedFizzBuzzEngine().DoFizzBuzz();

            foreach (var element in result) { Console.WriteLine(element); }
        }
    }
}
