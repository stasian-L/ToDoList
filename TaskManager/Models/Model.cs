using ActionService;
using AutoMapper;
using BusinesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models.Models;
using Task = BusinessObjects.Task;

namespace TaskManager.Models
{
    public class Model : IModel
    {
        static IService service = new Service();

        private static Mapper tMapper;
        private static Mapper tMapper2;

        private static Mapper cMapper;
        private static Mapper cMapper2;


        static Model()
        {
            var taskConfig = new MapperConfiguration(cfg => cfg.CreateMap<Task, TaskModel>());
            var taskConfig2 = new MapperConfiguration(cfg => cfg.CreateMap<TaskModel, Task>());

            var categoryConfig = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryModel>());
            var categoryConfig2 = new MapperConfiguration(cfg => cfg.CreateMap<CategoryModel, Category>());

            tMapper = new Mapper(taskConfig);
            tMapper2 = new Mapper(taskConfig2);
            cMapper = new Mapper(categoryConfig);
            cMapper2 = new Mapper(categoryConfig2);
        }

        public void DeleteTask(int taskId)
        {
            var task = service.GetTask(taskId);
            service.DeleteTask(task);
        }

        public TaskModel GetTask(int taskId)
        {
            var task = service.GetTask(taskId);
            return tMapper.Map<Task, TaskModel>(task);
        }

        public List<TaskModel> GetTasks()
        {
            var tasks = service.GetTasks();
            return tMapper.Map<List<Task>, List<TaskModel>>(tasks);
        }

        public void AddTask(TaskModel model)
        {
            var task = tMapper2.Map<TaskModel, Task>(model);
            service.InsertTask(task);
        }

        public void UpdateTask(TaskModel model)
        {
            var task = tMapper2.Map<TaskModel, Task>(model);
            service.UpdateTask(task);
        }

        public List<CategoryModel> GetCategories()
        {
            var categories = service.GetCategories();
            return cMapper.Map<List<Category>, List<CategoryModel>>(categories);
        }

        public CategoryModel GetCategoryByName(string name)
        {
            var category = service.GetCategoryByName(name);
            return cMapper.Map<Category, CategoryModel>(category);
        }

        public CategoryModel GetCategory(int id)
        {
            var category = service.GetCategory(id);
            return cMapper.Map<Category, CategoryModel>(category);
        }

        public void AddCategory(CategoryModel model)
        {
            var task = cMapper2.Map<CategoryModel, Category>(model);
            service.InsertCategory(task);
        }

        public void UpdateCategory(CategoryModel model)
        {
            var task = cMapper2.Map<CategoryModel, Category>(model);
            service.UpdateCategory(task);
        }

        public void DeleteCateogyr(int categoryId)
        {
            var category = service.GetCategory(categoryId);
            service.DeleteCategory(category);
        }
    }
}
