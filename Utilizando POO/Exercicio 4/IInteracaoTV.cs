using System;

namespace Exercicio_4
{
    interface IInteracaoTV
    {
        void AumentarVolume();
        void DiminuirVolume();
        void AumentarCanal();
        void DiminuirCanal(); 
        void SintonizarCanal(int canal);
        int LerCanal();
        int LerVolume();
    }
}