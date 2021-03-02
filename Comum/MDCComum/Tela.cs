using System;

namespace MDCComum
{
    public class Tela
    {
        public const ConsoleColor corInformacao = ConsoleColor.White;
        public const ConsoleColor corInformacaoDestaque = ConsoleColor.Yellow;
        public const ConsoleColor corResultado = ConsoleColor.Green;
        public const ConsoleColor corErro = ConsoleColor.Red;
        public const ConsoleColor corPadrao = ConsoleColor.White;
        public const ConsoleColor corPergunta = ConsoleColor.Gray;
        public const ConsoleColor corEntrada = ConsoleColor.Cyan;
        private const int largura = 100;
        private const string nomeAplicacao = "*** M E S T R E   D O S   C Ó D I G O S ***";
        private const ConsoleColor corNomeAplicacao = ConsoleColor.Red;
        private const ConsoleColor corTitulo = ConsoleColor.DarkGray;
        private const ConsoleColor corLinha = ConsoleColor.DarkCyan;

        public Tela(string titulo)
        {
            Titulo = titulo;
            Cabecalho();
        }

        public string Titulo { get; set; }

        public void Limpar()
        {
            Cabecalho();
        }

        public void EscreverNaCor(string txt, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;

            Console.WriteLine(txt);

            Console.ForegroundColor = corPadrao;
        }

        public void Escrever(string txt)
        {
            Console.WriteLine(txt);
        }

        public void EscreverNaMesmaLinha(string txt)
        {
            Console.Write(txt);
        }

        public void EscreverNaMesmaLinhaENaCor(string txt, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;

            Console.Write(txt);

            Console.ForegroundColor = corPadrao;
        }

        public void PularLinha(int linhas = 1)
        {
            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine("");
            }
        }

        public void Finalizar()
        {
            Console.WriteLine("Bye bye");
        }

        public void DesenharLinha()
        {
            Console.ForegroundColor = corLinha;

            for (int i = 0; i < largura; i++)
            {
                Console.Write("═");
            }
            Console.ForegroundColor = corPadrao;

            PularLinha();
        }

        private void EscreverCentralizadoENaCor(string txt, int linha, ConsoleColor cor)
        {
            var posicao = (largura - txt.Length) / 2;

            Console.SetCursorPosition(posicao, linha);

            EscreverNaCor(txt, cor);
        }

        private void Cabecalho()
        {
            Console.Clear();

            DesenharLinha();

            EscreverCentralizadoENaCor(nomeAplicacao, 1, corNomeAplicacao);

            EscreverCentralizadoENaCor(Titulo, 2, corTitulo);

            DesenharLinha();
        }
    }
}
