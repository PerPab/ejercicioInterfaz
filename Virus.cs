using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Virus : IInfeccion
    {
        public int TiempoVida { get; set; }
        public int NivelInfeccion { get; set; }

        public Virus (int vida, int nivel)
        {
            if (nivel >= 0 && nivel <= 5)
            {
                this.TiempoVida = vida;
                this.NivelInfeccion = nivel;

            }
            else
            {
                Console.WriteLine("Nivel de infeccion fuera de parametro (entre 0 y 5)");
            }


        }

        public void Infeccion()
        {
            Console.WriteLine($"El Ratio de infeccion de este virus es: {this.TiempoVida * this.NivelInfeccion}");
        }

        public void NivelMultiplicacion()
        {
            Console.WriteLine($"El Tiempo de multiplicacion de este virus es de 2 segundos");
        }

        public virtual void Informacion()
        {
            Console.WriteLine("Este es un virus normal");
        }

    }
}
