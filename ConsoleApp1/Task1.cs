using System;

namespace PracticalWork1
{
    class Task1 : ITask
    {
        public void Execute()
        {
            int[] numbers = { 5, 20, 12 }; 
            Console.WriteLine("Числа в iнтервалi [1, 19]:");

            foreach (int number in numbers)
            {
                if (number >= 1 && number <= 19)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
