namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musica musica1 = new musica();
            musica1.nome = "Roxane";
            musica1.artista = "The Police";
            musica1.duracao = 273;
            musica1.disponivel = true;

            musica musica2 = new musica();
            musica2.nome = "Vertigo";
            musica2.artista = "U2";
            musica2.duracao = 368;
            musica2.disponivel = false;

            musica1.ExibirFichaTecnica();
            Console.WriteLine();
            musica2.ExibirFichaTecnica();
        }
    }
}
