using System;

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewStudentPanel = new System.Windows.Forms.Panel();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.StudentAge = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FindStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewStudent = new System.Windows.Forms.Button();
            this.FindStudentPanel = new System.Windows.Forms.Panel();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataDataSet = new WindowsFormsApp1.StudentsDataDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentIDToFindText = new System.Windows.Forms.TextBox();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.studentInfoTableAdapter = new WindowsFormsApp1.StudentsDataDataSetTableAdapters.StudentInfoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.StudentsDataDataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NewStudentPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.FindStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveButton.FlatAppearance.BorderSize = 100;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Rockwell", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveButton.Location = new System.Drawing.Point(271, 441);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 60);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(149, 37);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(159, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("Rockwell", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.StudentName.Location = new System.Drawing.Point(27, 28);
            this.StudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(93, 29);
            this.StudentName.TabIndex = 4;
            this.StudentName.Text = "Name :";
            this.StudentName.Click += new System.EventHandler(this.StudentName_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.White;
            this.DisplayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisplayButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisplayButton.Font = new System.Drawing.Font("Rockwell", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DisplayButton.Location = new System.Drawing.Point(271, 441);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(161, 60);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "Find";
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Visible = false;
            this.DisplayButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 65);
            this.panel1.TabIndex = 7;
            // 
            // NewStudentPanel
            // 
            this.NewStudentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewStudentPanel.Controls.Add(this.AgeTextBox);
            this.NewStudentPanel.Controls.Add(this.StudentAge);
            this.NewStudentPanel.Controls.Add(this.StudentName);
            this.NewStudentPanel.Controls.Add(this.NameTextBox);
            this.NewStudentPanel.Location = new System.Drawing.Point(246, 65);
            this.NewStudentPanel.Name = "NewStudentPanel";
            this.NewStudentPanel.Size = new System.Drawing.Size(688, 370);
            this.NewStudentPanel.TabIndex = 0;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(149, 91);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(81, 20);
            this.AgeTextBox.TabIndex = 2;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StudentAge
            // 
            this.StudentAge.AutoSize = true;
            this.StudentAge.Font = new System.Drawing.Font("Rockwell", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.StudentAge.Location = new System.Drawing.Point(27, 84);
            this.StudentAge.Name = "StudentAge";
            this.StudentAge.Size = new System.Drawing.Size(63, 29);
            this.StudentAge.TabIndex = 6;
            this.StudentAge.Text = "Age:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel3.Controls.Add(this.FindStudent);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.NewStudent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 489);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // FindStudent
            // 
            this.FindStudent.BackColor = System.Drawing.Color.White;
            this.FindStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindStudent.Font = new System.Drawing.Font("Rockwell", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FindStudent.Location = new System.Drawing.Point(0, 167);
            this.FindStudent.Name = "FindStudent";
            this.FindStudent.Size = new System.Drawing.Size(240, 56);
            this.FindStudent.TabIndex = 11;
            this.FindStudent.Text = "Find Student";
            this.FindStudent.UseVisualStyleBackColor = false;
            this.FindStudent.Click += new System.EventHandler(this.FindStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewStudent
            // 
            this.NewStudent.BackColor = System.Drawing.Color.Silver;
            this.NewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewStudent.Font = new System.Drawing.Font("Rockwell", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NewStudent.Location = new System.Drawing.Point(0, 93);
            this.NewStudent.Name = "NewStudent";
            this.NewStudent.Size = new System.Drawing.Size(240, 56);
            this.NewStudent.TabIndex = 10;
            this.NewStudent.Text = "New Student";
            this.NewStudent.UseVisualStyleBackColor = false;
            this.NewStudent.Click += new System.EventHandler(this.NewStudent_Click);
            // 
            // FindStudentPanel
            // 
            this.FindStudentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FindStudentPanel.Controls.Add(this.StudentDataGridView);
            this.FindStudentPanel.Controls.Add(this.label2);
            this.FindStudentPanel.Controls.Add(this.StudentIDToFindText);
            this.FindStudentPanel.Location = new System.Drawing.Point(246, 65);
            this.FindStudentPanel.Name = "FindStudentPanel";
            this.FindStudentPanel.Size = new System.Drawing.Size(688, 370);
            this.FindStudentPanel.TabIndex = 0;
            this.FindStudentPanel.Visible = false;
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.AutoGenerateColumns = false;
            this.StudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn});
            this.StudentDataGridView.DataSource = this.studentInfoBindingSource;
            this.StudentDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentDataGridView.Location = new System.Drawing.Point(0, 93);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.Size = new System.Drawing.Size(688, 277);
            this.StudentDataGridView.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.studentsDataDataSet;
            // 
            // studentsDataDataSet
            // 
            this.studentsDataDataSet.DataSetName = "StudentsDataDataSet";
            this.studentsDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(27, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // StudentIDToFindText
            // 
            this.StudentIDToFindText.Location = new System.Drawing.Point(146, 34);
            this.StudentIDToFindText.Name = "StudentIDToFindText";
            this.StudentIDToFindText.Size = new System.Drawing.Size(159, 20);
            this.StudentIDToFindText.TabIndex = 0;
            this.StudentIDToFindText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.BackColor = System.Drawing.Color.Red;
            this.DeleteStudentButton.Font = new System.Drawing.Font("Rockwell", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DeleteStudentButton.Location = new System.Drawing.Point(750, 441);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(161, 60);
            this.DeleteStudentButton.TabIndex = 2;
            this.DeleteStudentButton.Text = "Delete";
            this.DeleteStudentButton.UseVisualStyleBackColor = false;
            this.DeleteStudentButton.Visible = false;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentInfoTableAdapter = this.studentInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.StudentsDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(934, 554);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.FindStudentPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NewStudentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Entering data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NewStudentPanel.ResumeLayout(false);
            this.NewStudentPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.FindStudentPanel.ResumeLayout(false);
            this.FindStudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel NewStudentPanel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label StudentAge;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewStudent;
        private System.Windows.Forms.Button FindStudent;
        private System.Windows.Forms.Panel FindStudentPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentIDToFindText;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private StudentsDataDataSet studentsDataDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentsDataDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private StudentsDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
    }
}

