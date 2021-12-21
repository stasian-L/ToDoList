using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = BusinessObjects.Task;

namespace DataObjects
{
    public interface ITaskDao
    {
        // gets a specific Task

        Task GetTask(int taskId);

        List<Task> GetTaskByCategory(int categoryId);

        List<Task> GetTasks();

        // inserts a new Task

        void InsertTask(Task task);

        // updates a Task

        void UpdateTask(Task task);

        // deletes a Task

        void DeleteTask(Task task);
    }
}
