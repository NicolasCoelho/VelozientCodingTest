namespace TwistedFizzBuzz.Interfaces
{
    public interface ITwistedFizzBuzz
    {
        public void DoFizzBuzz();

        public void DoFizzBuzzByCustomList(IEnumerable<int> customList);
    }
}
