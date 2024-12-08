using System;

namespace PracticalWork1
{
    class Task4 : ITask
    {
        public void Execute()
        {
            int[] X = new int[19];
            Random random = new Random();

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = random.Next(-20, 20);
            }

            Console.WriteLine("Масив X:");
            Console.WriteLine(string.Join(" ", X));

            int M = 5; // Задане число
            Console.WriteLine($"Задане число M: {M}");

            int[] Y = Array.FindAll(X, x => Math.Abs(x) > M);

            Console.WriteLine("Новий масив Y:");
            Console.WriteLine(string.Join(" ", Y));
        }
    }
}
