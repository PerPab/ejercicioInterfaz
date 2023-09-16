﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class VirusSuper : Virus, IInfeccion
    {
        public VirusSuper(int vida, int nivel) : base(vida, nivel)
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

        public override void Informacion()
        {
            Console.WriteLine("Este virus Infecta las vias aereas");
        }


    }
}
