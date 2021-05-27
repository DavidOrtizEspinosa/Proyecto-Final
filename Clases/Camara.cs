using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Camara
    {
        public int id { get; set; }
        public int temperatura { get; set; }
        public int capacidad { get; set; }
        public List<Pale> pales { get; set; }
        public string capacidadTotal { get; set; }
        public string tipo { get; set; }

        public Camara(int id, int temperatura, int capacidad,List<Pale> pales)
        {
            this.id = id;
            this.temperatura = temperatura;
            this.capacidad = capacidad;
            this.pales = pales;
            capacidadTotal = pales.Count().ToString() + " / " + capacidad;
            if(temperatura < 0)
            {
                tipo = "Bajo cero";
            }else if (temperatura>= 0 && temperatura < 10)
            {
                tipo = "Fria";
            }
            else
            {
                tipo = "Templada";
            }
        }

       
    }
}
