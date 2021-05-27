using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Pale
    {
        public int id { get; set; }
        public int idCamara { get; set; }
        public string contenido { get; set; }
        public string fechaLimite { get; set; }

        public Pale(int id, int idCamara, String contenido, String fechaLimite)
        {
            this.id = id;
            this.idCamara = idCamara;
            this.contenido = contenido;
            this.fechaLimite = fechaLimite;
        }
        public Pale() { }
        
    }
}
