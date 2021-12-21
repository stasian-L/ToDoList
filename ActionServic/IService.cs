using BusinesObjects;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = BusinessObjects.Task;

namespace ActionService
{

    public interface IService
    {

        Task GetTask(int taskId);
        List<Task> GetTaskByCategory(int categoryId);
        List<Task> GetTasks();
        void InsertTask(Task task);
        void UpdateTask(Task task);
        void DeleteTask(Task task);


        Category GetCategory(int Id);
        Category GetCategoryByName(string name);
        List<Category> GetCategories();
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
