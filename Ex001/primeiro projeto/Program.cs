namespace primeiro_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Screen Sound
            string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound!";

            void exibirMensagemDeBoasVindas() //criar função
            {
                Console.WriteLine(mensagemDeBoasVindas);
            }

            exibirMensagemDeBoasVindas(); //exibir função
        }
    }
}
