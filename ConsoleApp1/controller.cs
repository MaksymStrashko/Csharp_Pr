using PracticalWork1;
using System;
using System.Collections.Generic;

namespace PracticalWork1
{
    class TaskController
    {
        private List<ITask> tasks;

        public TaskController()
        {
            tasks = new List<ITask>
            {
                new Task1(),
                new Task2(),
                new Task3(),
                new Task4()
            };
        }

        public void RunTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Виконання {task.GetType().Name}:");
                task.Execute();
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}

