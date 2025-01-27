namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            int idade = 23;
            Console.WriteLine(idade);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long numeroGrande = 100000000000L;
            Console.WriteLine(numeroGrande);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precisao = 5.000001F;
            Console.WriteLine(precisao);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.ReadLine();
        }
    }
}
