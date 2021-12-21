using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models.Models;
using TaskManager.Views;

namespace TaskManager.Presenters
{
    public class TasksPresenter:Presenter<ITasksView>
    {
        public TasksPresenter(ITasksView view)
            : base(view)
        {
        }

        public void Display()
        {
            View.Tasks = Model.GetTasks();
        }
        public void Display(string status)
        {
            View.Tasks = Model.GetTasks().Where(x=>x.Status == status).ToList();
        }

        public void Display(DateTime date)
        {
            View.Tasks = Model.GetTasks().Where(x=>x.StartDate<=date && x.EndDate>=date).ToList();
        }
        public void Search(string seachString)
        {
            View.Tasks = Model.GetTasks().Where(x => x.Title.ToLower().Contains(seachString.ToLower())).ToList();
        }

        public void Save()
        {
            foreach (var item in View.Tasks)
            {
                Model.UpdateTask(item);
            }
        }

        public CategoryModel GetCategory(int id)
        {
            return Model.GetCategory(id);
        }
    }
}
