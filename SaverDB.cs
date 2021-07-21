using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    static class SaverDB
    {
        private static string DBProvider = ConfigurationManager.AppSettings["provider"];

        private static string DBConnectionString = ConfigurationManager.AppSettings["connection"];

        private static DbProviderFactory pf = DbProviderFactories.GetFactory(DBProvider);

        private static DbConnection connection;

        public static bool AddRecord(string Name, int Age)
        {
            using (connection = pf.CreateConnection())
            {
                if (connection != null)
                {
                    connection.ConnectionString = DBConnectionString;

                    connection.Open();


                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Connection Failed");
                    throw new Exception("");
                }

                DbCommand command = pf.CreateCommand();

                if (command != null)
                {

                    try
                    {
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO StudentInfo(Name, Age, RegistrationDate) VALUES ( \'{Name}\', {Age}, \'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\')";
                        command.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Added Successfully");
                    }
                    catch (SqlException e)
                    {
                        if (e.Number == 2627)
                        {
                            System.Windows.Forms.MessageBox.Show("ID is taken");
                            return false;
                        }
                        else if(e.Number == 2628)
                        {
                            System.Windows.Forms.MessageBox.Show("Long name");
                        }
                        else
                        {
                            throw e;
                        }
                    }
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Command Failed");
                    return false;
                }

            }
        }

        public static DataTable DisplayStudents()
        {

            using (connection = pf.CreateConnection())
            {
                if (connection != null)
                {
                    connection.ConnectionString = DBConnectionString;

                    connection.Open();


                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Connection Failed");
                    return null;
                }



                DbCommand command = pf.CreateCommand();
                if (command == null)
                {
                    throw new Exception("Creating SQL Command has Failed");
                }
                command.Connection = connection;
                command.CommandText = "Select * From StudentInfo";
                using (DbDataReader dr = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                    //while (dr.Read())
                    //{

                    //    System.Windows.Forms.MessageBox.Show(dr[0] + "  " + dr[1] + "   " + dr[2] + "   " + dr[3]);
                    //}
                }
            }
        }
        public static void DisplayStudents(int ID)
        {
            using (connection = pf.CreateConnection())
            {
                if (connection != null)
                {
                    connection.ConnectionString = DBConnectionString;

                    connection.Open();


                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Connection Failed");
                    return;
                }



                DbCommand command = pf.CreateCommand();
                if (command == null)
                {
                    throw new Exception("Creating SQL Command has Failed");
                }
                command.Connection = connection;
                command.CommandText = $"Select * From StudentInfo where ID = {ID}";

                using (DbDataReader dr = command.ExecuteReader())
                {
                    if (!dr.HasRows)
                    {
                        System.Windows.Forms.MessageBox.Show($"There is no Student with this ID:{ID}");
                        return ;
                    }
                    while (dr.Read())
                    {

                        System.Windows.Forms.MessageBox.Show(dr[0] + "  " + dr[1] + "   " + dr[2] + "   " + dr[3]);
                    }
                }


            }
        }

        public static bool DeleteStudent(int ID)
        {

            using (connection = pf.CreateConnection())
            {
                if (connection != null)
                {
                    connection.ConnectionString = DBConnectionString;

                    connection.Open();


                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Connection Failed");
                    return false;
                }



                DbCommand DeleteCommand = pf.CreateCommand();
                DbCommand GetStudentCommand = pf.CreateCommand();

                if (DeleteCommand == null || GetStudentCommand == null)
                {
                    throw new Exception("Creating SQL Command has Failed");
                }
                DeleteCommand.Connection = connection;
                DeleteCommand.CommandText = $"Delete From StudentInfo where ID = {ID}";

                GetStudentCommand.Connection = connection;
                GetStudentCommand.CommandText = $"Select * from StudentInfo where ID = {ID}";

                using (DbDataReader dr = GetStudentCommand.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        DialogResult dr1 = System.Windows.Forms.MessageBox.Show($"Do you want to delete Student with ID : {ID}", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr1 == DialogResult.Yes)
                        {
                            DeleteCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show($"There is no Student with this ID: {ID}");
                    }
                }

                



                

            }

            return true;
        }
    }



}




