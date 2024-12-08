using System;

namespace PracticalWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskController controller = new TaskController();
            controller.RunTasks();

            Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити...");
            Console.ReadKey();
        }
    }
}
