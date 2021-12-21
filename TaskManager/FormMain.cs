using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Models.Models;
using TaskManager.Presenters;
using TaskManager.Views;

namespace TaskManager
{
    public partial class FormMain : Form, ITasksView
    {
        TasksPresenter tasksPresenter;

        private IList<TaskModel> _tasks;

        public FormMain()
        {
            InitializeComponent();

            tasksPresenter = new TasksPresenter(this);
        }

        public IList<TaskModel> Tasks
        {
            set
            {
                _tasks = value;

                var items = listViewTasks.Items;
                items.Clear();

                foreach (var task in _tasks)
                {
                    AddTaskToList(task);
                }
            }
            get { return _tasks; }
        }



        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count == 0)
            {
                textBoxTaskDescription.Text = "";
                return;
            }


            var row = listViewTasks.SelectedItems[0];
            if (row == null) return;

            var task = listViewTasks.SelectedItems[0].Tag as TaskModel;

            if (task.Status == "Complete" || task.Status == "Overdue")
                buttonEdit.Enabled = false;
            else buttonEdit.Enabled = true;


            textBoxTaskDescription.Text = task.Description;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormTask())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                   
                    tasksPresenter.Display();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Check if a node is selected
            if (listViewTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("No member is currently selected",
                            "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var form = new FormTask())
            {
                var task = listViewTasks.SelectedItems[0].Tag as TaskModel;
                form.Id = task.Id;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Redisplay list of tasks
                    tasksPresenter.Display();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if a node is selected
            if (listViewTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("No task is currently selected",
                            "Delete Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var task = listViewTasks.SelectedItems[0].Tag as TaskModel;

            try
            {
                // Execute delete
                new TaskPresenter(null).Delete(task.Id);

                // Remove in tasks
                _tasks.Remove(task);

                // Remove node
                listViewTasks.Items.Remove(listViewTasks.SelectedItems[0]);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Delete failed");
            }
        }

        private ListViewItem AddTaskToList(TaskModel task)
        {
            ListViewItem node = new ListViewItem();

            node.SubItems.Add(tasksPresenter.GetCategory(task.CategoryId).CategoryName);
            node.SubItems.Add(task.StartDate.ToString());
            node.SubItems.Add(task.EndDate.ToString());
            node.SubItems.Add(task.Status);
            node.SubItems[0].Text = "    " + task.Title;
            node.Tag = task;
            node.ImageIndex = 1;

            if(DateTime.Now >= task.EndDate)
            {
                task.Status = Properties.AppResources.Resource.btnOverdueText;
            }

            if (task.IsDone == true)
            {
                node.Checked = true;
                node.BackColor = Color.FromArgb(19, 191, 54);
            }
            else if (task.Status == Properties.AppResources.Resource.btnOverdueText)
            {
                node.BackColor = Color.FromArgb(214, 60, 26);
            }

            this.listViewTasks.Items.Add(node);

            return node;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetHeight(listViewTasks, 35);

            tasksPresenter.Display();

        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tasksPresenter.Display(monthCalendar1.SelectionStart);
        }


        private enum TaskStatus
        {
            All,
            Pending,
            Complete,
            Overdue
        }

        private TaskStatus Status
        {
            set
            {
                if (value == TaskStatus.All)
                {
                    tasksPresenter.Display();
                }
                else if (value == TaskStatus.Pending)
                {
                    tasksPresenter.Display(TaskStatus.Pending.ToString());
                }
                else if (value == TaskStatus.Complete)
                {
                    tasksPresenter.Display(TaskStatus.Complete.ToString());
                }
                else
                {
                    tasksPresenter.Display(TaskStatus.Overdue.ToString());
                }
            }
        }


        private void btnAll_Click(object sender, EventArgs e)
        {
            Status = TaskStatus.All;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            Status = TaskStatus.Pending;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Status = TaskStatus.Complete;
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            Status = TaskStatus.Overdue;
        }

        private void listViewTasks_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var list = listViewTasks.Items.Cast<ListViewItem>().ToList();

            foreach (var item in list)
            {
                if (item.Checked == true)
                {
                    _tasks.ElementAt(item.Index).Status = Properties.AppResources.Resource.btnCompleteText;
                    _tasks.ElementAt(item.Index).IsDone = true;
                }
                else
                {
                    _tasks.ElementAt(item.Index).IsDone = false;
                }

            }
            tasksPresenter.Save();
        }

        private void btnRafresh_Click(object sender, EventArgs e)
        {
            tasksPresenter.Display();
        }

        private void btnMagageCat_Click(object sender, EventArgs e)
        {
            using (var form = new FormCategories())
            {
                form.ShowDialog();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new FormHelp())
            {
                form.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                tasksPresenter.Search(textBox1.Text);
            }
            else
            {
                tasksPresenter.Display();
            }
        }
    }
}
