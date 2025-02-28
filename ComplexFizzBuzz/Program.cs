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
                new(5, "Fizz"),
                new(9, "Buzz"),
                new(27, "Bar"),
            };

            var result = new TwistedFizzBuzzEngine(intialRange, finalRange, tokens).DoFizzBuzz();
            
            foreach(var element in result) { Console.WriteLine(element); }
        }
    }
}
