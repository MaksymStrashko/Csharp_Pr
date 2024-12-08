using System;

namespace PracticalWork1
{
    class Task3 : ITask
    {
        public void Execute()
        {
            int[] array = new int[19];
            Random random = new Random();

            Console.WriteLine("Масив Х:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10); 
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
