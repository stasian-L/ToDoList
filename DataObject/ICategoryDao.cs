using BusinesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface ICategoryDao
    {
        Category GetCategory(int categoryId);

        Category GetCategoryByName(string categoryName);

        List<Category> GetCategories();


        void InsertCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(Category category);
    }
}
