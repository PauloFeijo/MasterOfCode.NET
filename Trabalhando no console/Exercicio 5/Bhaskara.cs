using System;

namespace Exercicio_5
{
    public class Bhaskara    
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Delta { get; set; }
        public double R1 { get; set; }
        public double R2 { get; set; }

        public Bhaskara() {}
        
        public Bhaskara(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            Calcular();
        }

        public void Calcular()
        {
            Delta = Math.Pow(B, 2) - (4 * A * C);
            double raizDelta = Math.Sqrt(Delta);

            R1 = ((B * -1) + raizDelta) / (2 * A);
            R2 = ((B * -1) - raizDelta) / (2 * A);            
        }
    }
}