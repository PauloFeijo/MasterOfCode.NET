/*6. Crie uma aplicação, que demonstre a diferença entre REF e OUT.*/

using MDCComum;

namespace TrabalhandoNoConsole.Exercicio6
{
    class Program
    {
        private static Tela tela;
        static void Main()
        {
            tela = new Tela("Trabalhando no Console - Exercício 6");

            tela.EscreverNaCor("Diferença entre REF e OUT:", Tela.corInformacaoDestaque);
            tela.PularLinha();

            var texto = "Valor original";
            tela.EscreverNaCor($"Valor inicial: [{texto}]", Tela.corInformacao);
            tela.PularLinha();

            PassarParametroComum(texto);
            tela.EscreverNaCor($"O Valor não é modificado: [{texto}]", Tela.corResultado);
            tela.PularLinha();

            PassarParametroREF(ref texto);
            tela.EscreverNaCor($"O Valor é modificado: [{texto}]", Tela.corResultado);
            tela.PularLinha();

            texto = "Valor original";
            PassarParametroOUT(out texto);
            tela.EscreverNaCor($"O valor é modificado: [{texto}]", Tela.corResultado);  
        }

        static void PassarParametroComum(string txt)
        {
            tela.EscreverNaCor($"Passagem de parâmetro comum: O valor chega no método: [{txt}]", Tela.corInformacao);
            txt = "Modificado comum";
            tela.EscreverNaCor(txt, Tela.corInformacao);
        }

        static void PassarParametroREF(ref string txt)
        {
            tela.EscreverNaCor($"Passagem de parâmetro REF: O valor original chega no método: [{txt}]", Tela.corInformacao);
            txt = "Modificado REF";
        }

        static void PassarParametroOUT(out string txt)
        {
            tela.EscreverNaCor("Passagem de parâmetro OUT: O valor original NÃO chega no método: [o compilador não deixa utilizar uma variavel out não inicializada]", Tela.corInformacao);
            txt = "Modificado OUT";
        }               
    }
}
