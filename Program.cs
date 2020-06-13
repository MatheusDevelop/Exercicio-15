using System;

namespace ex3
{
    class Program
    {
        private const string V = "false";
        private const string V1 = "False";

        static void Main(string[] args)
        {
           
            try{
                bool permitir;
                bool cases=bool.Parse(Console.ReadLine());
                permitir=cases;
                
            }catch{
                Console.WriteLine("ERRO");
            }

        }
    }
}
