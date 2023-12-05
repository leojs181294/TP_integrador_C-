using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_integrador_GUI.proveedores;

namespace tp_integrador_GUI.fac_notebook
{
    internal class Fac_proveedor
    {
        public Proveedor proveedor_ = new Proveedor();//id_proveedor

        public int id_fac_proveedor;
        public DateTime fecha_compra = DateTime.Now;
        public string n_factura;
        public float precio_final;

        List<Fac_notebook> detalle_notebook = new List<Fac_notebook>();

        public double getPrecio_final()
        {
            double total = 00.00;
            foreach (Fac_notebook fac_Notebook in detalle_notebook)
            {
                total += fac_Notebook.getprecio_total();
            }
            return total;
        }
        public Proveedor Proveedor_ { get => proveedor_; set => proveedor_ = value; }
        public int Id_fac_proveedor { get => id_fac_proveedor; set => id_fac_proveedor = value; }
        public DateTime Fecha_compra { get => fecha_compra; set => fecha_compra = value;}
        public string N_factura {  get => n_factura; set => n_factura = value; }
        public float Precio_final { get => precio_final; set => precio_final = value; }
        public List<Fac_notebook> Detalle_notebook { get => detalle_notebook; set => detalle_notebook = value;}
    }
}
