namespace Desafio007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.titular = "Leonardo";
            conta.idConta = 1;
            conta.saldo = 200;
            conta.senha = 1354;

            Console.WriteLine("Info conta");
            Console.WriteLine($"Titular: {conta.titular}");
            Console.WriteLine($"Saldo atual: {conta.saldo}");
        }
    }
}
