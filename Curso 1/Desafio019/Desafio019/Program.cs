//Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio.
//A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos.
//Os pedidos podem estar associados a uma mesa.

class ProdutoRestaurante
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Mesa
{
    public int Numero { get; set; }
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

class Pedido
{
    public ProdutoRestaurante Produto { get; set; }
    public int Quantidade { get; set; }
}

class Cardapio
{
    public List<ProdutoRestaurante> Itens { get; set; } = new List<ProdutoRestaurante>();
}

class Restaurante
{
    public List<Mesa> Mesas { get; set; } = new List<Mesa>();
    public Cardapio Cardapio { get; set; } = new Cardapio();
}
