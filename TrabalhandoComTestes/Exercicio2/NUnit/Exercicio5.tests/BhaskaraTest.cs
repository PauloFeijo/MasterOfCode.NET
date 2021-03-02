using NUnit.Framework;
using TrabalhandoNoConsole.Exercicio5;

namespace TrabalhandoComTestes.Exercicio2.NUnit.Exercicio5.tests
{
    public class BhaskaraTest
    {
        [Test]
        public void TestCalculoCtor()
        {
            var bhaskara = new Bhaskara(1, 12, -13);

            Assert.AreEqual(1, bhaskara.R1);
            Assert.AreEqual(-13, bhaskara.R2);
        }

        [Test]
        public void TestCalculo()
        {
            var bhaskara = new Bhaskara
            {
                A = 1,
                B = 12,
                C = -13
            };

            Assert.AreEqual(0, bhaskara.R1);
            Assert.AreEqual(0, bhaskara.R2);            

            bhaskara.Calcular();

            Assert.AreEqual(1, bhaskara.R1);
            Assert.AreEqual(-13, bhaskara.R2);
        }        
    }
}