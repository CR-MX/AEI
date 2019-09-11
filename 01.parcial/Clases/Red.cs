using System.Collections.Generic;
namespace parcial.Clases
{
    public class Red
    {
        private string empresa;
        private string propietario;
        private string domicilio;
        private List<Nodo> nodos = new List<Nodo>(); 
        public Red(string emp,string prop,string dom)
        {
            empresa=emp;
            propietario=prop;
            domicilio=dom;
        }
        public string Empresa 
        {
            get{return empresa;}
        }
        public string Propietario 
        {
            get{return propietario;}
        }

        public string Domicilio
        {
            get{return domicilio;}
        }

        public List<Nodo> Nodos
        {
            get{return nodos;}
        }
        
        public int totalNodos(){
            return (int) nodos.Count;
        }


        public void  AgregarNodo (Nodo nodo)
        {
            nodos.Add(nodo);
        }
    

    }
}