namespace primeiro_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Screen Sound
            string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound!";
            List<string> listasDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};

            void exibirLogo()
            {
                Console.WriteLine("\r█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄\r\n▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀\n");
                Console.WriteLine(mensagemDeBoasVindas);
            }

            void exibirOpcoesDoMenu()
            {
                Console.Clear();
                exibirLogo();

                Console.WriteLine("\n0 - Sair");
                Console.WriteLine("1 - Registrar uma banda");
                Console.WriteLine("2 - Mostrar Todas as bandas");
                Console.WriteLine("3 - Avaliar uma banda");
                Console.WriteLine("4 - Exibir a média da banda\n");

                Console.Write("Digite uma das opções: ");
                int opcaoEscolhida = int.Parse(Console.ReadLine());

                switch (opcaoEscolhida)
                {
                    case 0: Console.WriteLine("Até Mais!");
                        break;
                    case 1: registrarBanda();
                        break;
                    case 2: mostrarBandasRegistradas();
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida);
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida);
                        break;
                    default:
                        Console.WriteLine("Numero Inválido!");
                        exibirOpcoesDoMenu();
                        break;
                }
            }

            void registrarBanda()
            {
                Console.Clear();
                Console.WriteLine("Registro de Bandas\n");
                Console.Write("Digite o nome da banda que deseja registrar: ");
                string nomeDaBanda = Console.ReadLine()!;
                listasDasBandas.Add(nomeDaBanda);
                Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
                Thread.Sleep(2500);
                exibirOpcoesDoMenu();
            }

            void mostrarBandasRegistradas()
            {
                Console.Clear();
                Console.WriteLine("Lista de Bandas\n");
                foreach (string banda in listasDasBandas) //parecido com for
                {
                    Console.WriteLine($"Banda: {banda}");
                }
                Console.WriteLine("\nInteraja para voltar ao menu");
                Console.ReadKey();
                exibirOpcoesDoMenu();
            }

            exibirOpcoesDoMenu();
        }
    }
}
