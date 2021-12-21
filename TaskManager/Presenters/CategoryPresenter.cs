using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models.Models;
using TaskManager.Views;

namespace TaskManager.Presenters
{
    public class CategoryPresenter : Presenter<ICategoryView>
    {
        public CategoryPresenter(ICategoryView view) 
            : base(view)
        {
        } 

        public void Save()
        {
            var category = new CategoryModel
            {
                CategoryId = View.CategoryId,
                CategoryName = View.CategoryName,
            };

            if (category.CategoryId == 0)
                Model.AddCategory(category);
            else
                Model.UpdateCategory(category);
        }

        public void Delete(int categoryId)
        {
            Model.DeleteCateogyr(categoryId);
        }
    }
}
