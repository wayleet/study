using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle
    {
        public const double PI = 3.1415926535897931;
        public int R = 0;
        public Circle()
        {
            Console.WriteLine("======================= Вы работаете с окружностью =======================");
            
            try
            {
                Point point = new Point();

                // Ввод двух чисел в одну строку
                Console.Write("Введите координаты центра окружности x,y: ");
                string str_split = Console.ReadLine();
                string[] s_arr = str_split.Split();
                point.X = int.Parse(s_arr[0]);
                point.Y = int.Parse(s_arr[1]);

                Console.Write("Введите радиус R :");
                R = Convert.ToInt32(Console.ReadLine());

                square(R);
                perimeter(R);

                move_to(point);
                Console.WriteLine("После сдвига на 10 x равен: " + point.X);
                Console.WriteLine("После сдвига на 10 y равен: " + point.Y);
            }
            
            catch
            {
                Console.WriteLine("Что-то пошло не так...");
            }
        }

        public void square(int R)
        {
            Console.WriteLine("Площадь круга равно: " + PI*R*R);
        }

        public void perimeter(int R)
        {
            Console.WriteLine("Периметр круга равен: " + 2*PI*R);
        }
        public void move_to(Point point)
        {
            point.X += 10;
            point.Y += 10;
        }
    }
}
