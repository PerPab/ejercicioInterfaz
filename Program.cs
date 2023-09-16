using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4.Un virus o una bacteria pueden infectar seres humanos de formas diferentes.Con los
            //siguientes requerimientos proponga un modelo de solución(inicie desde una Interfaz):

            //a.Del virus o bacteria se conocen el tiempo de vida en días y el nivel de infección(de
            //0 a 5).Ambas características siempre accesibles.
            //b.Ambas infectan con el cálculo: tiempo de vida* nivel de infección. (Imprime por
            //pantalla el nivel de infección)

            //2

            //c.Ambas informan el nivel multiplicación donde la bacteria se reproduce cada 1
            //segundo y el virus cada 2 segundo. (Imprime por pantalla el nivel de
            //multiplicación).

            //d.El virus tiene dos tipos: VirusSuper que puede infectar las vías aéreas.El
            //VirusUltra infecta la sangre y también puede descomponer células. (Imprimen por
            //pantalla a qué infectan).

            //e.La bacteria solo hay de un tipo y puede afectar las funciones motoras.Aunque la
            //bacteria si se encuentra con un VirusSuper puede reducir su nivel de infección
            //llevándolo a 0, pero debe analizar de qué tipo es, ya que no afecta a un VirusUltra.


            //----------------------------------------------------------------------------------------------------//

            Virus virusNormal = new Virus( 10, 1);

            Bacteria miBacteria = new Bacteria(20,5);

            VirusSuper virusSuper = new VirusSuper(30,5);

            VirusUltra virusUltra = new VirusUltra(25,4);

            virusNormal.Infeccion();
            virusNormal.NivelMultiplicacion();
            Console.WriteLine("");

            virusSuper.Infeccion();
            virusSuper.NivelMultiplicacion();
            virusSuper.Informacion();
            Console.WriteLine("");

            virusUltra.Infeccion();
            virusUltra.NivelMultiplicacion();
            virusUltra.Informacion();
            Console.WriteLine("");

            miBacteria.Infeccion();
            miBacteria.NivelMultiplicacion();
            miBacteria.Informacion();
            miBacteria.AnalizarVirus(virusSuper);
            Console.WriteLine("");

            Console.WriteLine("---> virusSuper despues de la reduccion <----");
            virusSuper.Infeccion();
            Console.WriteLine("");
            miBacteria.AnalizarVirus(virusUltra);
            miBacteria.AnalizarVirus(virusNormal);





        }
    }
}
