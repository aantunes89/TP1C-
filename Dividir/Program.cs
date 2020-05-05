using System;

namespace Dividir
{
    public static class Dividir
    {
        static void Main()
        {
            Console.WriteLine("Digite o primeiro número");
            float numeroA = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            float numeroB = float.Parse(Console.ReadLine());
            var resultado = Calcular(numeroA, numeroB);
            
        }

        public static float Calcular(float a, float b) => (a / b);
    }
}
