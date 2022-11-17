using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangle
    {
        public Triangle()
        {
            Console.WriteLine("======================= Вы работаете с треугольником =======================");
            try
            {

                Point point_1 = new Point();
                Point point_2 = new Point();
                Point point_3 = new Point();

                double x, y, z;
                double semi_perimeter;

                Console.Write("Введите 1 вершину треугольника x,y: ");
                string str_split = Console.ReadLine();
                string[] s_arr = str_split.Split();
                point_1.X = int.Parse(s_arr[0]);
                point_1.Y = int.Parse(s_arr[1]);

                Console.Write("Введите 2 вершину треугольника x,y: ");
                str_split = Console.ReadLine();
                s_arr = str_split.Split();
                point_2.X = int.Parse(s_arr[0]);
                point_2.Y = int.Parse(s_arr[1]);

                Console.Write("Введите 3 вершину треугольника x,y: ");
                str_split = Console.ReadLine();
                s_arr = str_split.Split();
                point_3.X = int.Parse(s_arr[0]);
                point_3.Y = int.Parse(s_arr[1]);

                x = Math.Sqrt((point_2.X - point_1.X) * (point_2.X - point_1.X) + (point_2.Y - point_1.Y) * (point_2.Y - point_1.Y));
                y = Math.Sqrt((point_3.X - point_2.X) * (point_3.X - point_2.X) + (point_3.Y - point_2.Y) * (point_3.Y - point_2.Y));
                z = Math.Sqrt((point_3.X - point_1.X) * (point_3.X - point_1.X) + (point_3.Y - point_1.Y) * (point_3.Y - point_1.Y));
                if ((x + y > z) && (x + z > y) && (y + z > x))
                {
                    semi_perimeter = perimeter(x, y, z) / 2;
                    
                    square(x, y, z, semi_perimeter);
                    move_to(point_1);
                    Console.WriteLine("После сдвига на 10 x_1 равен: " + point_1.X);
                    Console.WriteLine("После сдвига на 10 y_1 равен: " + point_1.Y);
                    move_to(point_2);
                    Console.WriteLine("После сдвига на 10 x_2 равен: " + point_2.X);
                    Console.WriteLine("После сдвига на 10 y_2 равен: " + point_2.Y);
                    move_to(point_3);
                    Console.WriteLine("После сдвига на 10 x_2 равен: " + point_3.X);
                    Console.WriteLine("После сдвига на 10 y_2 равен: " + point_3.Y);
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
        public void square(double x, double y, double z, double semi_perimeter)
        {
            double square = Math.Sqrt(semi_perimeter * (semi_perimeter - x) * (semi_perimeter - y) * (semi_perimeter - z));
            Console.WriteLine("Площадь треугольника равна: " + square);
        }

        public double perimeter(double x, double y, double z)
        {
            double perimeter = x + y + z;
            Console.WriteLine("Периметр треугольника равен: " + perimeter);
            return perimeter;
        }
        public void move_to(Point point)
        {
            point.X += 10;
            point.Y += 10;
        }
    }
}
