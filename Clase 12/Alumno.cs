﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12
{
    internal class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dni { get; set; }    
        

        public void GetInfo()
        {
            Console.WriteLine($"Legajo: {Legajo} Apellido: {Apellido}");
        }

    }
}
