using System;

namespace Soma
{
    public class Soma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            float numeroA = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            float numeroB = float.Parse(Console.ReadLine());
            Calcular(numeroA, numeroB);
        }

        public static float Calcular(float a, float b)
        {
            return a + b;
        }
    }
}
