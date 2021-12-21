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
    public partial class FormTask : Form, ITaskView
    {
        private TaskPresenter taskPresenter;
        private bool cancelClose;

        public FormTask()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.FormTask_FormClosing);

            taskPresenter = new TaskPresenter(this);

            comboBoxCategory.DataSource = taskPresenter.GetCategories();
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";
        }

        public int Id { get; set; }
        public string Title
        {
            get { return textBoxTitle.Text.Trim(); }
            set { textBoxTitle.Text = value; }
        }   
        public string Description
        {
            get { return textBoxDescription.Text.Trim(); }
            set { textBoxDescription.Text = value; }
        }
        public bool IsDone
        {
            get { return false; }
            set { }
        }

        public DateTime StartDate
        {
            get { return dateTimePickerStartDate.Value.Date + TimePickerStartDate.Value.TimeOfDay; }
            set { dateTimePickerStartDate.Value = value; TimePickerStartDate.Value = value; }
        }


        public DateTime EndDate
        {
            get { return dateTimePickerEndDate.Value.Date + TimePickerEndDate.Value.TimeOfDay; }
            set { dateTimePickerEndDate.Value = value; TimePickerEndDate.Value = value; }
        }
        public string Status
        {
            get => "Pending";
            set { }
        }
        public int CategoryId
        {
            get
            {
                return (int)comboBoxCategory.SelectedValue;
            }
            set { }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Title) ||
                string.IsNullOrEmpty(Description) ||
                comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("All fields are required");
                return;
            }

            try
            {
                taskPresenter.Save();
                this.Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Save failed");
                cancelClose = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTask_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                this.Text = Properties.AppResources.Resource.FormAddTaskText;
                groupBoxAddTask.Text = Properties.AppResources.Resource.FormAddTaskText;
            }
            else
            {
                this.Text = Properties.AppResources.Resource.FormEditTaskText;
                groupBoxAddTask.Text = Properties.AppResources.Resource.FormEditTaskText;
            }

            taskPresenter.Display(Id);
        }

        private void FormTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = cancelClose;
            cancelClose = false;
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            // this is default
            dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddDays(1);
            dateTimePickerEndDate.MinDate = dateTimePickerStartDate.Value;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (var form = new FormCategory())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    comboBoxCategory.DataSource = taskPresenter.GetCategories();
                }
            }
        }

        private void TimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePickerStartDate.Value.Date == dateTimePickerEndDate.Value.Date)
            {
                TimePickerEndDate.Value = TimePickerEndDate.Value;
                TimePickerEndDate.MinDate = TimePickerStartDate.Value;
            }
        }
    }
}
