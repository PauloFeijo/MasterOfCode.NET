using NUnit.Framework;

namespace Exercicio_1.tests
{
    public class CalculadoraTest
    {
        private Calculadora calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculadora();
            calc.valorA = 2.5;
            calc.valorB = 11.5;            
        }

        [Test]
        public void SomarTest()
        {
            Assert.AreEqual(14, calc.Somar());
        }

        [Test]
        public void SubtrairTest()
        {
            Assert.AreEqual(-9, calc.Subtrair());
        }  

        [Test]
        public void DividirTest()
        {
            Assert.AreEqual(4.6, calc.Dividir());
        }

        [Test]
        public void MultiplicarTest()
        {
            Assert.AreEqual(28.75, calc.Multiplicar());
        }                      
    }
}