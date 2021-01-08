using System;
using Xunit;

namespace Exercicio_5.tests
{
    public class BhaskaraTest
    {
        [Fact]
        public void TestCalculoCtor()
        {
            var bhaskara = new Bhaskara(1, 12, -13);

            Assert.Equal(1, bhaskara.R1);
            Assert.Equal(-13, bhaskara.R2);
        }

        [Fact]
        public void TestCalculo()
        {
            var bhaskara = new Bhaskara();

            bhaskara.A = 1;
            bhaskara.B = 12;
            bhaskara.C = -13;

            Assert.Equal(0, bhaskara.R1);
            Assert.Equal(0, bhaskara.R2);

            bhaskara.Calcular();

            Assert.Equal(1, bhaskara.R1);
            Assert.Equal(-13, bhaskara.R2);
        }

        [Theory]
        [InlineData(1, 12, -13, 1, -13)]
        [InlineData(2, -16, -18, 9, -1)]
        [InlineData(1, -1, -6, 3, -2)]
        public void TestCalculoCtor2(double a, double b, double c, double r1, double r2)
        {
            var bhaskara = new Bhaskara(a, b, c);

            Assert.Equal(r1, bhaskara.R1);
            Assert.Equal(r2, bhaskara.R2);
        }

        [Theory]
        [InlineData(1, 12, -13, 1, -13)]
        [InlineData(2, -16, -18, 9, -1)]
        [InlineData(1, -1, -6, 3, -2)]
        public void TestCalculo2(double a, double b, double c, double r1, double r2)
        {
            var bhaskara = new Bhaskara();

            bhaskara.A = a;
            bhaskara.B = b;
            bhaskara.C = c;

            Assert.Equal(0, bhaskara.R1);
            Assert.Equal(0, bhaskara.R2);

            bhaskara.Calcular();

            Assert.Equal(r1, bhaskara.R1);
            Assert.Equal(r2, bhaskara.R2);
        }
    }
}
