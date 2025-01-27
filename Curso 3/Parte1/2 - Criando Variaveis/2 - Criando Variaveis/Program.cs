namespace _2___Criando_Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade = 19;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + idade;
            Console.WriteLine("Sua idade é: " + idade + "!");

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadKey();
        }
    }
}
