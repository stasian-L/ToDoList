using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
    public class TaskDao : ITaskDao
    {
        private DbManager db = DbManager.GetInstance();


        private void SetStatus()
        {
            foreach (var item in db.tasks)
            {
                if (item.IsDone == true)
                {
                    item.Status = "Complete";
                }
                else if (DateTime.Now >= item.EndDate)
                {
                    item.Status = "Overdue";
                }
                else
                {
                    item.Status = "Pending";
                }

            }
        }

        public void DeleteTask(BusinessObjects.Task task)
        {
            db.tasks.Remove(task);

            db.SaveTasks();
        }

        public BusinessObjects.Task GetTask(int taskId)
        {
            return db.tasks.FirstOrDefault(x => x.Id == taskId);
        }

        public List<BusinessObjects.Task> GetTaskByCategory(int categoryId)
        {
            return db.tasks.Where(x => x.CategoryId == categoryId).ToList();
        }

        public List<BusinessObjects.Task> GetTasks()
        {
            SetStatus();
            db.SaveTasks();
            return db.tasks;
        }

        public void InsertTask(BusinessObjects.Task task)
        {
            task.Id = new Random().Next(1000, 9999);
            db.tasks.Add(task);

            db.SaveTasks();
        }

        public void UpdateTask(BusinessObjects.Task task)
        {
            var entity = db.tasks.SingleOrDefault(x => x.Id == task.Id);
            entity.Title = task.Title;
            entity.Description = task.Description;
            entity.IsDone = task.IsDone;
            entity.StartDate = task.StartDate;
            entity.EndDate = task.EndDate;
            entity.CategoryId = task.CategoryId;
            entity.Status = task.Status;

            db.SaveTasks();
        }
    }
}
