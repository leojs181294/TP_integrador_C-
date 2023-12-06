using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_integrador_GUI.notebook;

namespace tp_integrador_GUI.fac_notebook
{
    internal class Fac_notebook
    {
        public int id_fact_notebook;
        public int cantidad;
        public float precio_costo;
        public int id_notebook;
        public float precio_total;

        //public Notebook notebook;//id_notebook
        //notebook.setStock=notebook.getStock+cantidad;

        public int Id_fact_notebook { get => id_fact_notebook;set => id_fact_notebook = value; }
        public int Cantidad {  get => cantidad; set => cantidad = value; }
        public float Precio_costo { get => precio_costo; set => precio_costo = value; }
        public int Id_notebook { get => id_notebook; set => id_notebook = value; }
        public float Precio_total { get => precio_total; set => precio_total = value; }

    }
}
