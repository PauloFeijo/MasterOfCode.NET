/*
Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle permite:

Aumentar ou diminuir a potência do volume de som em uma unidade de cada vez.
Aumentar e diminuir o número do canal em uma unidade.
Trocar para um canal indicado.
Consultar o valor do volume de som e o canal selecionado.
Imprima os dados via console.
*/

using MDCComum;

namespace UtilizandoPOO.Exercicio4
{
    class Program
    {
        static void Main()
        {
            var tela = new Tela("Utilizando POO - Exercício 4");
            var entrada = new EntradaDeDados(tela);

            var controle = new ControleRemoto(new Televisao());
            var opc = -1;

            while (opc != 0)
            {
                string[] opcoes =
                {
                    "Selecione a opção do controle remoto:",
                    "1 - Aumentar o volume",
                    "2 - Diminuir o volume",
                    "3 - Ir para o próximo canal",
                    "4 - Voltar para o canal anterior",
                    "5 - Selecionar o canal",
                    "6 - Ver o volume atual",
                    "7 - Ver o canal sintonizado",
                    "0 - Sair",
                };

                opc = entrada.SelecionarItemMenuOpcoes("Selecione a opção do controle remoto: ", opcoes);

                tela.Limpar();

                switch (opc)
                {
                    case 0:
                        tela.Finalizar();
                        break;
                    case 1:
                        controle.AumentarVolume();
                        tela.EscreverNaCor($"Volume: {controle.LerVolume()}", Tela.corResultado);
                        break;
                    case 2:
                        controle.DiminuirVolume();
                        tela.EscreverNaCor($"Volume: {controle.LerVolume()}", Tela.corResultado);
                        break;
                    case 3:
                        controle.AumentarCanal();
                        tela.EscreverNaCor($"Canal: {controle.LerCanal()}", Tela.corResultado);
                        break;  
                    case 4:
                        controle.DiminuirCanal();
                        tela.EscreverNaCor($"Canal: {controle.LerCanal()}", Tela.corResultado);
                        break;
                    case 5:
                        var canal = entrada.LerInteiro("Informe o número do canal: ");
                        controle.SintonizarCanal(canal);
                        tela.EscreverNaCor($"Canal: {controle.LerCanal()}", Tela.corResultado);
                        break;
                    case 6:
                        tela.EscreverNaCor($"Volume: {controle.LerVolume()}", Tela.corResultado);
                        break;
                    case 7:
                        tela.EscreverNaCor($"Canal: {controle.LerCanal()}", Tela.corResultado);
                        break;                                                                                                                      
                    default:
                        tela.EscreverNaCor("Opção inválida!", Tela.corResultado);
                        break;
                } 

                tela.PularLinha();
            }
        }
    }
}
