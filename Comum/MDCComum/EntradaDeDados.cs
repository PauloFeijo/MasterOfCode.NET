using System;

namespace MDCComum
{
    public class EntradaDeDados
    {
        private readonly Tela _tela;

        public EntradaDeDados(Tela tela)
        {
            _tela = tela;
        }

        public double LerDecimal(string msg)
        {
            var txt = LerTexto(msg);

            if (double.TryParse(txt, out double vlr))
            {
                return vlr;
            }

            _tela.EscreverNaCor("Valor inválido!", Tela.corErro);
            return LerDecimal(msg);
        }

        public bool LerDecimal(string msg, ref double vlr)
        {
            var txt = LerTexto(msg);

            if (txt == "")
            {
                return false;
            }

            if (double.TryParse(txt, out vlr))
            {
                return true;
            }

            _tela.EscreverNaCor("Valor inválido!", Tela.corErro);
            return LerDecimal(msg, ref vlr);
        }

        public bool LerInteiro(string msg, ref int vlr)
        {
            var txt = LerTexto(msg);

            if (txt == "")
            {
                return false;
            }

            if (int.TryParse(txt, out vlr))
            {
                return true;
            }

            _tela.EscreverNaCor("Valor inválido!", Tela.corErro);
            return LerInteiro(msg, ref vlr);
        }

        public int LerInteiro(string msg)
        {
            var txt = LerTexto(msg);

            if (int.TryParse(txt, out int vlr))
            {
                return vlr;
            }

            _tela.EscreverNaCor("Valor inválido!", Tela.corErro);
            return LerInteiro(msg);
        }

        public string LerTexto(string msg)
        {
            Console.ForegroundColor = Tela.corPergunta;
            Console.Write(msg);

            Console.ForegroundColor = Tela.corEntrada;
            var retorno = Console.ReadLine();

            Console.ForegroundColor = Tela.corPadrao;

            return retorno;
        }

        public int SelecionarItemMenuOpcoes(string msg, string[] opcoes)
        {
            foreach (string opcao in opcoes)
            {
                Console.WriteLine(opcao);
            }

            return LerInteiro(msg);
        }
    }
}
