namespace desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bandas = new List<string> { "Metallica", "AC/DC", "Iron Maiden", "Guns N' Roses", "Led Zeppelin" };

            for (int i = 0; i < bandas.Count; i++)
            {
                Console.WriteLine(bandas[i]);
            }
        }
    }
}
