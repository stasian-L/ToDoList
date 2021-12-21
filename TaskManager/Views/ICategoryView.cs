using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Views
{
    public interface ICategoryView : IView
    {
        int CategoryId { get; set; }
        string CategoryName { get; set; }
    }
}
