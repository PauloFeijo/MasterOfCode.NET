namespace TrabalhandoNoConsole.Exercicio1
{
    public class Calculadora    
    {
        public double ValorA { get; set; }
        public double ValorB { get; set; }

        public double Somar() => ValorA + ValorB;

        public double Subtrair() => ValorA - ValorB;

        public double Dividir() => ValorB / ValorA;

        public double Multiplicar() => ValorA * ValorB;
    }
}
