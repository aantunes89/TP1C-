using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSelecao();
            Console.WriteLine("-----------------------Fim da Operação--------------------------");
        }

        static void SelecioneOperacao(int operacao)
        {
            switch (operacao)
            {
                case 1:
                    {
                        (float numeroA, float numeroB) = GetNumeros();
                        // var resultado = Soma.Soma.Calcular(numeroA, numeroB);

                        var resultado = Sum.Calculate(numeroA, numeroB);
                        Console.WriteLine($"O resultado da doma de {numeroA} + {numeroB} é {resultado}");
                        break;
                    }

                case 2:
                    {
                        (float numeroA, float numeroB) = GetNumeros();
                        // var resultado = Subtrair.Subtrair.Calcular(numeroA, numeroB);
                        
                        var resultado = Subtract.Calculate(numeroA, numeroB);
                        Console.WriteLine($"O resultado da subtração de {numeroA} - {numeroB} é {resultado}");                        
                        break;
                    }
                case 3:
                    {
                        (float numeroA, float numeroB) = GetNumeros();
                        // var resultado = Multiplicar.Multiplicar.Calcular(numeroA, numeroB);
                        var resultado = Multiply.Calculate(numeroA, numeroB);
                        Console.WriteLine($"O resultado da multiplicação de {numeroA} por {numeroB} é {resultado}");
                        break;
                    }
                case 4:
                    {
                        (float numeroA, float numeroB) = GetNumeros();
                        // var resultado = Dividir.Dividir.Calcular(numeroA, numeroB);
                        var resultado = Divide.Calculate(numeroA, numeroB);
                        Console.WriteLine($"O resultado da divisão de {numeroA} por {numeroB} é {resultado}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Operação inválida!!!!!!!!!!!!!!.");
                        Console.WriteLine("**************Por favor selecione outra opção.*************");
                        MenuSelecao();
                        break;
                    }
                    
            }
            
        }

        static void MenuSelecao()
        {
            Console.WriteLine("Selecione a operação, você deseja realizar?");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Número:");
            int operacao = int.Parse(Console.ReadLine());


            SelecioneOperacao(operacao);
        }

        static (float, float) GetNumeros()
        {
            Console.WriteLine("Digite o primeiro número");
            float numeroA = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float numeroB = float.Parse(Console.ReadLine());

            return (numeroA, numeroB);
        }
    }
}
