namespace _8___Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8");

            int idadeJoao = 18;
            int quantidadeDePessoas = 2;

            bool acompanhado = quantidadeDePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true)
            //if (idadeJoao >= 18 || quantidadeDePessoas >= 2)
            {
                Console.WriteLine("João pode entrar!");
            }
            else
            {
                Console.WriteLine("João não pode entrar!");
            }
        }
    }
}
