//Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes.
//A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

namespace Alura.Filmes
{

    public class Artista
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Filme> FilmesAtuados { get; set; }
        public int QuantidadeDeFilmes => FilmesAtuados.Count


        public Artista(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            FilmesAtuados = new List<Filme>();
        }


        public void AdicionarFilme(string filme)
        {
            FilmesAtuados.Add(filme);
        }

        public void MostrarFilmesAtuados()
        {

            if (this.FilmesAtuados.Count == 0)
            {
                Console.WriteLine($"Nenhum filme encontrado na base para {this.Nome}");
                return;
            }

            Console.WriteLine($"Filmes de {this.Nome}...");
            foreach (var filme in FilmesAtuados)
            {
                Console.WriteLine($"Filme: {filme.Titulo}");
            }
        }
    }
}