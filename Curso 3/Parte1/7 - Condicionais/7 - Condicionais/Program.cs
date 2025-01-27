namespace _7___Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 18;
            int quantidadeDePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade!");
            } else
            {
                Console.Write("João é menor de idade, ");
                if (quantidadeDePessoas >= 2)
                {
                    Console.Write("mas joão está acompanhado!");
                }
                else
                {
                    Console.WriteLine("e não está acompanhado!");
                }
            }
        }
    }
}
