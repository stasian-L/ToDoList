using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Views;

namespace TaskManager.Presenters
{
    public class CategoriesPresenter : Presenter<ICategoriesView>
    {
        public CategoriesPresenter(ICategoriesView view) 
            : base(view)
        {
        }

        public void Display()
        {
            View.Categories = Model.GetCategories();
        }

        public bool IsUsed(int categoryId)
        {
            return Model.GetTasks().Exists(x => x.CategoryId == categoryId);
        }
        public void Save()
        {
            foreach (var item in View.Categories)
            {
                Model.UpdateCategory(item);
            }
        }
    }
}
