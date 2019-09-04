using System;

namespace _12.vectorinverso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[15];
            Random rnd = new Random();
            for(int i=0; i<A.Length; i++)  {
                A[i]= rnd.Next(0,15);
            }
            Console.WriteLine("\nEl vector A"); 
            imprime(A);
            // hacer inverso el vector
            int[] B = new int[15];
            int cont=0;
            for (int i = A.Length-1; i >= 0; i--)
            {
                B[cont]=A[i];
                cont++;
            }
            Console.WriteLine();
            imprime(B); 
        
        }
        static void imprime(int[] v) 
        {
                for(int i=0; i<v.Length; i++)
                    Console.Write($"{v[i]} ");
        }
        
    }
}