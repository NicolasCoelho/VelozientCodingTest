namespace TwistedFizzBuzz.Interfaces
{
    public interface ITwistedFizzBuzz
    {
        public IEnumerable<string> DoFizzBuzz();

        public IEnumerable<string> DoFizzBuzzByCustomList(IEnumerable<int> customList);
    }
}
