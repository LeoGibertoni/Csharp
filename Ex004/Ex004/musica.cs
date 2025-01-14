class musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }
    public string DescricaoResumida //pode usar tbm => $"A música {Nome} pertence à banda {Artista}";
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel");
        }
        else
        {
            Console.WriteLine("Adquira o plano para receber acesso!");
        }
    }
}