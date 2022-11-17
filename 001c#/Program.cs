using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Круг");
            Console.WriteLine("2 - Треугольник");
            Console.WriteLine("3 - Трапеция");
            Console.WriteLine("4 - Многоульник");
            Console.Write("Введите номер фигуры, с которой хотите работать: ");
            int n = 0;
     
            while (n != 5)
            {
                
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        Circle circle = new Circle();
                        Console.WriteLine("1 - Круг");
                        Console.WriteLine("2 - Треугольник");
                        Console.WriteLine("3 - Трапеция");
                        Console.WriteLine("4 - Многоульник");
                        Console.WriteLine("Введите номер другой фигуры или введите число 5 для выхода");
                    }
                    else if (n == 2)
                    {
                        Triangle triangle = new Triangle();
                        Console.WriteLine("1 - Круг");
                        Console.WriteLine("2 - Треугольник");
                        Console.WriteLine("3 - Трапеция");
                        Console.WriteLine("4 - Многоульник");
                        Console.WriteLine("Введите номер другой фигуры или введите число 5 для выхода");
                    }
                    else if (n == 3)
                    {
                        Trapezoid triangle = new Trapezoid();
                        Console.WriteLine("1 - Круг");
                        Console.WriteLine("2 - Треугольник");
                        Console.WriteLine("3 - Трапеция");
                        Console.WriteLine("4 - Многоульник");
                        Console.WriteLine("Введите номер другой фигуры или введите число 5 для выхода");
                    }
                    else if (n == 4)
                    {
                        Polygon polygon = new Polygon();
                        Console.WriteLine("1 - Круг");
                        Console.WriteLine("2 - Треугольник");
                        Console.WriteLine("3 - Трапеция");
                        Console.WriteLine("4 - Многоульник");
                        Console.WriteLine("Введите номер другой фигуры или введите число 5 для выхода");
                    }    
                    else
                    {
                        Console.WriteLine("Такого числа нет, попробуйте еще раз");
                    }

                }
                catch 
                {
                    Console.WriteLine("Некорректный ввод");
                }
                
                
            }




            Console.ReadLine();
        }
    }
}
