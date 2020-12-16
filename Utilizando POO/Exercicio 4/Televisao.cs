using System;

namespace Exercicio_4
{
    class Televisao : IInteracaoTV
    { 
        private int _volume = 10;
        private int _canal = 1;

        public void AumentarVolume()
        {
            if (_volume == 100) return;
            _volume++;
        } 

        public void DiminuirVolume() 
        {
            if (_volume == 0) return;
            _volume--;
        }

        public void AumentarCanal() 
        {
            if (_canal == 100) 
            {
                _canal = 1;
                return;
            }
            _canal++;
        }

        public void DiminuirCanal()
        {
            if (_canal == 1) 
            {
                _canal = 100;
                return;
            }            
            _canal--; 
        }

        public void SintonizarCanal(int canal) 
        {
            if (canal < 0 || canal > 100) return;
            _canal = canal;
        }

        public int LerCanal() => _canal;
        public int LerVolume() => _volume;

    }
}