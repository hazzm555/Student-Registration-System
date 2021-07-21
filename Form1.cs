using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public enum SaveMode {File, DataBase};
        public static SaveMode saveMode = SaveMode.DataBase;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (saveMode == SaveMode.File)
            //{
            //    try
            //    {

            //        if (NameTextBox.Text != null && IDTextBox.Text != null)
            //        {
            //            Saver.AddRecord(Convert.ToInt32(IDTextBox.Text), NameTextBox.Text);
            //        }
            //        else
            //        {

            //            throw new ArgumentNullException();
            //        }
            //    }
            //    catch (Exception Error)
            //    {
            //        MessageBox.Show(Error.ToString());
            //    }
            //}
            if (saveMode == SaveMode.DataBase)
            {
                if (NameTextBox.Text != "" && AgeTextBox.Text != "")
                {   
                    bool AddingResult = SaverDB.AddRecord(NameTextBox.Text, Convert.ToInt32(AgeTextBox.Text));
                    if (AddingResult)
                    {
                        NameTextBox.Text = "";
                        AgeTextBox.Text = "";
                    }
                    else
                    { 
                        
                    }
                    
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Some Data input is empty, please fill them all");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentsDataDataSet.StudentInfo);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveMode == SaveMode.File)
            {
                System.Windows.Forms.MessageBox.Show("Saved");
                Saver.Save();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }





        // Find And Refresh
        private void button2_Click(object sender, EventArgs e)
        {
            if (saveMode == SaveMode.File)
            {
                Saver.DisplayStudents();
            }
            else if (saveMode == SaveMode.DataBase)
            {   //Refresh
                if (StudentIDToFindText.Text == "")
                {
                    StudentDataGridView.DataSource = SaverDB.DisplayStudents();
                }
                else //Find
                {
                    int ID = Convert.ToInt32(StudentIDToFindText.Text);
                    int index = -1;                   
                    

                        int i = 0;
                        for (DataGridViewRow row = StudentDataGridView.Rows[0]; i < StudentDataGridView.RowCount; i++)
                        {
                            if (int.Parse(row.Cells[0].Value.ToString()) == ID)
                            {
                                index = row.Index;
                                break;
                            }
                            row = StudentDataGridView.Rows[i];
                        }




                    if (index == -1)
                    {
                        System.Windows.Forms.MessageBox.Show($"There is no Student with ID: {ID}");
                    }
                    else
                    {
                        StudentDataGridView.Rows[index].Selected = true;
                        StudentDataGridView.FirstDisplayedScrollingRowIndex = index;
                    }
                }
            }
        }

        private void StudentName_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewStudent_Click(object sender, EventArgs e)
        {
            NewStudent.BackColor = Color.Silver;
            FindStudent.BackColor = Color.White;
            FindStudentPanel.Visible = false;
            DisplayButton.Visible = false;
            DeleteStudentButton.Visible = false;
            SaveButton.Visible = true;
            NewStudentPanel.Visible = true;



        }

        private void FindStudent_Click(object sender, EventArgs e)
        {
            NewStudent.BackColor = Color.White;
            FindStudent.BackColor = Color.Silver;
            NewStudentPanel.Visible = false;
            SaveButton.Visible = false;
            DeleteStudentButton.Visible = true;
            FindStudentPanel.Visible = true;
            DisplayButton.Visible = true;

            StudentDataGridView.DataSource = SaverDB.DisplayStudents();//refresh the database table


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (StudentIDToFindText.Text != "")
            {
                SaverDB.DeleteStudent(Convert.ToInt32(StudentIDToFindText.Text));
                StudentIDToFindText.Text = "";
                StudentDataGridView.DataSource = SaverDB.DisplayStudents();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Some Data input is empty, please fill the ID");
            }
        }
    }
}
