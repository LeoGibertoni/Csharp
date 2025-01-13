namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bandas = new List<string> { "Metallica", "AC/DC", "Iron Maiden", "Guns N' Roses", "Led Zeppelin" };

            foreach (string banda in bandas)
            {
                Console.WriteLine(banda);
            }
        }
    }
}
