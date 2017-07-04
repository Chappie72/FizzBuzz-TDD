using Xunit;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzzService _fizzBuzzService;

        public FizzBuzzTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void ShouldPrintNumber()
        {
            Assert.Equal("1", _fizzBuzzService.Print(1));
        }

        [Fact]
        public void ShouldPrintFizz()
        {
            Assert.Equal("Fizz", _fizzBuzzService.Print(3));
        }

        [Fact]
        public void ShouldPrintBuzz()
        {
            Assert.Equal("Buzz", _fizzBuzzService.Print(5));
            Assert.Equal("Buzz", _fizzBuzzService.Print(10));
        }

        [Fact]
        public void ShouldPrintFizzBuzz()
        {
            Assert.Equal("FizzBuzz", _fizzBuzzService.Print(15));
        }
    }
}