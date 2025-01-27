namespace FizzBuzz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 0; i < 15; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 1;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                } else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                } else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
