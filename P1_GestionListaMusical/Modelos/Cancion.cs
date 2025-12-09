using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_GestionListaMusical.Modelos
{
    public class Cancion
    {
        public int CancionID { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string RutaArchivo { get; set; }
        public int DuracionSegundos { get; set; }
    }
}
