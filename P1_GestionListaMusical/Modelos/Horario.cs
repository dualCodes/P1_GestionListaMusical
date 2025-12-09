using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_GestionListaMusical.Modelos
{
    public class Horario
    {
        public int EventoID { get; set; }
        public int ListaID { get; set; }
        public string Nombre { get; set; }
        public bool EstaActivo { get; set; }
        public string ReglaRRule { get; set; }
        public DateTime InicioRegla { get; set; }
        public string Excepciones { get; set; }
    }
}
