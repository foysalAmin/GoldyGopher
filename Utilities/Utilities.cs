namespace GoldyGopher.Utilities
{
    public class Utilities
    {
        // method to check divisibility of a number by 3 , 7  and return Goldy, Gopher or Goldy Gopher
        public string GoldyGopher(int j)
        {
            if (isDivisibleBy(j, 3) && isDivisibleBy(j, 7)) return "Goldy Gopher ";
            if (isDivisibleBy(j, 3)) return "Goldy ";
            if (isDivisibleBy(j, 7)) return "Gopher ";
            return (j.ToString() + " ");

        }

        // method to check divisibility of two numbers
        public bool isDivisibleBy(int number, int divisor)
        {
            return (number % divisor == 0); // if divisible then remainder would be zero.
        }
    }
}
