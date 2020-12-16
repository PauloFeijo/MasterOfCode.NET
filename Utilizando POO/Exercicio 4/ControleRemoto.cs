using System;

namespace Exercicio_4
{
    class ControleRemoto 
    {      
        private Televisao _tv;

        public ControleRemoto(Televisao tv) => _tv = tv;

        public void AumentarVolume() => _tv.AumentarVolume();
        public void DiminuirVolume() => _tv.DiminuirVolume();
        public void AumentarCanal() => _tv.AumentarCanal();
        public void DiminuirCanal() => _tv.DiminuirCanal(); 
        public void SintonizarCanal(int canal) => _tv.SintonizarCanal(canal);  
        public int LerCanal() => _tv.LerCanal();
        public int LerVolume() => _tv.LerVolume();      
    }
}