using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3dSemana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1. Agregar Rectángulo");
                Console.WriteLine("2. Agregar Cuadrado");
                Console.WriteLine("3. Agregar Círculo");
                Console.WriteLine("4. Agregar Triángulo");
                Console.WriteLine("5. Mostrar Figuras");
                Console.WriteLine("6. Salir");
                Console.Write("Opción: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Base: ");
                        float br = float.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        float ar = float.Parse(Console.ReadLine());
                        figures.Add(new Rectangle(br, ar));
                        break;

                    case 2:
                        Console.Write("Lado: ");
                        float lado = float.Parse(Console.ReadLine());
                        figures.Add(new Square(lado));
                        break;

                    case 3:
                        Console.Write("Radio: ");
                        float radio = float.Parse(Console.ReadLine());
                        figures.Add(new Circle(radio));
                        break;

                    case 4:
                        Console.Write("Base: ");
                        float bt = float.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        float at = float.Parse(Console.ReadLine());
                        figures.Add(new Triangle(bt, at));
                        break;

                    case 5:
                        Console.WriteLine("\nLista de figuras:");
                        foreach (var f in figures)
                        {
                            Console.WriteLine($"{f.Name} - Área: {f.CalculateArea()}");
                        }
                        break;

                    case 6:
                        exit = true;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nValor no reconocido.");
                        break;
                }
            }
        }
    }
}