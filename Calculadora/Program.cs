using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSelecao();
        }

        static void SelecioneOperacao(int operacao)
        {
            switch (operacao)
            {
                case 1:
                    {
                        (float numeroA, float numeroB) = GetNumeros();
                        var resultado = Soma.Soma.Calcular(numeroA, numeroB);
                        Console.WriteLine($"O resultado da doma de {numeroA} + {numeroB} é {resultado}");
                        break;
                    }

                case 2:
                    {
                        (float numeroA, float numeroB) = GetNumeros();
                        var resultado = Subtrair.Subtrair.Calcular(numeroA, numeroB);
                        Console.WriteLine($"O resultado da subtração de {numeroA} - {numeroB} é {resultado}");                        
                        break;
                    }
                case 3:
                    {
                        (float numeroA, float numeroB) = GetNumeros();
                        var resultado = Multiplicar.Multiplicar.Calcular(numeroA, numeroB);
                        Console.WriteLine($"O resultado da multiplicação de {numeroA} por {numeroB} é {resultado}");
                        break;
                    }
                case 4:
                    {
                        (float numeroA, float numeroB) = GetNumeros();
                        var resultado = Dividir.Dividir.Calcular(numeroA, numeroB);
                        Console.WriteLine($"O resultado da divisão de {numeroA} por {numeroB} é {resultado}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Operação inválida.");
                        Console.WriteLine("Por favor selecione outra opção.");
                        MenuSelecao();
                        break;
                    }

            }

            Console.WriteLine("-----------------------Fim da Operação--------------------------");
            CalcularOutraVez();
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

        static void CalcularOutraVez()
        {
            Console.WriteLine("Voce deseja realizar outro calculo?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            var opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                MenuSelecao();
            } else
            {
                Console.WriteLine("-----------FIM-------------");
            }             
        }
    }
}
