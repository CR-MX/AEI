using System;

namespace _07.tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if(args.Length ==1) 
            {
                for (int i = 1; i <= int.Parse(args[0]) ; i++)
                {
                    for (int z = 1; z < 11; z++)
                    {
                        Console.WriteLine(i+"X"+z+"="+i*z);
                    }
                    Console.WriteLine("");
                }

            }else if(args.Length ==3)
            {
                for (int i = 1; i <= int.Parse(args[0]) ; i++)
                {
                    for (int z = int.Parse(args[1]); z < int.Parse(args[2]); z++)
                    {
                        Console.WriteLine(i+"X"+z+"="+i*z);
                    }
                    Console.WriteLine("");
                }
            }
            else{
                Console.Clear();
                Console.WriteLine("Tablas de multiplicar");
                Console.WriteLine("Si pones un argumento te se realiza del 1 hasta esa tabla");
                Console.WriteLine("Si pones 3 argumentos, el primero hasta cual tabla y los siguientes son el rango");

                
            }
        }
    }
}
// 