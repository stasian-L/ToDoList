using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Models.Models;
using TaskManager.Presenters;
using TaskManager.Views;

namespace TaskManager
{
    public partial class FormCategories : Form, ICategoriesView
    {
        private CategoriesPresenter categoriesPresenter;

        private IList<CategoryModel> _categories;
        public FormCategories()
        {
            InitializeComponent();

            categoriesPresenter = new CategoriesPresenter(this);

            categoriesPresenter.Display();
        }

        public IList<CategoryModel> Categories
        {
            set
            {
                _categories = value;

                var root = listViewCategories.Items;
                root.Clear();

                foreach (var category in _categories)
                {
                    AddCategoryToList(category);
                }
            }
            get { return _categories; }
        }

        private ListViewItem AddCategoryToList(CategoryModel category)
        {
            ListViewItem node = new ListViewItem();

            node.Text = category.CategoryName;
            node.Tag = category;
            node.ImageIndex = 1;

            this.listViewCategories.Items.Add(node);

            return node;
        }

        private void listViewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                categoriesPresenter.Save();
                this.Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Save failed");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormCategory())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Redisplay list of categories
                    categoriesPresenter.Display();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if a node is selected
            if (listViewCategories.SelectedItems == null)
            {
                MessageBox.Show("No category is currently selected",
                            "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var category = listViewCategories.SelectedItems[0].Tag as CategoryModel;

            // Check if a category is used by task
            if (categoriesPresenter.IsUsed(category.CategoryId))
            {
                MessageBox.Show("This category is currently used by tasks",
                            "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Execute delete
                new CategoryPresenter(null).Delete(category.CategoryId);

                // Remove in _categories
                _categories.Remove(category);

                // Remove node
                listViewCategories.Items.Remove(listViewCategories.SelectedItems[0]);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Delete failed");
            }
        }

    }
}
