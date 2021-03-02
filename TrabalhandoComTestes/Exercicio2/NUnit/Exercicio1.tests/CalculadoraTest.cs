using NUnit.Framework;
using TrabalhandoNoConsole.Exercicio1;

namespace TrabalhandoComTestes.Exercicio2.NUnit.Exercicio1.tests
{
    public class CalculadoraTest
    {
        private Calculadora calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculadora
            {
                ValorA = 2.5,
                ValorB = 11.5
            };
        }

        [Test]
        public void TestSomar()
        {
            Assert.AreEqual(14, calc.Somar());
        }

        [Test]
        public void TestSubtrair()
        {
            Assert.AreEqual(-9, calc.Subtrair());
        }  

        [Test]
        public void TestDividir()
        {
            Assert.AreEqual(4.6, calc.Dividir());
        }

        [Test]
        public void TestMultiplicar()
        {
            Assert.AreEqual(28.75, calc.Multiplicar());
        }                      
    }
}