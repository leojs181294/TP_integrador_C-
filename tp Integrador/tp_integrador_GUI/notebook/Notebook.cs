using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_integrador_GUI.notebook
{
    internal class Notebook
    {
        private int id_notebook;
        private string marca;
        private string modelo;
        private string sist_operativo1;
        private string procesador;
        private int nucleos;
        private float velocidad_procesadora11;
        private int memoria_ram1;
        private int hdd;
        private int ssd;
        private int memoria_video1;
        private int puertos_usb1;
        private int red_rj451;//ver tema para ponerlo en bool
        private long precio_unitario1;
        private int stock1;
        private long stock_valorizado1;

        //Metodos
        public int GetId_notebook()
        {
            return id_notebook;
        }
        public void SetId_notebook(int value)
        {
            id_notebook = value;
        }
        public string GetMarca()
        {
            return marca;
        }
        public void SetMarca(string value)
        {
            marca = value;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public void SetModelo(string value)
        {
            modelo = value;
        }
        public string Getsist_operativo()
        {
            return sist_operativo1;
        }
        public void Setsist_operativo(string value)
        {
            sist_operativo1 = value;
        }
        public string GetProcesador()
        {
            return procesador;
        }
        public void SetProcesador(string value)
        {
            procesador = value;
        }
        public int GetNucleos()
        {
            return nucleos;
        }
        public void SetNucleos(int value)
        {
            nucleos = value;
        }
        public float Getvelocidad_procesadora()
        {
            return velocidad_procesadora11;
        }
        public void Setvelocidad_procesadora(float value)
        {
            velocidad_procesadora11 = value;
        }
        public int Getmemoria_ram()
        {
            return memoria_ram1;
        }
        public void Setmemoria_ram(int value)
        {
            memoria_ram1 = value;
        }
        public int Gethdd()
        {
            return hdd;
        }
        public void Sethdd(int value)
        {
            hdd = value;
        }
        public int Getssd()
        {
            return ssd;
        }
        public void Setssd(int value)
        {
            ssd = value;
        }
        public int Getmemoria_video()
        {
            return memoria_video1;
        }
        public void Setmemoria_video(int value)
        {
            memoria_video1 = value;
        }
        public int Getpuertos_usb()
        {
            return puertos_usb1;
        }
        public void Setpuertos_usb(int value)
        {
            puertos_usb1 = value;
        }
        public int Getred_rj45()
        {
            return red_rj451;
        }
        public void Setred_rj45(int value)
        {
            red_rj451 = value;
        }
        public long Getprecio_unitario()
        {
            return precio_unitario1;
        }
        public void Setprecio_unitario(long value)
        {
            precio_unitario1 = value;
        }
        public int Getstock()
        {
            return stock1;
        }
        public void Setstock(int value)
        {
            stock1 = value;
        }
        public long Getstock_valorizado()
        {
            return stock_valorizado1;
        }
        public void Setstock_valorizado(long value)
        {
            stock_valorizado1 = value;
        }


    }
}
