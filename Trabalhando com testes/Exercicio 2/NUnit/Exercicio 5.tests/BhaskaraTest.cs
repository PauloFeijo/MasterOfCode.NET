using NUnit.Framework;

namespace Exercicio_5.tests
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
            var bhaskara = new Bhaskara();

            bhaskara.A = 1;
            bhaskara.B = 12;
            bhaskara.C = -13;

            Assert.AreEqual(0, bhaskara.R1);
            Assert.AreEqual(0, bhaskara.R2);            

            bhaskara.Calcular();

            Assert.AreEqual(1, bhaskara.R1);
            Assert.AreEqual(-13, bhaskara.R2);
        }        
    }
}