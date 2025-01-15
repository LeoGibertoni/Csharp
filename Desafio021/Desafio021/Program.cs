//Criar um programa Program.cs, instanciar seus 5 filmes favoritos,
//guardá-los em uma lista e mostrar as suas informações no console.

using Alura.Filmes;

Filme filme = new Filme("Um sonho de liberdade", 142, new List<string>() { "Tim Robbins", "Morgan Freeman" });
Filme filme2 = new Filme("O poderoso chefão", 175, new List<string>() { "Marlon Brando", "Al Pacino", "Talia Shire" });
Filme filme3 = new Filme("Batman - O Cavaleiro das Trevas", 152, new List<string>() { "Christian Bale", "Heath Ledger", "Maggie Gyleenhaal" });
Filme filme4 = new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<string>() { "Elijah Wood", "Ian McKellen", "Viggo Mortensen" });
Filme filme5 = new Filme("Green Book - O Guia", 130, new List<String>() { "Viggo Mortensen", "Mahershala Ali" });

List<Filme> meusFilmesFavoritos = new List<Filme>();
meusFilmesFavoritos.Add(filme);
meusFilmesFavoritos.Add(filme2);
meusFilmesFavoritos.Add(filme3);
meusFilmesFavoritos.Add(filme4);
meusFilmesFavoritos.Add(filme5);

foreach (Filme f in meusFilmesFavoritos)
{
    Console.WriteLine($"Filme: {f.Titulo}");
    Console.WriteLine($"Duracao: {f.Duracao}");
    f.ListarElenco();
    Console.WriteLine();
}