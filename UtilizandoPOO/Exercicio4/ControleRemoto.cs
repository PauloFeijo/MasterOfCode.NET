using System;

namespace UtilizandoPOO.Exercicio4
{
    class ControleRemoto 
    {      
        private readonly IInteracaoTV _tv;

        public ControleRemoto(IInteracaoTV tv) => _tv = tv;

        public void AumentarVolume() => _tv.AumentarVolume();
        public void DiminuirVolume() => _tv.DiminuirVolume();
        public void AumentarCanal() => _tv.AumentarCanal();
        public void DiminuirCanal() => _tv.DiminuirCanal(); 
        public void SintonizarCanal(int canal) => _tv.SintonizarCanal(canal);  
        public int LerCanal() => _tv.LerCanal();
        public int LerVolume() => _tv.LerVolume();      
    }
}