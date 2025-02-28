using TwistedFizzBuzz;

namespace Tests
{
    public class TwistedFizzBuzzTest
    {
        [Fact(DisplayName = "GIVEN standard fizzBuzz, WHEN DoFizzBuzz is called, THEN should return correct values")]
        public void Test1()
        {
            var expected = new List<string>
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz"
            };

            var result = new TwistedFizzBuzzEngine().DoFizzBuzz();

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (item != expected[index]) success = false;
                index++;
                if (index > 9) break;
            }

            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN a custom range, WHEN DoFizzBuzz is called, THEN should return correct values")]
        public void Test2()
        {
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };
            var result = new TwistedFizzBuzzEngine(1, 5).DoFizzBuzz();

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (item != expected[index]) success = false;
                index++;
                if (index > 4) break;
            }

            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN different tokens, WHEN DoFizzBuzz is called, THEN should return correct values")]
        public void Test3()
        {
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "FizzBuzzCar" };
            var tokens = new List<KeyValuePair<int, string>> { new(3, "Fizz"), new(5, "Buzz"), new(15, "Car") };
            var result = new TwistedFizzBuzzEngine(tokens).DoFizzBuzz();

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (item != expected[index]) success = false;
                index++;
                if (index > 4) break;
            }

            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN different range and tokens, WHEN DoFizzBuzz is called, THEN should return correct values")]
        public void Test4()
        {
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };
            var tokens = new List<KeyValuePair<int, string>> { new(3, "Fizz"), new(5, "Buzz"), new(15, "Car") };
            var result = new TwistedFizzBuzzEngine(1, 5, tokens).DoFizzBuzz();

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (item != expected[index]) success = false;
                index++;
                if (index > 4) break;
            }

            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN a custom list, WHEN DoFizzBuzzByCustomList is called, THEN should return correct values")]
        public void Test6()
        {
            var expected = new List<string> { "1", "8", "Fizz", "Buzz", "Fizz" };
            var customList = new List<int> { 1, 8, -3, 5, 3 };
            var result = new TwistedFizzBuzzEngine().DoFizzBuzzByCustomList(customList);

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (item != expected[index]) success = false;
                index++;
                if (index > 4) break;
            }

            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN a custom list and different range, WHEN DoFizzBuzzByCustomList is called, THEN should return correct values")]
        public void Test7()
        {
            var expected = new List<string> { "Fizz", "Buzz", "Fizz" };
            var customList = new List<int> { 3, 5, 6 };
            var result = new TwistedFizzBuzzEngine(3, 6).DoFizzBuzzByCustomList(customList);

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (item != expected[index]) success = false;
                index++;
                if (index > 2) break;
            }

            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN a custom list and different tokens, WHEN DoFizzBuzzByCustomList is called, THEN should return correct values")]
        public void Test8()
        {
            var expected = new List<string> { "Fizz", "Buzz", "FizzBuzzCar" };
            var customList = new List<int> { 3, 5, 15 };
            var tokens = new List<KeyValuePair<int, string>> { new(3, "Fizz"), new(5, "Buzz"), new(15, "Car") };
            var result = new TwistedFizzBuzzEngine(tokens).DoFizzBuzzByCustomList(customList);

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (item != expected[index]) success = false;
                index++;
                if (index > 2) break;
            }

            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN a custom list, different tokens and different range, WHEN DoFizzBuzzByCustomList is called, THEN should return correct values")]
        public void Test9()
        {
            var expected = new List<string> { "Fizz", "Buzz", "FizzBuzzCar" };
            var customList = new List<int> { 3, 5, 15 };
            var tokens = new List<KeyValuePair<int, string>> { new(3, "Fizz"), new(5, "Buzz"), new(15, "Car") };
            var result = new TwistedFizzBuzzEngine(1, 20, tokens).DoFizzBuzzByCustomList(customList);

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (item != expected[index]) success = false;
                index++;
                if (index > 2) break;
            }

            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN a large range, WHEN DoFizzBuzz is called, THEN should handle the range correctly")]
        public void Test10()
        {
            var expectedLength = 1000;
            var result = new TwistedFizzBuzzEngine(1, 1000).DoFizzBuzz();

            var index = 0;
            foreach (var r in result) { index++; }

            Assert.Equal(expectedLength, index);
        }

        [Fact(DisplayName = "GIVEN a large tokens list, WHEN DoFizzBuzz is called, THEN should handle the tokens correctly")]
        public void Test11()
        {
            var expected = new List<string>
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "Boom",
                "8",
                "Fizz",
                "Buzz",
                "Bam"
            };

            var tokens = new List<KeyValuePair<int, string>> { new(3, "Fizz"), new(5, "Buzz"), new(7, "Boom"), new(11, "Bam") };
            var result = new TwistedFizzBuzzEngine(tokens).DoFizzBuzz();

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (item != expected[index]) success = false;
                index++;
                if (index > 9) break;
            }

            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN a large tokens list and large range, WHEN DoFizzBuzz is called, THEN should handle both correctly")]
        public void Test12()
        {
            var expectedLength = 1000;
            var expected = new List<string>
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "Boom",
                "8",
                "Fizz",
                "Buzz",
                "Bam"
            };

            var tokens = new List<KeyValuePair<int, string>> { new(3, "Fizz"), new(5, "Buzz"), new(7, "Boom"), new(11, "Bam") };
            var result = new TwistedFizzBuzzEngine(1, 1000, tokens).DoFizzBuzz();

            var index = 0;
            var success = true;

            foreach (var item in result)
            {
                if (index <= 10)
                {
                    success = item == expected[index];
                }
                index++;
            }

            Assert.True(success);
            Assert.Equal(expectedLength, index);
        }


        [Fact(DisplayName = "GIVEN a range with minValue bigger then maxValue, WHEN DoFizzBuzz is called, THEN should throw an error")]
        public void Test13()
        {
            var success = false;
            try
            {
               new TwistedFizzBuzzEngine(10, 1);
            }
            catch
            {
                success = true;
            }
            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN a range with both values zeros, WHEN DoFizzBuzz is called, THEN should throw an error")]
        public void Test14()
        {
            var success = false;
            try
            {
                new TwistedFizzBuzzEngine(0, 0);
            }
            catch
            {
                success = true;
            }
            Assert.True(success);
        }

        [Fact(DisplayName = "GIVEN a custom tokens list empty, WHEN DoFizzBuzz is called, THEN should throw an error")]
        public void Test15()
        {
            var success = false;
            try
            {
                new TwistedFizzBuzzEngine(new List<KeyValuePair<int, string>>());
            }
            catch
            {
                success = true;
            }
            Assert.True(success);
        }

    }
}