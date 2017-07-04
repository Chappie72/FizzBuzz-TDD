namespace FizzBuzz.Library
{
    public class FizzBuzzService 
    {
        public string Print(int n)
        {
            if(CheckDivisableBy3(n) && CheckDivisableBy5(n)) {
                return "FizzBuzz";
            } else if(CheckDivisableBy3(n)) {
                return "Fizz";
            } else if(CheckDivisableBy5(n)){
                return "Buzz";
            } else {
                return n.ToString();
            }
        }

        private bool CheckDivisableBy3(int n) {
            return n % 3 == 0;
        }

        private bool CheckDivisableBy5(int n) {
            return n % 5 == 0;
        }
    }
}