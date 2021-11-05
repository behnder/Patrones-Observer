using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Observer
{
    interface IObservador
    {
        void Actualizar(ISujeto sujeto);
    }
}
