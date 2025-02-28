using TwistedFizzBuzz;

namespace StandardFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var twisted = new TwistedFizzBuzzEngine();
            
            twisted.DoFizzBuzz();
        }
    }
}
