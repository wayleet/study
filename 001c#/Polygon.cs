using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Polygon
    {
        public Polygon()
        {

            Console.WriteLine("======================= Вы работаете с многоугольником =======================");
            try
            {
                double perimetr = 0;
                Console.Write("Введите количество вершин: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Point[] point = new Point[n];

                for (int i = 0; i < n; i++)
                {
                    point[i] = new Point();
                    Console.Write($"Введите {i + 1} вершину многоульника x,y: ");
                    string str_split = Console.ReadLine();
                    string[] s_arr = str_split.Split();
                    point[i].X = int.Parse(s_arr[0]);
                    point[i].Y = int.Parse(s_arr[1]);
                }

                for (int i = 0; i < n-1; i++)
                {
                    perimetr += Math.Sqrt((point[i+1].X - point[i].X) * (point[i+1].X - point[i].X) + (point[i+1].Y - point[i].Y) * (point[i+1].Y - point[i].Y));
                }
                perimetr += Math.Sqrt((point[n-1].X - point[0].X) * (point[n-1].X - point[0].X) + (point[n-1].Y - point[0].Y) * (point[n-1].Y - point[0].Y));
                Console.WriteLine("Периметр равен: " + perimetr);
                for (int i = 0; i < n; i++)
                {
                    move_to(point[i]);
                    Console.WriteLine($"После сдвига на 10 x_{i + 1} равен: " + point[i].X);
                    Console.WriteLine($"После сдвига на 10 y_{i + 1} равен: " + point[i].Y);
                }
            }

            catch
            {
                Console.WriteLine("Что-то пошло не так...");
            }
        }

        public void move_to(Point point)
        {
            point.X += 10;
            point.Y += 10;
        }
    }
}
