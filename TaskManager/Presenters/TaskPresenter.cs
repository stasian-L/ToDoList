using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models.Models;
using TaskManager.Views;

namespace TaskManager.Presenters
{
    public class TaskPresenter : Presenter<ITaskView>   
    {
        public TaskPresenter(ITaskView view)
            :base(view)
        {
        }

        public void Display(int taskId)
        {
            if (taskId <= 0) return;

            var task = Model.GetTask(taskId);

            View.Id = task.Id;
            View.Title = task.Title;
            View.Description = task.Description;
            View.IsDone = task.IsDone;
            View.StartDate = task.StartDate;
            View.EndDate = task.EndDate;
            View.Status = task.Status;
            View.CategoryId = task.CategoryId;
        }

        public void Save()
        {
            var task = new TaskModel
            {
                Id = View.Id,
                Title = View.Title,
                Description = View.Description,
                IsDone = View.IsDone,
                CategoryId = View.CategoryId,
                StartDate = View.StartDate,
                EndDate = View.EndDate,
                Status = View.Status,

            };

            if (task.Id == 0)
                Model.AddTask(task);
            else
                Model.UpdateTask(task);
        }

        public void Delete(int taskId)
        {
            Model.DeleteTask(taskId);
        }

        //so that you can select a category
        public List<CategoryModel> GetCategories() 
        {
            return Model.GetCategories();
        }
    }
}
