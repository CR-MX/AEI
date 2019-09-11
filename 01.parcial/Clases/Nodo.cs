using System.Collections.Generic;

namespace parcial.Clases
{
    public class Nodo
    {
        private string ip;
        private string[] tipos = {"servidor","equipoActivo","computadora"};
        private string tipoActual;
        private string[] Sistemas = {"linux", "IOS", "Windows"};
        private int puertos;
        private int saltos;
        private string so;
        private List<Vulnerabilidad> exploids = new List<Vulnerabilidad>();

        public Nodo(string ip,int tipo,int puertos,int saltos,int s){
            this.ip=ip;
            this.tipoActual=tipos[tipo];
            this.puertos=puertos;
            this.saltos=saltos;
            this.so=Sistemas[s];
        }
        public string Ip{
            get{return ip;}
        }
        public string TipoActual{
            get{return tipoActual;}
        }
        public int Puertos{
            get{return puertos;}
        }
        public int Saltos{
            get{return saltos;}
        }
        public string So{
            get{return so;}
        }
        public void  AgregarVul (Vulnerabilidad  vul){
            exploids.Add(vul);
        }
        public List<Vulnerabilidad> Exploids
        {
            get{return exploids;}
        }

        public int totVol(){
            return (int) exploids.Count;
        }
    }
}