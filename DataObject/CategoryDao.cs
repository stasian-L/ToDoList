using BusinesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class CategoryDao : ICategoryDao
    {
        private DbManager db = DbManager.GetInstance();

        public void InsertCategory(Category category)
        {
            category.CategoryId = new Random().Next(1000, 9999);

            db.categories.Add(category);
            db.SaveCategories();
        }

        public List<Category> GetCategories()
        {
            return db.categories;
        }

        public Category GetCategory(int categoryId)
        {
            return db.categories.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public Category GetCategoryByName(string categoryName)
        {
            return db.categories.FirstOrDefault(x => x.CategoryName == categoryName);
        }

        public void UpdateCategory(Category category)
        {
            var entity = db.categories.SingleOrDefault(x => x.CategoryId == category.CategoryId);
            entity.CategoryName = category.CategoryName;

            db.SaveCategories();
        }

        public void DeleteCategory(Category category)
        {
            db.categories.Remove(category);
            db.SaveCategories();
        }
    }
}
