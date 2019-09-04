using System;

namespace _10.vectorcubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[20];
            Random rnd = new Random();
            for(int i=0; i<A.Length; i++)  {
                A[i]= rnd.Next(1,30);
            }
            Console.WriteLine("\n El vector A"); 
            imprime(A);    
            int[] B=elevaralcubo(A);
            Console.WriteLine();
            imprime(B);
        }
        static void imprime(int[] v) 
        {
                for(int i=0; i<v.Length; i++)
                    Console.Write($"{v[i]} ");
        }
        static int[] elevaralcubo(int[] v){
            int[] p=v;
            for(int i=0; i<p.Length; i++)
                p[i]=v[i]*v[i];
            return p;
        }
    }
}
