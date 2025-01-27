namespace Numeric_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.#}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double money = 10D / 3D;
            Console.WriteLine(money);
            Console.WriteLine(string.Format("{0:0.00}", money));
        }
    }
}
