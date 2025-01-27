//Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta,
//como agência, número da conta, saldo e limite,
//bem como um método que devolva as informações da conta de forma detalhada.

class Titular
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
}

class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}