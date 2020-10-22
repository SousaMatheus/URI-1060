using System;

namespace URI_1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1 = double.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());
            double valor3 = double.Parse(Console.ReadLine());
            double valor4 = double.Parse(Console.ReadLine());
            double valor5 = double.Parse(Console.ReadLine());
            double valor6 = double.Parse(Console.ReadLine());

            int ePositivo = 0;

            if (valor1 >0.0){
                ePositivo += 1;
            }
            if (valor2 >0.0){
                ePositivo += 1;
            }
            if (valor3 >0.0){
                ePositivo += 1;
            }
            if (valor4 >0.0){
                ePositivo +=1;
            }
            if (valor5 >0.0){
                ePositivo +=1;
            }
            if (valor6 >0.0){
                ePositivo +=1;
            }

            Console.WriteLine(ePositivo + " valores positivos");
        }
    }
}
