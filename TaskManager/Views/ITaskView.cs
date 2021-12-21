using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Views
{
    public interface ITaskView : IView
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        bool IsDone { get; set; }

        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }

        string Status { get; set; }
        int CategoryId { get; set; }
    }
}
