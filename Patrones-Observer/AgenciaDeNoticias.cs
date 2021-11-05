using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Observer
{
    class AgenciaDeNoticias : IObservador
    {
        public string NombreAgencia { get; set; }

        public AgenciaDeNoticias(string nombreAgencia)
        {
            NombreAgencia = nombreAgencia;
        }

        public void Actualizar(ISujeto sujeto)
        {
            if (sujeto is EstacionDeClima estacionDeClima)
            {
                Console.WriteLine(
                    "{0} Reportando la temperatura {1} grados C°", 
                    NombreAgencia, estacionDeClima.Temperatura);
                Console.WriteLine("=============================");
                
            }
        }
    }
}
