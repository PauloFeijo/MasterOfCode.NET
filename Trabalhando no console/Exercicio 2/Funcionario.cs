namespace Exercicio_2
{
    class Funcionario    
    {
        public string nome { get; set; }
        public double salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }
    }
}
