using System;

namespace _13.vectoresmultiplica
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] A = new int[10];
           int[] B = new int[10];
            Random rnd = new Random();
            for(int i=0; i<A.Length; i++)  {
                A[i]= rnd.Next(0,10);
                B[i]= rnd.Next(0,10);
            }
            Console.WriteLine("\nEl vector A"); 
            imprime(A);
            Console.WriteLine("\nEl vector B");
            imprime(B);
            //multiplicar el primero de a por el ultimo de b 
            int[] C = new int[10];
            int cont=0;

            for (int i = B.Length-1; i >= 0; i--)
            {
                C[cont]=A[cont]*B[i];
                cont++; 
            }
            Console.WriteLine("\nEl vector C");
            imprime(C);

        
        }
        static void imprime(int[] v) 
        {
                for(int i=0; i<v.Length; i++)
                    Console.Write($"{v[i]} ");
        }
        
    }
}