//Reescrever os atributos da classe Carro, de modo que eles sejam properties,
//e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.

class Carro
{
    public string fabricante;
    public string modelo;
    public int ano;
    public int quantidadePortas;
}

//resposta
class Carro
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int QuantidadePortas { get; set; }
    public string DescricaoDetalhada => $"Modelo do carro: {this.Fabricante} {this.Modelo} {this.Ano}";
}