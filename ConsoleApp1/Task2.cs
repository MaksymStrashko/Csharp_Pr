using System;

namespace PracticalWork1
{
    class Task2 : ITask
    {
        public void Execute()
        {
            double a = 3, b = 4, c = 5; 

            if (IsValidTriangle(a, b, c))
            {
                double perimeter = a + b + c;
                double semiPerimeter = perimeter / 2;
                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

                Console.WriteLine($"Периметр: {perimeter}");
                Console.WriteLine($"Площа: {area:F2}");
                Console.WriteLine($"Тип трикутника: {GetTriangleType(a, b, c)}");
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не iснує.");
            }
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c) return "Рiвностороннiй";
            if (a == b || b == c || a == c) return "Рiвнобедрений";
            return "Рiзностороннiй";
        }
    }
}

