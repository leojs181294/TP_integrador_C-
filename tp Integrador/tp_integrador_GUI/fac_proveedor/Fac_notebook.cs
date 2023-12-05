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
        public int id_fact_noteboock;
        public int cantidad;
        public float precio_costo;
        public int id_notebook;
        //public Notebook notebook;//id_notebook

        //notebook.setStock=notebook.getStock+cantidad;
        public double getprecio_total()
        {
            return cantidad * precio_costo;
        }
    }
}
