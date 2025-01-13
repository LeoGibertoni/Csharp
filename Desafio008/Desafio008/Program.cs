namespace Desafio008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.titular = "Leonardo";
            conta.idConta = 1;
            conta.saldo = 200;
            conta.senha = 1334;

            conta.exibirInformacoes();
        }

    }
}
