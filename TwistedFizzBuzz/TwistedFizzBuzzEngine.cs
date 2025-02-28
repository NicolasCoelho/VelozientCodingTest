using System.Text;
using TwistedFizzBuzz.Interfaces;

namespace TwistedFizzBuzz
{
    public class TwistedFizzBuzzEngine : ITwistedFizzBuzz
    {
        public readonly IEnumerable<KeyValuePair<int, string>> KeyTokenList = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(3, "Fizz"),
                new KeyValuePair<int, string>(5, "Buzz")
            };
        
        public readonly int MinValue = 1;
        public readonly int MaxValue = 100;

        public TwistedFizzBuzzEngine() { }

        public TwistedFizzBuzzEngine(IEnumerable<KeyValuePair<int, string>> tokens)
        {
            CheckTokens(tokens);

            KeyTokenList = tokens;
        }

        public TwistedFizzBuzzEngine(int minValue, int maxValue)
        {
            CheckRange(minValue, maxValue);

            MinValue = minValue;
            MaxValue = maxValue;
        }

        public TwistedFizzBuzzEngine(int minValue, int maxValue, IEnumerable<KeyValuePair<int, string>> tokens)
        {
            CheckRange(minValue, maxValue);
            CheckTokens(tokens);

            KeyTokenList = tokens;

            MinValue = minValue;
            MaxValue = maxValue;
        }

        public void DoFizzBuzz()
        {
            for (var i = MinValue; i <= MaxValue; i++)
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

        
        private void CheckRange(int min, int max)
        {
            if (min > max || (min == 0 && max == 0)) throw new InvalidOperationException("Invalid range");
        }

        private void CheckTokens(IEnumerable<KeyValuePair<int, string>> tokens)
        {
            if (tokens.Count() == 0) throw new InvalidOperationException("Tokens list cannot be empty");
        }
    }
}
