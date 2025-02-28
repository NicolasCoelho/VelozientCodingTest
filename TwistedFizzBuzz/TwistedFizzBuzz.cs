using System.Text;
using TwistedFizzBuzz.Interfaces;

namespace TwistedFizzBuzz
{
    public class TwistedFizzBuzzEngine : ITwistedFizzBuzz
    {
        public readonly List<KeyValuePair<int, string>> KeyTokenList;
        public readonly int MaxRange;

        public TwistedFizzBuzzEngine()
        {
            KeyTokenList = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(3, "Fizz"),
                new KeyValuePair<int, string>(5, "Buzz")
            };

            MaxRange = 100;
        }

        public void DoFizzBuzz()
        {
            for (var i = 1; i <= MaxRange; i++)
            {
                var text = new StringBuilder();

                foreach (var token in KeyTokenList)
                {
                    if (i % token.Key == 0) text.Append(token.Value);
                }

                if (text.Length == 0) text.Append(i);

                Console.WriteLine(text);
            }
        }
    }
}
