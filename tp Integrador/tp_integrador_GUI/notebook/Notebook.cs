using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_integrador_GUI.notebook
{
    //Para poder pasar un objeto entre un form y otro la clase tiene que ser publica
    public class Notebook
    {
        private int id_notebook;
        private string marca;
        private string modelo;
        private string sist_operativo;
        private string procesador;
        private int nucleos;
        private float velocidad_procesadora;
        private int memoria_ram;
        private int hdd;
        private int ssd;
        private int memoria_video;
        private int puertos_usb;
        private int red_rj45;//ver tema para ponerlo en bool
        private long precio_unitario;
        private int stock;
        private long stock_valorizado;

        //Metodos
        public int Id_notebook { get => id_notebook; set => id_notebook = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Sis_operativo { get => sist_operativo; set => sist_operativo = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public int Nucleos { get => nucleos; set => nucleos = value; }
        public float Velocidad_procesadora { get => velocidad_procesadora; set => velocidad_procesadora = value; }
        public int Memoria_ram { get => memoria_ram; set => memoria_ram = value; }
        public int Hdd { get => hdd; set => hdd = value; }
        public int Ssd { get => ssd; set => ssd = value; }
        public int Memoria_video { get => memoria_video; set => memoria_video = value; }
        public int Puertos_usb { get => puertos_usb; set => puertos_usb = value; }
        public int Red_rj45 { get => red_rj45; set => red_rj45 = value; }
        public long Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public int Stock { get => stock; set => stock = value; }
        public long Stock_valorizado { get => stock_valorizado; set => stock_valorizado = value; }
    }
}
