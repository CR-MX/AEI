using System;
using  System.Globalization;
namespace parcial.Clases
{
    public class Vulnerabilidad
    {
        private string clave;
        private string vendedor;
        private string descripcion;
        private string[] tipo = {"local","remota"};
        private string tipoActual;
        private string fecha;

        public Vulnerabilidad(string calve,string vendedor, string descripcion,int tipo,string fecha){
            this.clave=calve;
            this.vendedor=vendedor;
            this.descripcion=vendedor;
            tipoActual=this.tipo[tipo];
            this.fecha=fecha;
        }
        public string Fecha{
            get{return fecha;}
        }
        public string Clave{
            get{return clave;}
        }
        public string Vendedor{
            get{return vendedor;}
        }
        public string Descripcion{
            get{return descripcion;}
        }
        public string TipoActual{
            get{return tipoActual;}
        }
    }
}