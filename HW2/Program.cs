using System;
using System.Collections.Generic;

namespace HW2
{
    internal class Program
    {
        static void Main()
        {
            ITaskRepository repository = new TaskRepository();
            TaskController controller = new TaskController(repository);

            // Демонстрация работы с контроллером
            controller.AddTask("Сходить в магазин", "Купить продукты для ужина");
            controller.AddTask("Открыть образовательный портал", "Выгрузить дз");

            controller.ShowTasks();

            controller.UpdateTask(1, "Сходить в магазин", "Купить продукты на неделю", false);
            controller.DeleteTask(2);

            controller.ShowTasks();
        }
    }
}
