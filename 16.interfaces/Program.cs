using System;
using interfaces.Clases;
using System.Collections.Generic;

namespace _16.interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Caja> costal=LlenarCostal();

            Caja miCaja=new Caja("Roja",true,"calzones",10,20);
            
            costal.Add(miCaja);
            foreach (Caja c in costal)
            {
            Console.WriteLine("Ejemplo de interfaces\n");
            Console.WriteLine($"Color: {c.Color},\nEstatus: {(c.EstaAbierta?"Abierta":"Cerrada")},\nContenido: {(c.EstaAbierta?c.Contenido:"Nel")},\n"+
            $"Domenciones: {c.Medidas()}");
                
            }


        }
        static List<Caja> LlenarCostal()
        {

            List<Caja> todo= new List<Caja>();
            todo.Add(new Caja("Roja",false,"Manzanas",10,60));
            todo.Add(new Caja("Verde",false,"Pepinos",20,50));
            todo.Add(new Caja("Azul",false,"Nubes",30,40));
            todo.Add(new Caja("Negro",false,"Carbon",40,30));
            todo.Add(new Caja("Blanca",false,"ligas",50,20));
            todo.Add(new Caja("Rosa",false,"Flores",60,10));
            return todo;

        }

    }
}
