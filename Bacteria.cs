using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
   
    public class Bacteria : IInfeccion
    {
        public int TiempoVida { get; set; }
        public int NivelInfeccion { get;set; }

        public Bacteria( int vida, int nivel) 
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
            Console.WriteLine($"El Ratio de infeccion de esta bacteria es: {this.TiempoVida * this.NivelInfeccion}"); 
        }

        public void NivelMultiplicacion()
        {
            Console.WriteLine($"El Tiempo de multiplicacion de esta bacteria es de 1 segundo");
        }

        public void Informacion()
        {
            Console.WriteLine("Este es una bacteria normal");
        }

        public void AnalizarVirus(Virus virus)
        {
            if (virus is VirusSuper)
            {
                virus.NivelInfeccion = 0;
                Console.WriteLine("Nivel de infeccion del virus super reducido a cero");
            }
            else if (virus is VirusUltra)
            {
                Console.WriteLine("Este virus es un virus ultra");
            }
            else 
            {
                Console.WriteLine("Es un virus normal");
            }

            

        }
    }
}
