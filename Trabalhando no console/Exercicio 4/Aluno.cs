namespace Exercicio_4
{
    class Aluno
    {
        public string nome { get; set; }
        public double[] notas { get; set; }

        public Aluno()
        {
            notas = new double[4] {0, 0, 0, 0};
        }
    }
    
}