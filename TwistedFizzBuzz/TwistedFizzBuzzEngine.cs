using System.Text;
using TwistedFizzBuzz.Interfaces;

namespace TwistedFizzBuzz
{
    public class TwistedFizzBuzzEngine : ITwistedFizzBuzz
    {
        public readonly IEnumerable<KeyValuePair<int, string>> KeyTokenList;
        public readonly int MinValue;
        public readonly int MaxValue;

        public TwistedFizzBuzzEngine()
            : this(1, 100, new List<KeyValuePair<int, string>> { new(3, "Fizz"), new(5, "Buzz") }) { }


        public TwistedFizzBuzzEngine(IEnumerable<KeyValuePair<int, string>> tokens)
        {
            CheckTokens(tokens);
            
            MinValue = 1;
            MaxValue = 100;
            KeyTokenList = tokens;
        }

        public TwistedFizzBuzzEngine(int minValue, int maxValue)
        {
            CheckRange(minValue, maxValue);
            
            MinValue = minValue;
            MaxValue = maxValue;
            KeyTokenList = new List<KeyValuePair<int, string>> { new(3, "Fizz"), new(5, "Buzz") };
        }

        public TwistedFizzBuzzEngine(int minValue, int maxValue, IEnumerable<KeyValuePair<int, string>> tokens)
        {
            CheckRange(minValue, maxValue);
            CheckTokens(tokens);

            MinValue = minValue;
            MaxValue = maxValue;
            KeyTokenList = tokens;
        }

        public IEnumerable<string> DoFizzBuzz()
        {
            for (var i = MinValue; i <= MaxValue; i++)
            {
                var result = Match(i);
                yield return result;
            }
        }

        public IEnumerable<string> DoFizzBuzzByCustomList(IEnumerable<int> customList)
        {
            foreach (var i in customList)
            {
                var result = Match(i);
                yield return result;
            }
        }

        private string Match(int element)
        {
            var text = new StringBuilder();

            foreach (var token in KeyTokenList)
            {
                if (element != 0 && element % token.Key == 0) text.Append(token.Value);
            }

            if (text.Length == 0) text.Append(element);

            return text.ToString();
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
