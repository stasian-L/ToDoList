using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models.Models;

namespace TaskManager.Views
{
    public interface ITasksView : IView
    {
        IList<TaskModel> Tasks { set; get; }
    }
}
