/*
Responda e demonstre no código os itens abaixo:

O que é POO?
O que é polimorfismo?
O que é abstração?
O que é encapsulamento?
Quando usar uma classe abstrata e quando devo usar uma interface?
O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
Existe herança múltipla (de classes) em C#?
*/
using System;
using System.Collections.Generic;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarOqueEhPOO();
            MostrarOQueEhPolimorfismo();
            MostrarOQueEhAbstracao();
            MostrarOQueEhEncapsulamento();
            MostrarQuandoUsarInterfaceOuClasseAbstrata();
            MostrarInterfaceIDisposable();
            MostrarInterfaceIComparable();
            // O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
            // Existe herança múltipla (de classes) em C#?
        }

        static void MostrarOqueEhPOO()
        {
            Console.WriteLine("");
            Console.WriteLine("1) O que é POO?");
            Console.WriteLine("Programação orientada a objetos (POO, ou OOP segundo as suas siglas em inglês) é um paradigma "+
              "de programação baseado no conceito de \"objetos\", que podem conter dados na forma de campos, também conhecidos "+
              "como atributos, e códigos, na forma de procedimentos, também conhecidos como métodos. Uma característica de objetos "+
              "é que um procedimento de objeto pode acessar, e geralmente modificar, os campos de dados do objeto com o qual eles "+
              "estão associados (objetos possuem uma noção de \"this\" (este) ou \"self\" (próprio)).");
            // fonte: https://pt.wikipedia.org/wiki/Programa%C3%A7%C3%A3o_orientada_a_objetos
            Separar();
        }

        static void MostrarOQueEhPolimorfismo()
        {
            Console.WriteLine("2) O que é Polimorfismo?");
            Console.WriteLine("Polimorfismo é o princípio pelo qual duas ou mais classes derivadas de uma mesma superclasse podem invocar "+
              "métodos que têm a mesma identificação (assinatura) mas comportamentos distintos, especializados para cada classe derivada, "+
              "usando para tanto uma referência a um objeto do tipo da superclasse. A decisão sobre qual o método que deve ser selecionado, "+
              "de acordo com o tipo da classe derivada, é tomada em tempo de execução, através do mecanismo de ligação tardia.");
            Console.WriteLine("");

            Console.WriteLine("No exemplo abaixo, temos a classe \"Pessoa\" que contêm o método \"Cumprimentar\". As classes filhas \"Ingles\", "+
              "\"Brasileiro\" e \"Paranaense\" sobrescrevem este método de acordo com sua particularidade: ");
            // fonte: http://www.dca.fee.unicamp.br/cursos/PooJava/polimorf/index.html#:~:text=Polimorfismo%20%C3%A9%20o%20princ%C3%ADpio%20pelo,objeto%20do%20tipo%20da%20superclasse.
            Console.WriteLine("");

            Pessoa brasileiro = new Brasileiro();
            Pessoa ingles = new Ingles();
            Pessoa paranaense = new Paranaense();

            Console.WriteLine("Cumprimentar o Brasileiro:");
            Cumprimentar(brasileiro);
            Console.WriteLine("");

            Console.WriteLine("Cumprimentar o Inglês:");
            Cumprimentar(ingles);
            Console.WriteLine("");

            Console.WriteLine("Cumprimentar o Paranaense:");
            Cumprimentar(paranaense);

            Separar();
        }

        static void Cumprimentar(Pessoa pessoa)
        {
            pessoa.Cumprimentar();
        }

        static void Separar()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("");
        }

        static void MostrarOQueEhAbstracao()
        {
            Console.WriteLine("3) O que é abstração?");
            Console.WriteLine("Abstração é a habilidade de concentrar nos aspectos essenciais de um contexto qualquer, ignorando características menos "+
              "importantes ou acidentais. Em modelagem orientada a objetos, uma classe é uma abstração de entidades existentes no domínio do sistema de software.");
            // Fonte: https://pt.wikipedia.org/wiki/Abstra%C3%A7%C3%A3o_(ci%C3%AAncia_da_computa%C3%A7%C3%A3o)#:~:text=Abstra%C3%A7%C3%A3o%20%C3%A9%20a%20habilidade%20de,dom%C3%ADnio%20do%20sistema%20de%20software.

            Console.WriteLine("No exemplo abaixo, a classe \"Pessoa\" é abstrata, e não pode ser instanciada, ela é uma \"abstração\" do que é uma pessoa.");
            // Pessoa pessoa = new Pessoa();
            Console.WriteLine("Mas podemos ter um objeto do tipo \"Pessoa\" instanciado pela classe \"Brasileiro\" já que esta é uma classe concreta.");
            Pessoa pessoa = new Brasileiro();

            Separar();
        }

        static void MostrarOQueEhEncapsulamento()
        {
            Console.WriteLine("4) O que é encapsulamento?");
            Console.WriteLine("Encapsulamento é a técnica que faz com que detalhes internos do funcionamento dos métodos de uma classe "+
              "permaneçam ocultos para os objetos. Por conta dessa técnica, o conhecimento a respeito da implementação interna da classe "+
              "é desnecessário do ponto de vista do objeto, uma vez que isso passa a ser responsabilidade dos métodos internos da classe.");
            // Fonte: https://www.devmedia.com.br/conceitos-encapsulamento-programacao-orientada-a-objetos/18702

            Console.WriteLine("No exemplo abaixo, a classe \"Conta\" possui o atributo \"saldo\" o qual não pode ser modificado diretamente, "+
              "por estar encapsulado com visibilidade \"private\", sendo possível modificar o saldo apenas pelos métodos \"Sacar\" e \"Depositar\".");
            Console.WriteLine("");

            Conta conta = new Conta();

            Console.WriteLine($"Criada a conta, saldo atual: {conta.saldo}");
            Console.WriteLine("É possível ler o atributo saldo pois o mesmo se encontra public para leitura.");
            Console.WriteLine("");

            Console.WriteLine("Não é possivel atribuir o valor ao atributo saldo diretamente, ocorre um erro de compilação, pelo motivo de estar "+
              "encapsulado como private e ser acessível somente dentro da classe.");
            //conta.saldo = 10;
            Console.WriteLine("");

            Console.WriteLine("Modificando o atributo saldo pelo método Depositar (100)");
            conta.Depositar(100);

            Console.WriteLine("Modificando o atributo saldo pelo método Sacar (50)");
            conta.Sacar(50);

            Console.WriteLine($"Saldo após lançamentos: {conta.saldo}");

            Separar();
        }

        static void Exportar(IExportavel exportavel)
        {
            exportavel.Exportar();
        }

        static void MostrarQuandoUsarInterfaceOuClasseAbstrata()
        {
            Console.WriteLine("5) Quando usar uma classe abstrata e quando devo usar uma interface?");
            Console.WriteLine("Devo utilizar uma classe abstrata quando eu tenho uma abstração na qual pretendo ter métodos abstratos, ou seja, sem implementação, "+
              "deixando para a classe específica implementar, mas também desejo ter métodos \"padrão\" (default), na qual a classe específica pode escolher entre "+
              "sobrescrever o comportamento ou não, ou até estender o comportamento.");

            Console.WriteLine("Devo utilizar uma interface quando tenho uma abstração de um comportamento na qual desejo que objetos dos mais variados tipos possuam, "+
              "no caso implementando os métodos desta interface, se comportando como um contrato.");
            Console.WriteLine("");

           Console.WriteLine("No exemplo abaixo, temos o objeto brasileiro que é uma \"Pessoa\" (abstrata) e implementa a interface \"IExportavel\", e também o objeto "+
             "conta que é uma \"Conta\" que não herda de \"Pessoa\" e que também implementa \"IExportavel\".");
            Console.WriteLine("");

            Pessoa brasileiro = new Brasileiro();
            Pessoa ingles = new Ingles();
            Conta conta = new Conta();
            // Pessoa pessoa = new Pessoa(); não posso, classe abstrata não permite instância
            // IExportavel exportavel = new IExportavel(); não posso, interface não permite instância

            //Exportar(brasileiro); não deixa, pois Pessoa não implementa a interface, mesmo eu criando como Brasileiro
            Exportar(brasileiro as IExportavel); // usando o type casting para IExportavel permite, pois sei que implementa
            //Exportar(ingles); não permite pois Pessoa não implementa a interface (nem Ingles)
            //Exportar(ingles as IExportavel); permite, não ocorre erro de compilação, porém ocorre erro de execução, pois Ingles não implementa a interface
            Exportar(conta);

            Separar();
        }

        static void MostrarInterfaceIDisposable()
        {
          Console.WriteLine("6.1) O que faz a interface IDisposable?");
          Console.WriteLine("Realiza tarefas definidas pelo aplicativo associadas à liberação ou à redefinição de recursos não gerenciados.");
          // Fonte: https://docs.microsoft.com/pt-br/dotnet/api/system.idisposable.dispose?view=net-5.0

          Disposable obj = new Disposable();   
          obj.Dispose();

          Separar();
        }

        static void MostrarInterfaceIComparable()
        {
          Console.WriteLine("6.2) O que faz a interface IComparable?");
          Console.WriteLine("Define um método de comparação de tipo específico generalizado que implementa uma classe ou um tipo de valor para solicitar "+
            "ou classificar suas instâncias.");
          // Fonte: https://docs.microsoft.com/pt-br/dotnet/api/system.icomparable?view=net-5.0
          Console.WriteLine("No exemplo abaixo, é utilizado o IComparable no metodo Sort() de uma lista de objetos");

          List<Comparable> lista = new List<Comparable>();

          lista.Add(new Comparable(5));
          lista.Add(new Comparable(2));
          lista.Add(new Comparable(1));
          lista.Add(new Comparable(4));
          lista.Add(new Comparable(9));
          lista.Add(new Comparable(7));
          lista.Add(new Comparable(3));
          lista.Add(new Comparable(6));

          lista.Sort();

          lista.ForEach(i => Console.WriteLine(i.codigo));

          Separar();
        }
    }
}
