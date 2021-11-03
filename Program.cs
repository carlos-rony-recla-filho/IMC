using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, imc;

            Console.Write("Altura (m)..:");
            altura = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Peso (kg)...:");
            peso = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine($"IMC: {imc:N1} kg/m²");

        }
    }
}
