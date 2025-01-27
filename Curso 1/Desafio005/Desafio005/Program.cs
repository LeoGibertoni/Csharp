namespace Desafio005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            List<string> bandas = new List<string>();

            void menu()
            {
                Console.Clear();
                Console.WriteLine("1 - Registrar");
                Console.WriteLine("2 - Lista\n");
                Console.Write("Digite um valor: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();
                    Console.Write("Digite uma banda: ");
                    string nomeDaBanda = Console.ReadLine()!;
                    bandas.Add(nomeDaBanda);
                    menu();
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Lista de Bandas\n");
                    for (int i = 0; i < bandas.Count; i++)
                    {
                        Console.WriteLine($"Banda: {bandas[i]}");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Numero Invalido!\n");
                    Thread.Sleep(2000);
                    menu();
                }
            }


            menu();
        }
    }
}
