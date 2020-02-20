using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps
{
    class Depart
    {


        /////////////////////////////////////////
        //Atributos.
        /// <summary>
        ////////////////////////////////////////

        private String periodo;
        private String mes;
        private String codigo;
        private String nombreDeparamento;
        private String latitud;
        private String longitud;
        private String codigoMunicipio;
        private String muncipio;
        private String nombreComercial;
        private String bandera;
        private String dirreccion;
        private String producto;
        private int precio;
        private String estado;


        //Constructor.
        public Depart(string periodo, string mes, string codigo, string nombreDeparamento, string latitud, string longitud, string codigoMunicipio, string muncipio, string nombreComercial, string bandera, string dirreccion, string producto, int precio, string estado)
        {
            this.periodo = periodo;
            this.mes = mes;
            this.codigo = codigo;
            this.nombreDeparamento = nombreDeparamento;
            this.latitud = latitud;
            this.longitud = longitud;
            this.codigoMunicipio = codigoMunicipio;
            this.muncipio = muncipio;
            this.nombreComercial = nombreComercial;
            this.bandera = bandera;
            this.dirreccion = dirreccion;
            this.producto = producto;
            this.precio = precio;
            this.estado = estado;
        }

        public string Periodo { get => periodo; set => periodo = value; }
        public string Mes { get => mes; set => mes = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string NombreDeparamento { get => nombreDeparamento; set => nombreDeparamento = value; }
        public string Latitud { get => latitud; set => latitud = value; }
        public string Longitud { get => longitud; set => longitud = value; }
        public string CodigoMunicipio { get => codigoMunicipio; set => codigoMunicipio = value; }
        public string Muncipio { get => muncipio; set => muncipio = value; }
        public string NombreComercial { get => nombreComercial; set => nombreComercial = value; }
        public string Bandera { get => bandera; set => bandera = value; }
        public string Dirreccion { get => dirreccion; set => dirreccion = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
