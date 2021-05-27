using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public int administrador { get; set; }

        public Usuario(int id, String usuario, String contraseña, int admin)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.administrador = admin;
        }
    }
}
