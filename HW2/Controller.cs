using System;
using System.Collections.Generic;


namespace HW2
{
    public class TaskController
    {
        private readonly TaskService _service;
        private readonly TaskView _view;

        public TaskController(ITaskRepository repository)
        {
            _service = new TaskService(repository);
            _view = new TaskView();
        }

        public void AddTask(string title, string description)
        {
            _service.AddTask(title, description);
        }

        public void ShowTasks()
        {
            var tasks = _service.GetTasks();
            _view.ShowTasks(tasks);
        }

        public void UpdateTask(int id, string title, string description, bool isCompleted)
        {
            _service.UpdateTask(id, title, description, isCompleted);
        }

        public void DeleteTask(int id)
        {
            _service.DeleteTask(id);
        }
    }
}
