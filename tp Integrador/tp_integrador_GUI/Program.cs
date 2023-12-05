using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace tp_integrador_GUI
{
    /*
    class Fac_proveedor
    {
        public int id_fac_proveedor;
        public DateTime fecha_compra = DateTime.Now;
        public string N_factura;

        public Proveedor proveedor;//id_proveedor

        List<Fac_noteboock> detalle_noteboock=new List<Fac_noteboock>();
        public double getPrecio_final()
        {
            double total = 00.00;
           foreach (Fac_noteboock fac_Noteboock in detalle_noteboock)
            {
                if (fac_Noteboock.fac_notebook.id_fac_proveedor == id_fac_proveedor)
                {
                    total += fac_Noteboock.getprecio_total();
                }
                
            }
            return total;
        }

    }
    
    class Venta
    {
        public int id_venta;
        public DateTime fecha_venta = DateTime.Now;
        public string garantia;
        public string nomyapell_comprador;
        public int dni_comprador;

        List<Noteboock_venta> detalle_venta = new List<Noteboock_venta>();
        public double getPrecio_final_venta()
        {
            double total = 00.00;
            foreach (Noteboock_venta not_venta in detalle_venta)
            {
                total += not_venta.getPrecio_total();
            }
            return total;
        }
    }
    class Noteboock_venta
    {
        public int id_noteboock_venta;
        public Venta venta;//id_venta
        public Noteboock noteboock;//id_notebook
        public int cantidad;
      /*  public double getPrecio_total()
        {
            double precio_total = 0.00;
            precio_total= cantidad* noteboock.precio_unitario;
            return precio_total;
    }
        }*/

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}