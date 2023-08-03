using MiniProjeto_AppDeLeituraDeArea;
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----- CALCULADORA DE AREAS -----");
        Console.WriteLine();
        Console.WriteLine("Você quer calcular a área de qual das formas geométricas abaixo?");
        Console.WriteLine();
        Console.Write("Círculo (1) - Triangulo (2) - Quadrado / Retângulo (3) \n\nEscolha o número correspondente: ");
        int forma = int.Parse(Console.ReadLine());

        if (forma == 1 ) {
            Circulo a;
            a = new Circulo();

            Console.WriteLine();
            Console.Write("Digite o raio do círculo: ");
            a.raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = a.AreaCirculo();

            Console.WriteLine("A área do círculo é: " + area.ToString("f4", CultureInfo.InvariantCulture));
        }
        else if (forma == 2 ) 
        {
            Triangulo x;
            
            x = new Triangulo();

            Console.WriteLine();
            Console.Write("Digite o primeiro lado do triangulo: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo lado do triangulo: ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o terceiro lado do triangulo: ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.AreaTriangulo();

            Console.WriteLine();
            Console.WriteLine("A área do triângulo é: " + areaX.ToString("f4", CultureInfo.InvariantCulture));
        }     
        else 
        {
            Quadrilatero y;

            y = new Quadrilatero();

            Console.WriteLine();
            Console.Write("Digite o primeiro lado do quadrado / retângulo : ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo lado do quadrado / retângulo: ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaY = y.AreaQuadrilatero();

            Console.WriteLine();
            Console.WriteLine("A área do triângulo é: " + areaY.ToString("f4", CultureInfo.InvariantCulture));
            }

    }
}