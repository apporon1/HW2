using System;
using System.Collections.Generic;

namespace HW2
{
    public class TaskService
    {
        private readonly ITaskRepository _repository;
        private int _nextId = 1;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public void AddTask(string title, string description)
        {
            var task = new Task
            {
                Id = _nextId++,
                Title = title,
                Description = description,
                IsCompleted = false
            };
            _repository.AddTask(task);
        }

        public List<Task> GetTasks()
        {
            return _repository.GetTasks();
        }

        public void UpdateTask(int id, string title, string description, bool isCompleted)
        {
            var task = new Task
            {
                Id = id,
                Title = title,
                Description = description,
                IsCompleted = isCompleted
            };
            _repository.UpdateTask(task);
        }

        public void DeleteTask(int id)
        {
            _repository.DeleteTask(id);
        }
    }
}
