namespace Desafio003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo\n");
            void contas()
            {
                Console.Write("Digite um número: ");
                int a1 = int.Parse(Console.ReadLine());
                Console.Write("Digite outro número: ");
                int a2 = int.Parse(Console.ReadLine());

                int adicao = a1 + a2;
                int subtracao = a1 - a2;
                float divisao = a1 / a2;
                int multiplicacao = a1 * a2;

                Console.WriteLine($"\nAdição:{adicao}, Subtração:{subtracao}, Divisão:{divisao}, Multiplicação: {multiplicacao}\n");
            }
            contas();
        }
    }
}
