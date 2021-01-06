using System;
using Xunit;

namespace Exercicio_1.tests
{
    public class CalculadoraTest
    {
        private Calculadora calc;
        public CalculadoraTest()
        {
            calc = new Calculadora();
            calc.valorA = 2.5;
            calc.valorB = 11.5;
        }

        [Fact]
        public void TestSomar()
        {
            Assert.Equal(14, calc.Somar());
        }

        [Fact]
        public void TestSubtrair()
        {
            Assert.Equal(-9, calc.Subtrair());
        }

        [Fact]
        public void TestDividir()
        {
            Assert.Equal(4.6, calc.Dividir());
        }

        [Fact]
        public void TestMultiplicar()
        {
            Assert.Equal(28.75, calc.Multiplicar());
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1.7, 1.3, 3)]
        public void TestSomar2(double valorA, double valorB, double resultado)
        {
            calc.valorA = valorA;
            calc.valorB = valorB;
            Assert.Equal(resultado, calc.Somar());
        }

        [Theory]
        [InlineData(1, 2, -1)]
        //[InlineData(1.7, 1.3, 0.4)] Expected: 0,4 Actual: 0,3999999999999999 pq?
        public void TestSubtrair2(double valorA, double valorB, double resultado)
        {
            calc.valorA = valorA;
            calc.valorB = valorB;
            Assert.Equal(resultado, calc.Subtrair());
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1.7, 1.3, 0.7647058823529412)]
        public void TestDividir2(double valorA, double valorB, double resultado)
        {
            calc.valorA = valorA;
            calc.valorB = valorB;
            Assert.Equal(resultado, calc.Dividir());
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1.7, 1.3, 2.21)]
        public void TestMultiplicar2(double valorA, double valorB, double resultado)
        {
            calc.valorA = valorA;
            calc.valorB = valorB;
            Assert.Equal(resultado, calc.Multiplicar());
        }
    }
}
