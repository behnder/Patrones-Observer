using System;

namespace Patrones_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            EstacionDeClima estacionDeClima = new EstacionDeClima();

            AgenciaDeNoticias agencia1 = new AgenciaDeNoticias("Noticias ABC");
            estacionDeClima.Adjuntar(agencia1);
            
            AgenciaDeNoticias agencia2 = new AgenciaDeNoticias("Noticias Cff");
            estacionDeClima.Adjuntar(agencia2);

            estacionDeClima.Temperatura = 30f;
            estacionDeClima.Temperatura = 40f;
            estacionDeClima.Temperatura = 43.3f;
            estacionDeClima.Temperatura = 20.4f;
            Console.ReadKey();


        }
    }
}
