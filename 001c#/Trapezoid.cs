using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


// Параллелограмм и прямоугольник — частные случаи трапеции



namespace ConsoleApp1
{
    internal class Trapezoid
    {
        public Trapezoid()
        {
            Console.WriteLine("======================= Вы работаете с трапецией =======================");
            Console.WriteLine("Расстановка точек по часовой");
            try
            {
                double a, b, c, d;
                Point[] point = new Point[4];

                for (int i = 0; i < 4; i++)
                {
                    point[i] = new Point();
                    Console.Write($"Введите {i + 1} вершину трапеции x,y: ");
                    string str_split = Console.ReadLine();
                    string[] s_arr = str_split.Split();
                    point[i].X = int.Parse(s_arr[0]);
                    point[i].Y = int.Parse(s_arr[1]);
                }
                if (IsTrapezoid(point[1], point[2], point[0], point[3]) && side_check(point[0], point[1], point[2], point[3]))
                {
                    c = Math.Sqrt((point[1].X - point[0].X) * (point[1].X - point[0].X) + (point[1].Y - point[0].Y) * (point[1].Y - point[0].Y));
                    b = Math.Sqrt((point[2].X - point[1].X) * (point[2].X - point[1].X) + (point[2].Y - point[1].Y) * (point[2].Y - point[1].Y));
                    d = Math.Sqrt((point[3].X - point[2].X) * (point[3].X - point[2].X) + (point[3].Y - point[2].Y) * (point[3].Y - point[2].Y));
                    a = Math.Sqrt((point[3].X - point[0].X) * (point[3].X - point[0].X) + (point[3].Y - point[0].Y) * (point[3].Y - point[0].Y));
                    Console.WriteLine("Левая боковая сторона: " + c);
                    Console.WriteLine("Верхнее основание: " + b);
                    Console.WriteLine("Правая боковая сторона: " + d);
                    Console.WriteLine("Нижнее основание: " + a);
                    perimeter(a, b, c, d);
                    square(c, b, d, a);
                    for (int i = 0; i < 4; i++)
                    {
                        move_to(point[i]);
                        Console.WriteLine($"После сдвига на 10 x_{i + 1} равен: " + point[i].X);
                        Console.WriteLine($"После сдвига на 10 y_{i + 1} равен: " + point[i].Y);
                    }
                }
                else
                {
                    Console.WriteLine("Не выполнено условие существования");
                }

            }

            catch
            {
                Console.WriteLine("Что-то пошло не так...");
            }


        }

        public bool side_check(Point p_1, Point p_2, Point p_3, Point p_4)
        {
            bool flag = false;
            bool temp_1 = (p_3.X > p_1.X && p_4.X > p_1.X && p_3.X > p_2.X && p_4.X > p_2.X) || (p_3.X < p_1.X && p_4.X < p_1.X && p_3.X < p_2.X && p_4.X < p_2.X);
            bool temp_2 = (p_3.Y > p_1.Y && p_4.Y > p_1.Y && p_3.Y > p_2.X && p_4.Y > p_2.Y) || (p_3.Y < p_1.Y && p_4.Y < p_1.Y && p_3.Y < p_2.Y && p_4.Y < p_2.Y);
            if (temp_1 || temp_2 )
            {
                flag = true;
            }

            return flag;
        }

        bool IsTrapezoid(Point TopLeft, Point TopRight, Point BottomLeft, Point BottomRight)
        {
            return koef(TopLeft, TopRight) == koef(BottomLeft, BottomRight) || koef(BottomLeft, TopLeft) == koef(BottomRight, TopRight);
        }

        float koef(Point p1, Point p2)
        {
            if (p1.X == p2.X)
                return float.PositiveInfinity;
            return (float)(p1.Y - p2.Y) / (float)(p1.X - p2.X);
        }

        public void square(double c, double b, double d, double a)
        {
            double temp = ((a - b) * (a - b) + c * c - d * d) / (2 * (a - b));
            double square = ((a + b) / 2) * Math.Sqrt(c * c - temp * temp);
            Console.WriteLine("Площадь трапеции равна: " + square);
        }

        public double perimeter(double a, double b, double c, double d)
        {
            double perimeter = a + b + c + d;
            Console.WriteLine("Периметр трапеции равен: " + perimeter);
            return perimeter;
        }
        public void move_to(Point point)
        {
            point.X += 10;
            point.Y += 10;
        }
    }
}
