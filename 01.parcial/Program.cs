using System;
using parcial.Clases;

namespace parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Red red1 = new Red("Red Patito, S.A. de C.","Mr Pato Macdonal","Av. Princeton 123, Orlando Flori");
            Nodo nodo1=new Nodo("192.168.0.10",0,5,10,0);
            Nodo nodo2=new Nodo("192.168.0.12",1,2,12,1);
            Nodo nodo3=new Nodo("192.168.0.20",2,8,5,2);
            Nodo nodo4=new Nodo("192.168.0.15",0,10,22,0);
            
            Vulnerabilidad vul1=
            new Vulnerabilidad("CVE-2015-1635","microsoft","HTTP.sys permite a atacantes remotos ejecutar código arbitrar", 1,"04/14/2015");
            Vulnerabilidad vul2=
            new Vulnerabilidad("CVE-2017-0004","microsoft","El  servicio  LSASS  permite causar una denegación de servici", 0,"01/10/2010");
            nodo1.AgregarVul(vul1);
            nodo1.AgregarVul(vul2);
            Vulnerabilidad vul3=
            new Vulnerabilidad("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS", 1,"02/21/2010");
            nodo2.AgregarVul(vul3);
            Vulnerabilidad vul4=
            new Vulnerabilidad("CVE-2009-2504","microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1", 0,"11/13/2009");
            Vulnerabilidad vul5=
            new Vulnerabilidad("CVE-2016-7271","microsoft","Elevación  de  privilegios Kernel Segura en Windows 10 Gol", 0,"12/20/2016");
            Vulnerabilidad vul6=
            new Vulnerabilidad("CVE-2017-2996","adove","Adobe  Flash  Player  24.0.0.194 corrupción de memoria explotable", 1,"15/02/2017");
            nodo3.AgregarVul(vul4);
            nodo3.AgregarVul(vul5);
            nodo3.AgregarVul(vul6);

            red1.AgregarNodo(nodo1);
            red1.AgregarNodo(nodo2);
            red1.AgregarNodo(nodo3);
            red1.AgregarNodo(nodo4);            
            //imprimir datos principales 
            Console.WriteLine("\n >>>Datos generales de la red<<<\n");
            Console.WriteLine($"Empresa: {red1.Empresa}");
            Console.WriteLine($"Propietario: {red1.Propietario}");
            Console.WriteLine($"Domicilio: {red1.Domicilio}");
            int suma=0;
            foreach (Nodo n in red1.Nodos)
            {
                suma += (int) n.totVol();
            }
            Console.WriteLine($"Total Nodos red: {red1.totalNodos()}");
            Console.WriteLine($"Total Vulnerabilidades: {suma}\n");
            
            //imprimir datos de nodos  gnerales
            int may=0;
            int men=0;
            foreach (Nodo n in red1.Nodos)
            {
                Console.WriteLine($"IP: {n.Ip}, Tipo: {n.TipoActual}, Puertos: {n.Puertos}, Saltos: {n.Saltos}, So: {n.So}, Totvul: {n.totVol()}");
                may=mayor(may,n.Saltos);
                men=menor(men,n.Saltos);

            }
            Console.WriteLine($"\nMayor numero de saltos: {may}");
            Console.WriteLine($"Mayor numero de saltos: {men}\n");
            
            Console.WriteLine(" >> Datos generales  de los nodos:\n");
            foreach (Nodo n in red1.Nodos)
            {
                Console.WriteLine($"\nIP: {n.Ip}, Tipo: {n.TipoActual}\n");
                if (n.Exploids.Count !=0)
                {
                    Console.WriteLine("Vulnerabilidades: \n");
                    foreach (Vulnerabilidad v in n.Exploids)
                     {                    
                        Console.WriteLine($"Clave: {v.Clave}, Vendedor: {v.Vendedor}, Descripcion: {v.Descripcion}, Tipo: {v.TipoActual}, Fecha: {v.Fecha}");
                    
                    } 
                }else{
                    Console.WriteLine("No tiene vulnerabilidades ..");
                }
                               
            }
        }
        public static int mayor(int num1,int num2){
            if (num1>num2)
            {
                return num1;
            }
            return num2;
            
        }

        public static int menor(int num1,int num2){
            if (num1<num2 && num1!=0 && num2!=0)
            {
                return num1;
            }
            return num2;
        }
    }
}
