using System;

namespace _11.vectorsumas
{
    class Program
    {
       static void Main(string[] args)
        {
            int[] A = new int[30];
            Random rnd = new Random();
            for(int i=0; i<A.Length; i++)  {
                A[i]= rnd.Next(-15,15);
            }
            Console.WriteLine("\n El vector A"); 
            imprime(A);
            int contCeros=0;
            int contPositivos=0;
            int contNegativos=0;

              for(int i=0; i<A.Length; i++)  {
                if(A[i]==0)
                    contCeros+=1;
                else if(A[i]>0)
                    contPositivos+=1;
                else
                    contNegativos+=1;
            }
            Console.WriteLine($"\nLo numeros que son ceros son: {contCeros}");
            Console.WriteLine($"Lo numeros que son positivos son: {contPositivos}");
            Console.WriteLine($"Lo numeros que son negativos son: {contNegativos}");
        }
        static void imprime(int[] v) 
        {
                for(int i=0; i<v.Length; i++)
                    Console.Write($"{v[i]} ");
        }
        
    }
}