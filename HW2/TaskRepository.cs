using System;
using System.Collections.Generic;

namespace HW2
{
    public class TaskRepository : ITaskRepository
    {
        private readonly List<Task> _tasks = new List<Task>();

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        public List<Task> GetTasks()
        {
            return _tasks;
        }

        public void UpdateTask(Task task)
        {
            var existingTask = _tasks.Find(t => t.Id == task.Id);
            if (existingTask != null)
            {
                existingTask.Title = task.Title;
                existingTask.Description = task.Description;
                existingTask.IsCompleted = task.IsCompleted;
            }
        }

        public void DeleteTask(int id)
        {
            var task = _tasks.Find(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }
    }
    }
