using System;
namespace UtilizandoPOO.Exercicio2 
{
    class Pessoa 
    {
        private string _nome;
        private DateTime _dataNascimento;
        private double _altura;

        public void SetarNome(string nome) => _nome = nome;

        public void SetarDataNascimento(DateTime dataNascimento) => _dataNascimento = dataNascimento;

        public void SetarAltura(double value) => _altura = value;

        public override string ToString() => 
            $"Nome: {_nome}, Data de Nascimento: {_dataNascimento:d}, Altura: {_altura}, Idade: {GetIdade()}";

        public int GetIdade() => 
            new DateTime((DateTime.Now - _dataNascimento).Ticks).Year - 1;
    }
}