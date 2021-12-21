
namespace TaskManager
{
    partial class FormTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.groupBoxAddTask = new System.Windows.Forms.GroupBox();
            this.TimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.TimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelDescriptoin = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxAddTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddTask
            // 
            this.groupBoxAddTask.AutoSize = true;
            this.groupBoxAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.groupBoxAddTask.Controls.Add(this.TimePickerEndDate);
            this.groupBoxAddTask.Controls.Add(this.TimePickerStartDate);
            this.groupBoxAddTask.Controls.Add(this.button1);
            this.groupBoxAddTask.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxAddTask.Controls.Add(this.label1);
            this.groupBoxAddTask.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddTask.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxAddTask.Controls.Add(this.labelEndDate);
            this.groupBoxAddTask.Controls.Add(this.labelStartDate);
            this.groupBoxAddTask.Controls.Add(this.labelDescriptoin);
            this.groupBoxAddTask.Controls.Add(this.labelTitle);
            this.groupBoxAddTask.Controls.Add(this.textBoxTitle);
            this.groupBoxAddTask.Controls.Add(this.textBoxDescription);
            this.groupBoxAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAddTask.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBoxAddTask.Location = new System.Drawing.Point(52, 58);
            this.groupBoxAddTask.Name = "groupBoxAddTask";
            this.groupBoxAddTask.Size = new System.Drawing.Size(735, 375);
            this.groupBoxAddTask.TabIndex = 4;
            this.groupBoxAddTask.TabStop = false;
            this.groupBoxAddTask.Text = "Add Task";
            // 
            // TimePickerEndDate
            // 
            this.TimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerEndDate.Location = new System.Drawing.Point(413, 266);
            this.TimePickerEndDate.Name = "TimePickerEndDate";
            this.TimePickerEndDate.ShowUpDown = true;
            this.TimePickerEndDate.Size = new System.Drawing.Size(135, 22);
            this.TimePickerEndDate.TabIndex = 17;
            this.TimePickerEndDate.Value = new System.DateTime(2021, 12, 9, 0, 0, 0, 0);
            // 
            // TimePickerStartDate
            // 
            this.TimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerStartDate.Location = new System.Drawing.Point(413, 225);
            this.TimePickerStartDate.Name = "TimePickerStartDate";
            this.TimePickerStartDate.ShowUpDown = true;
            this.TimePickerStartDate.Size = new System.Drawing.Size(135, 22);
            this.TimePickerStartDate.TabIndex = 16;
            this.TimePickerStartDate.Value = new System.DateTime(2021, 12, 9, 0, 0, 0, 0);
            this.TimePickerStartDate.ValueChanged += new System.EventHandler(this.TimePickerStartDate_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(303, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 24);
            this.button1.TabIndex = 15;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(156, 267);
            this.dateTimePickerEndDate.MinDate = new System.DateTime(2021, 11, 5, 0, 0, 0, 0);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndDate.TabIndex = 14;
            this.dateTimePickerEndDate.Value = new System.DateTime(2021, 12, 5, 23, 41, 46, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(156, 325);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategory.TabIndex = 12;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(156, 225);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2021, 12, 4, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStartDate.TabIndex = 10;
            this.dateTimePickerStartDate.Value = new System.DateTime(2021, 12, 5, 23, 45, 0, 0);
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(50, 271);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(65, 17);
            this.labelEndDate.TabIndex = 9;
            this.labelEndDate.Text = "End date";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(44, 230);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(70, 17);
            this.labelStartDate.TabIndex = 8;
            this.labelStartDate.Text = "Start date";
            // 
            // labelDescriptoin
            // 
            this.labelDescriptoin.AutoSize = true;
            this.labelDescriptoin.Location = new System.Drawing.Point(35, 106);
            this.labelDescriptoin.Name = "labelDescriptoin";
            this.labelDescriptoin.Size = new System.Drawing.Size(79, 17);
            this.labelDescriptoin.TabIndex = 7;
            this.labelDescriptoin.Text = "Description";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(79, 46);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.Location = new System.Drawing.Point(156, 46);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(513, 22);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDescription.Location = new System.Drawing.Point(156, 106);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(513, 102);
            this.textBoxDescription.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(427, 453);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 28);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = global::TaskManager.Properties.AppResources.Resource.btnCancelText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(305, 453);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 28);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = global::TaskManager.Properties.AppResources.Resource.btnSaveText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(859, 500);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxAddTask);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTask";
            this.Text = "FormAddTask";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTask_FormClosing);
            this.Load += new System.EventHandler(this.FormTask_Load);
            this.groupBoxAddTask.ResumeLayout(false);
            this.groupBoxAddTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddTask;
        private System.Windows.Forms.Label labelDescriptoin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker TimePickerEndDate;
        private System.Windows.Forms.DateTimePicker TimePickerStartDate;
    }
}