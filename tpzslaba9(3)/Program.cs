using System;

namespace tpzslaba9_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> f;

            Console.WriteLine("Введите радиус для фигур : ");

            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle();

            f = circle.SquareCircle;
            Console.WriteLine("Площадь круга - {0}", f.Invoke(radius));

            f = circle.LengthCircle;
            Console.WriteLine("Длина круга - {0}", f.Invoke(radius));

            f = circle.CapacitySphere;
            Console.WriteLine("Обьем сферы - {0}", f.Invoke(radius));
            Console.ReadKey();
        }
    }
}
