namespace Desafio004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            int soma = 0;

            foreach (int numero in numeros)
            {
                soma += numero;
            }

            Console.WriteLine($"A soma dos elementos da lista é: {soma}");

        }
    }
}
