using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Presenters;
using TaskManager.Views;

namespace TaskManager
{
    public partial class FormCategory : Form, ICategoryView
    {
        private CategoryPresenter categoryPresenter;
        private bool cancelClose;

        public FormCategory()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.FormCategory_FormClosing);

            categoryPresenter = new CategoryPresenter(this);
        }

        public int CategoryId { get; set; }
        
        public string CategoryName
        {
            get { return textBoxName.Text.Trim(); }
            set { textBoxName.Text = value; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            try
            {
                categoryPresenter.Save();
                this.Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Save failed");
                cancelClose = true;
            }
        }

        private void FormCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = cancelClose;
            cancelClose = false;
        }
    }
}
