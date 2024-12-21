using System;
using System.Collections.Generic;

namespace HW2
{
    public interface ITaskRepository
    {
        void AddTask(Task task);
        List<Task> GetTasks();
        void UpdateTask(Task task);
        void DeleteTask(int id);
    }
}
