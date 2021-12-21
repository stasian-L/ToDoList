using BusinesObjects;
using DataObject;
using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = BusinessObjects.Task;

namespace ActionService
{
    public class Service : IService
    {
        static readonly ITaskDao taskDao = new TaskDao();
        static readonly ICategoryDao categoryDao = new CategoryDao();

        public void DeleteTask(Task task)
        {
            taskDao.DeleteTask(task);
        }

        public Task GetTask(int taskId)
        {
            return taskDao.GetTask(taskId);
        }

        public List<Task> GetTasks()
        {
            return taskDao.GetTasks();
        }

        public void InsertTask(Task task)
        {
            taskDao.InsertTask(task);
        }

        public void UpdateTask(Task task)
        {
            taskDao.UpdateTask(task);
        }


        public List<Category> GetCategories()
        {
            return categoryDao.GetCategories();
        }

        public Category GetCategory(int Id)
        {
            return categoryDao.GetCategory(Id);
        }

        public List<Task> GetTaskByCategory(int categoryId)
        {
            return taskDao.GetTaskByCategory(categoryId);
        }

        public Category GetCategoryByName(string name)
        {
            return categoryDao.GetCategoryByName(name);
        }

        public void InsertCategory(Category category)
        {
            categoryDao.InsertCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            categoryDao.UpdateCategory(category);
        }

        public void DeleteCategory(Category category)
        {
            categoryDao.DeleteCategory(category);
        }
    }
}
