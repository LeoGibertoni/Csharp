namespace _4___ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;

            salarioEmInteiro = (int)salario; //converte para int
            Console.WriteLine("Salario: " + salarioEmInteiro);

            //long é uma variavel de 64 bits
            long idade = 26;
            Console.WriteLine("Idade: " + idade);

            //short é uma variavel de 16 bits
            short quantidadeDeProdutos = 150;
            Console.WriteLine("Produtos: " + quantidadeDeProdutos);

            float altura = 1.80f;
            Console.WriteLine("Altura: " + altura);
        }
    }
}
