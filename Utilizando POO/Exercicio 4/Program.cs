/*
Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle permite:

Aumentar ou diminuir a potência do volume de som em uma unidade de cada vez.
Aumentar e diminuir o número do canal em uma unidade.
Trocar para um canal indicado.
Consultar o valor do volume de som e o canal selecionado.
Imprima os dados via console.
*/

using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var controle = new ControleRemoto(new Televisao());
            var opc = "";

            while (opc != "0")
            { 
                Console.WriteLine("");
                Console.WriteLine("Selecione a opção do controle remoto:");
                Console.WriteLine("1 - Aumentar o volume");
                Console.WriteLine("2 - Diminuir o volume");
                Console.WriteLine("3 - Ir para o próximo canal");
                Console.WriteLine("4 - Voltar para o canal anterior");
                Console.WriteLine("5 - Selecionar o canal");
                Console.WriteLine("6 - Ver o volume atual");
                Console.WriteLine("7 - Ver o canal sintonizado");
                Console.WriteLine("0 - Sair");

                opc = Console.ReadLine(); 
                Console.WriteLine("");

                switch (opc)
                {
                    case "0":
                        break;
                    case "1":
                        controle.AumentarVolume();
                        Console.WriteLine($"Volume: {controle.LerVolume()}");
                        break;
                    case "2":
                        controle.DiminuirVolume();
                        Console.WriteLine($"Volume: {controle.LerVolume()}");
                        break;
                    case "3":
                        controle.AumentarCanal();
                        Console.WriteLine($"Canal: {controle.LerCanal()}");
                        break;  
                    case "4":
                        controle.DiminuirCanal();
                        Console.WriteLine($"Canal: {controle.LerCanal()}");
                        break;
                    case "5":
                        var canal = 0;
                        while (true)
                        {
                            Console.Write("Canal: ");
                            var txt = Console.ReadLine();
                            if (Int32.TryParse(txt, out int vlr)) 
                            {
                                canal = vlr;
                                break;
                            }
                            Console.WriteLine("Valor inválido!");
                        }                         
                        controle.SintonizarCanal(canal);
                        Console.WriteLine($"Canal: {controle.LerCanal()}");
                        break;
                    case "6":
                        Console.WriteLine($"Volume: {controle.LerVolume()}");
                        break;
                    case "7":
                        Console.WriteLine($"Canal: {controle.LerCanal()}");
                        break;                                                                                                                      
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;                 
                } 
            }
        }
    }
}
