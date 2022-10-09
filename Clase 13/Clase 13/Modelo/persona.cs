using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13.Modelo
{
    internal class persona
    {
        // Propiedades
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public int Edad { get; set; }
        public bool EstaCasado { get; set; }

        public string ObtenerSaludo()
        {
            return $"Hola! Soy {NombreCompleto}";
        }

        public string ObtenerSaludo(string nombrePersonaAQuienSaludar)
        {
            return $"Hola {nombrePersonaAQuienSaludar}, soy {NombreCompleto}";
        }
    }
}
