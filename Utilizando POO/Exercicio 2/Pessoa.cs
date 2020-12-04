using System;
namespace Exercicio_2 
{
    class Pessoa 
    {
        private string _nome;
        private string _dataNascimento;
        private double _altura;

        public string GetNome() 
        {
            return _nome;
        }

        public void SetNome(string value)
        {
            _nome = value;
        }

        public string GetDataNascimento()
        {
            return _dataNascimento;
        }

        public void SetDataNascimento(string value)
        {
            if (DateTime.TryParse(value, out DateTime dataValida))
            {
                _dataNascimento = value;
            }
            else
            {
                Console.WriteLine("Data ínválida!");
            }            
        }       

        public double GetAltura()
        {
            return _altura;
        }

        public void SetAltura(double value)
        {
            _altura = value;
        }

        public override string ToString()
        {
            return $"Nome: {this._nome}, Data de Nascimento: {this._dataNascimento}, Altura: {this._altura}, Idade: {this.GetIdade()}";
        }

        public int GetIdade()
        {
            if (DateTime.TryParse(_dataNascimento, out DateTime dataNascimento))
            {
                return new DateTime((DateTime.Now - dataNascimento).Ticks).Year - 1;
            }
            Console.WriteLine("Data ínválida!"); 
            return 0;                   
        }
    }
}