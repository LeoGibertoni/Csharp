namespace Desafio010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);

            bool BuscarNumerosQueSaoPares(int numero)
            {
                return numero % 2 == 0;
            }

            foreach (int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
