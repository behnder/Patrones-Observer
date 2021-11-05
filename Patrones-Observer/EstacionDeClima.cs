using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Observer
{
    class EstacionDeClima : ISujeto
    {

        private List<IObservador> observadores;
        public float Temperatura
        {
            get
            {
                return temperatura;
            }
            set
            {
                temperatura = value;
                Notificar();
            
            }
        }
        private float temperatura;

        public EstacionDeClima()
        {
            this.observadores = new List<IObservador>();
        }

        public void Adjuntar(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void Notificar()
        {
            observadores.ForEach(o =>
            {
                o.Actualizar(this);
            });

        }
    }
}
