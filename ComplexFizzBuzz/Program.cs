using TwistedFizzBuzz;

namespace ComplexFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intialRange = -20;
            var finalRange = 127;
            var tokens = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(5, "Fizz"),
                new KeyValuePair<int, string>(9, "Buzz"),
                new KeyValuePair<int, string>(27, "Bar"),
            };

            new TwistedFizzBuzzEngine(intialRange, finalRange, tokens).DoFizzBuzz();
        }
    }
}
