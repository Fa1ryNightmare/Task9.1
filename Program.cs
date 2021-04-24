using System;

namespace Task9_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Vector vector0 = new Vector(x, y, z);
            Vector vector1 = new Vector(4, 4, 4);
            Console.WriteLine("1 вектор " + vector0.ToString());
            Console.WriteLine();
            Console.WriteLine("2 вектор " + vector1.ToString());
            Vector vector2 = vector0 + vector1;
            Console.WriteLine();
            Console.WriteLine("Результат сложения 1 и 2 вектора " + vector2.ToString());
            vector2 = vector0 - vector1;
            Console.WriteLine();
            Console.WriteLine("Результат вычитания 1 и 2 вектора " + vector2.ToString());

            Console.ReadKey();
        }
    }
}
