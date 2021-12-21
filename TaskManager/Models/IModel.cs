using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models.Models;

namespace TaskManager.Models
{
    public interface IModel
    {
        TaskModel GetTask(int taskId);

        List<TaskModel> GetTasks();

        void AddTask(TaskModel model);

        void UpdateTask(TaskModel model);

        void DeleteTask(int taskId);


        List<CategoryModel> GetCategories();

        CategoryModel GetCategoryByName(string name);

        CategoryModel GetCategory(int id);

        void AddCategory(CategoryModel model);

        void UpdateCategory(CategoryModel model);

        void DeleteCateogyr(int categoryId);
    }
}
