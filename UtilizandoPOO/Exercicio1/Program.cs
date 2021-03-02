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
using MDCComum;
using System.Collections.Generic;

namespace UtilizandoPOO.Exercicio1
{
    class Program
    {
        private static Tela tela;
        static void Main()
        {
            tela = new Tela("Utilizando POO - Exercício 1");

            MostrarOqueEhPOO();
            MostrarOQueEhPolimorfismo();
            MostrarOQueEhAbstracao();
            MostrarOQueEhEncapsulamento();
            MostrarQuandoUsarInterfaceOuClasseAbstrata();
            MostrarInterfaceIDisposable();
            MostrarInterfaceIComparable();
            MostrarInterfaceICloneable();
            MostrarInterfaceIEnumerable();
            MostrarExisteHerancaMultiplaCSharp();
        }

        static void MostrarOqueEhPOO()
        {
            tela.EscreverNaCor("1) O que é POO?", Tela.corInformacaoDestaque);
            tela.PularLinha();

            tela.Escrever("Programação orientada a objetos (POO, ou OOP segundo as suas siglas em inglês) é um paradigma "+
              "de programação baseado no conceito de \"objetos\", que podem conter dados na forma de campos, também conhecidos "+
              "como atributos, e códigos, na forma de procedimentos, também conhecidos como métodos. Uma característica de objetos "+
              "é que um procedimento de objeto pode acessar, e geralmente modificar, os campos de dados do objeto com o qual eles "+
              "estão associados (objetos possuem uma noção de \"this\" (este) ou \"self\" (próprio)).");
            // fonte: https://pt.wikipedia.org/wiki/Programa%C3%A7%C3%A3o_orientada_a_objetos
            tela.PularLinha();
        }

        static void MostrarOQueEhPolimorfismo()
        {
            tela.DesenharLinha();

            tela.EscreverNaCor("2) O que é Polimorfismo?", Tela.corInformacaoDestaque);
            tela.PularLinha();

            tela.Escrever("Polimorfismo é o princípio pelo qual duas ou mais classes derivadas de uma mesma superclasse podem invocar "+
              "métodos que têm a mesma identificação (assinatura) mas comportamentos distintos, especializados para cada classe derivada, "+
              "usando para tanto uma referência a um objeto do tipo da superclasse. A decisão sobre qual o método que deve ser selecionado, "+
              "de acordo com o tipo da classe derivada, é tomada em tempo de execução, através do mecanismo de ligação tardia.");
            tela.PularLinha();

            tela.Escrever("No exemplo abaixo, temos a classe \"Pessoa\" que contêm o método \"Cumprimentar\". As classes filhas \"Ingles\", "+
              "\"Brasileiro\" e \"Paranaense\" sobrescrevem este método de acordo com sua particularidade: ");
            // fonte: http://www.dca.fee.unicamp.br/cursos/PooJava/polimorf/index.html#:~:text=Polimorfismo%20%C3%A9%20o%20princ%C3%ADpio%20pelo,objeto%20do%20tipo%20da%20superclasse.
            tela.PularLinha();

            var brasileiro = new Brasileiro();
            var ingles = new Ingles();
            var paranaense = new Paranaense();

            tela.EscreverNaCor("Cumprimentar o Brasileiro:", Tela.corInformacao);
            Cumprimentar(brasileiro);
            tela.PularLinha();

            tela.EscreverNaCor("Cumprimentar o Inglês:", Tela.corInformacao);
            Cumprimentar(ingles);
            tela.PularLinha();

            tela.EscreverNaCor("Cumprimentar o Paranaense:", Tela.corInformacao);
            Cumprimentar(paranaense);
            tela.PularLinha();
        }

        static void Cumprimentar(Pessoa pessoa) => tela.EscreverNaCor(pessoa.Cumprimentar(), Tela.corResultado);

        static void MostrarOQueEhAbstracao()
        {
            tela.DesenharLinha();

            tela.EscreverNaCor("3) O que é abstração?", Tela.corInformacaoDestaque);
            tela.PularLinha();

            tela.Escrever("Abstração é a habilidade de concentrar nos aspectos essenciais de um contexto qualquer, ignorando características menos "+
              "importantes ou acidentais. Em modelagem orientada a objetos, uma classe é uma abstração de entidades existentes no domínio do sistema de software.");
            // Fonte: https://pt.wikipedia.org/wiki/Abstra%C3%A7%C3%A3o_(ci%C3%AAncia_da_computa%C3%A7%C3%A3o)#:~:text=Abstra%C3%A7%C3%A3o%20%C3%A9%20a%20habilidade%20de,dom%C3%ADnio%20do%20sistema%20de%20software.
            tela.PularLinha();

            tela.Escrever("No exemplo abaixo, a classe \"Pessoa\" é abstrata, e não pode ser instanciada, ela é uma \"abstração\" do que é uma pessoa.");
            tela.EscreverNaCor("var pessoa = new Pessoa();", Tela.corErro);
            tela.PularLinha();

            tela.Escrever("Mas podemos ter um objeto do tipo \"Pessoa\" instanciado pela classe \"Brasileiro\" já que esta é uma classe concreta.");
            tela.EscreverNaCor("var pessoa = new Brasileiro();", Tela.corResultado);

            tela.PularLinha();
        }

        static void MostrarOQueEhEncapsulamento()
        {
            tela.DesenharLinha();

            tela.EscreverNaCor("4) O que é encapsulamento?", Tela.corInformacaoDestaque);
            tela.PularLinha();

            tela.Escrever("Encapsulamento é a técnica que faz com que detalhes internos do funcionamento dos métodos de uma classe "+
              "permaneçam ocultos para os objetos. Por conta dessa técnica, o conhecimento a respeito da implementação interna da classe "+
              "é desnecessário do ponto de vista do objeto, uma vez que isso passa a ser responsabilidade dos métodos internos da classe.");
            // Fonte: https://www.devmedia.com.br/conceitos-encapsulamento-programacao-orientada-a-objetos/18702
            tela.PularLinha();

            tela.Escrever("No exemplo abaixo, a classe \"Conta\" possui o atributo \"saldo\" o qual não pode ser modificado diretamente, "+
              "por estar encapsulado com visibilidade \"private\", sendo possível modificar o saldo apenas pelos métodos \"Sacar\" e \"Depositar\".");
            tela.PularLinha();

            var conta = new Conta();

            tela.EscreverNaMesmaLinha("Criada a conta, saldo atual: ");
            tela.EscreverNaMesmaLinhaENaCor(conta.Saldo.ToString(), Tela.corResultado);
            tela.PularLinha();

            tela.Escrever("É possível ler o atributo saldo pois o mesmo se encontra public para leitura.");
            tela.PularLinha();

            tela.Escrever("Não é possivel atribuir o valor ao atributo saldo diretamente, ocorre um erro de compilação, pelo motivo de estar " +
              "encapsulado como private e ser acessível somente dentro da classe.");
            tela.EscreverNaCor("conta.saldo = 10;", Tela.corErro);
            tela.PularLinha();

            tela.Escrever("Modificando o atributo saldo pelo método Depositar (100)");
            conta.Depositar(100);

            tela.Escrever("Modificando o atributo saldo pelo método Sacar (50)");
            conta.Sacar(50);

            tela.EscreverNaMesmaLinha($"Saldo após lançamentos: ");
            tela.EscreverNaMesmaLinhaENaCor(conta.Saldo.ToString(), Tela.corResultado);
            tela.PularLinha(2);
        }

        static void Exportar(IExportavel exportavel) => exportavel.Exportar();

        static void MostrarQuandoUsarInterfaceOuClasseAbstrata()
        {
            tela.DesenharLinha();

            tela.EscreverNaCor("5) Quando usar uma classe abstrata e quando devo usar uma interface?", Tela.corInformacaoDestaque);
            tela.PularLinha();

            tela.Escrever("Devo utilizar uma classe abstrata quando eu tenho uma abstração na qual pretendo ter métodos abstratos, ou seja, sem implementação, "+
              "deixando para a classe específica implementar, mas também desejo ter métodos \"padrão\" (default), na qual a classe específica pode escolher entre "+
              "sobrescrever o comportamento ou não, ou até estender o comportamento.");
            tela.PularLinha();

            tela.Escrever("Devo utilizar uma interface quando tenho uma abstração de um comportamento na qual desejo que objetos dos mais variados tipos possuam, " +
              "no caso implementando os métodos desta interface, se comportando como um contrato.");
            tela.PularLinha();

            tela.Escrever("No exemplo abaixo, temos o objeto brasileiro que é uma \"Pessoa\" (abstrata) e implementa a interface \"IExportavel\", e também o objeto " +
             "conta que é uma \"Conta\" que não herda de \"Pessoa\" e que também implementa \"IExportavel\".");
            tela.PularLinha();

            tela.EscreverNaCor("Pessoa brasileiro = new Brasileiro();", Tela.corResultado);
            tela.EscreverNaCor("Pessoa ingles = new Ingles();", Tela.corResultado);
            tela.EscreverNaCor("Conta conta = new Conta();", Tela.corResultado);
            tela.PularLinha();

            var conta = new Conta();

            tela.EscreverNaCor("Pessoa pessoa = new Pessoa(); não posso, classe abstrata não permite instância.", Tela.corErro);
            tela.EscreverNaCor("IExportavel exportavel = new IExportavel(); não posso, interface não permite instância.", Tela.corErro);
            tela.PularLinha();

            tela.EscreverNaCor("Exportar(brasileiro); não deixa, pois Pessoa não implementa a interface, mesmo eu criando como Brasileiro.", Tela.corErro);
            tela.EscreverNaCor("Exportar(brasileiro as IExportavel); // usando o type casting para IExportavel permite, pois sei que implementa.", Tela.corErro);
            tela.EscreverNaCor("Exportar(ingles); não permite pois Pessoa não implementa a interface (nem Ingles).", Tela.corErro);
            tela.EscreverNaCor("Exportar(ingles as IExportavel); permite, não ocorre erro de compilação, porém ocorre erro de execução, pois Ingles não implementa a interface.", Tela.corErro);
            tela.PularLinha();

            tela.EscreverNaCor("Exportar(conta); // permite e executa", Tela.corResultado);
            Exportar(conta);
            tela.PularLinha();
        }

        static void MostrarInterfaceIDisposable()
        {
            tela.DesenharLinha();

            tela.EscreverNaCor("6.1) O que faz a interface IDisposable?", Tela.corInformacaoDestaque);
            tela.PularLinha();

            tela.Escrever("Realiza tarefas definidas pelo aplicativo associadas à liberação ou à redefinição de recursos não gerenciados.");
            // Fonte: https://docs.microsoft.com/pt-br/dotnet/api/system.idisposable.dispose?view=net-5.0
            tela.PularLinha();

            using (new Disposable())
            {
                // Execução
            }
            // ao sair do bloco "using" é chamado o método Dispose

            tela.PularLinha();
        }

        static void MostrarInterfaceIComparable()
        {
            tela.DesenharLinha();

            tela.EscreverNaCor("6.2) O que faz a interface IComparable?", Tela.corInformacaoDestaque);
            tela.PularLinha();

            tela.Escrever("Define um método de comparação de tipo específico generalizado que implementa uma classe ou um tipo de valor para solicitar " +
            "ou classificar suas instâncias.");
            // Fonte: https://docs.microsoft.com/pt-br/dotnet/api/system.icomparable?view=net-5.0
            tela.PularLinha();

            tela.Escrever("No exemplo abaixo, é utilizado o IComparable no metodo Sort() de uma lista de objetos");
            tela.PularLinha();

            var lista = new List<Comparable>
            {
                new Comparable(5),
                new Comparable(2),
                new Comparable(1),
                new Comparable(4),
                new Comparable(9),
                new Comparable(7),
                new Comparable(3),
                new Comparable(6)
            };

            lista.Sort();

            lista.ForEach(i => tela.EscreverNaMesmaLinhaENaCor($"{i.Codigo}, ", Tela.corResultado));
            tela.PularLinha(2);
        }

        static void MostrarInterfaceICloneable()
        {
            tela.DesenharLinha();

            tela.EscreverNaCor("6.3) O que faz a interface ICloneable?", Tela.corInformacaoDestaque);
            tela.PularLinha();

            tela.Escrever("A interface ICloneable dá suporte à clonagem, que cria uma nova instância de uma classe com o mesmo valor de uma instância existente.");
            tela.PularLinha();

            tela.Escrever("Esta interface contém o método Clone que dá suporte à clonagem além do que é fornecido pelo método  Object.MemberwiseClone que cria uma" +
                " cópia superficial de Object atual.");
            // Fonte: http://www.macoratti.net/19/05/c_iclone1.htm  
            tela.PularLinha();

            tela.Escrever("No exemplo abaixo é criado um objeto e em seguida clonado:");
            tela.PularLinha();

            var obj = new Cloneable
            {
                Descricao = "Descrição origem"
            };

            var clone = obj.Clone() as Cloneable;

            tela.EscreverNaMesmaLinha("Descrição do objeto origem: ");
            tela.EscreverNaMesmaLinhaENaCor(obj.Descricao, Tela.corResultado);
            tela.PularLinha();

            tela.EscreverNaMesmaLinha($"Descrição do objeto clonado: ");
            tela.EscreverNaMesmaLinhaENaCor(clone.Descricao, Tela.corResultado);
            tela.PularLinha(2);
        }

        static void MostrarInterfaceIEnumerable()
        {
            tela.DesenharLinha();

            tela.EscreverNaCor("6.4) O que faz a interface IEnumerable?", Tela.corInformacaoDestaque);
            tela.PularLinha();

            tela.Escrever("A interface IEnumerable expõe um enumerador que dá suporte a uma iteração simples em uma coleção não genérica.");
            // Fonte: https://docs.microsoft.com/pt-br/dotnet/api/system.collections.ienumerable?view=net-5.0
            tela.PularLinha();

            tela.Escrever("No exemplo abaixo é criado um objeto \"Enumerable\" e um objeto lista enumerável \"Enumerables\".");
            tela.PularLinha();

            var enumerables = new Enumerable[5];

            for (int i = 0; i < enumerables.Length; i++)
            {
              enumerables[i] = new Enumerable ($"Item {i}");
            }

            var enumerablesList = new Enumerables(enumerables);

            foreach (Enumerable e in enumerablesList)
            {
                tela.Escrever(e.Descricao);
            }
            tela.PularLinha();
        }

        static void MostrarExisteHerancaMultiplaCSharp()
        {
            tela.DesenharLinha();

            tela.EscreverNaCor("7) Existe herança múltipla (de classes) em C#?", Tela.corInformacaoDestaque);

            tela.EscreverNaCor("Não", Tela.corResultado);          
        }
    }    
}
