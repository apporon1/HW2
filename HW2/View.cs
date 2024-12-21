using System;
using System.Collections.Generic;

namespace HW2
{
    public class TaskView
    {
        public void ShowTasks(List<Task> tasks)
        {
            Console.WriteLine("Задачи:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"ID: {task.Id}, Название: {task.Title}, Описание: {task.Description}, Выполнена: {task.IsCompleted}");
            }
        }
    }
}
