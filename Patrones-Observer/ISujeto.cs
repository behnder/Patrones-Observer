using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Observer
{
    interface ISujeto
    {
        void Adjuntar(IObservador observador);
        void Notificar();

    }
}
