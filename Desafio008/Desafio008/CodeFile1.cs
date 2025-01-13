class Conta
{
    public string titular;
    public int idConta;
    public float saldo;
    public int senha;

    public void exibirInformacoes()
    {
        Console.WriteLine("INFORMAÇÕES DA CONTA:");
        Console.WriteLine($"Titular: {this.titular}");
        Console.WriteLine($"Saldo atual: {this.saldo}");
    }
}