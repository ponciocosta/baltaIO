using System;
using System.Net.NetworkInformation;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum();
            //Sub();
            //Div();
            //Mult();
            Menu();
        }

        //Menu
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("## Calculadora ##\n");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Divisão");
            Console.WriteLine("4-Multiplicação");
            Console.WriteLine("5-Sair");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção:");

            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1: Sum(); break;
                case 2: Sub(); break;
                case 3: Div(); break;
                case 4: Mult(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu();break;
            }
        }

        //Function: Sum
        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            //Console.WriteLine("O resultado da soma é: " + (v1 + v2));
            float soma = v1 + v2;
            Console.WriteLine("O resultado da soma e: " + soma);
            //Console.WriteLine($"O resultado da soma é {v1 + v2}");
            //Console.WriteLine($"O resultado da soma é {soma}");
            Console.ReadKey();
            Menu();
        }

        //Function: Sub
        static void Sub()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            var resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        
        //Function: Div
        static void Div()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segunda valor:");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        //Fuction: Mult
        static void Mult()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}