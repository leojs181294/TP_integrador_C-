using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_integrador_GUI.proveedores
{
     public class Proveedor
    {
            public int id;
            public string nombre;
            public int num_cel;
            public string nom_dist;
            public string direccion;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Num_cel { get => num_cel; set => num_cel = value; }
        public string Nom_dist { get => nom_dist; set => nom_dist = value; }
        public string Direccion { get => direccion; set => direccion = value; }

    }
}
