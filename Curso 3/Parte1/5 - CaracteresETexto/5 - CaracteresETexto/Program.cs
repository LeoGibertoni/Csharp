namespace _5___CaracteresETexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");

            char primeiraLetra = 'a';
            Console.WriteLine("Primeira letra: " + primeiraLetra);

            primeiraLetra = (char)65; //ASCII table
            Console.WriteLine("Char 65: " + primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("Char +1: " + primeiraLetra);

            string titulo = "Curso alura";
            Console.WriteLine(titulo);

        }
    }
}
