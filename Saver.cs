using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    
    static class Saver
    {
        public static String Saving_Path = "C:/Users/ADMIN/Desktop/C# docs/StudentData/";
        public static Dictionary<int, String> Data;

        public static bool IsEmpty;
        
        
        

        static Saver() 
        {
            System.Windows.Forms.MessageBox.Show("Intialize");

            FileStream fsIsEmpty;
            StreamReader sr;
            BinaryFormatter bf;

            

            fsIsEmpty = new FileStream(Saving_Path + "IsEmpty.txt", FileMode.OpenOrCreate);


            sr = new StreamReader(fsIsEmpty);

            IsEmpty = bool.Parse(sr.ReadLine());

            fsIsEmpty.Close();

            bf = new BinaryFormatter();
            
            

            if (!IsEmpty)
            {
                FileStream fs;
                fs = new FileStream(Saving_Path + "Data.txt", FileMode.OpenOrCreate);

                Data = (Dictionary<int, String>) bf.Deserialize(fs);
                fs.Close();
            }
            else 
            {
                Data = new Dictionary<int, string>();
            }

            


        }

        public static void DisplayStudents() 
        { 
            foreach(KeyValuePair<int, String> x in Data)
            {
                System.Windows.Forms.MessageBox.Show(x.Key + "  " + x.Value);
            }
        }


        public static bool AddRecord(int ID, String Name)
        {

            try
            {
                Data.Add(ID, Name);

                return true;

            }
            catch (Exception e)
            {
                throw e;

                return false;
            }
        
        }




        public static bool Save() 
        {
            try
            {
                FileStream fs, fsIsEmpty;
                BinaryFormatter bf;
                StreamWriter sw;

                File.WriteAllText(Saving_Path + "Data.txt", "");
                File.WriteAllText(Saving_Path + "IsEmpty.txt", "");

                fs = new FileStream(Saving_Path + "Data.txt", FileMode.Append);
                fsIsEmpty = new FileStream(Saving_Path + "IsEmpty.txt", FileMode.OpenOrCreate);



                bf = new BinaryFormatter();

                bf.Serialize(fs, Data);
                

                IsEmpty = false;

                

                sw = new StreamWriter(fsIsEmpty);
                sw.WriteLine(IsEmpty);

                

                fs.Close();
                sw.Close();

                return true;
            }
            catch (Exception e)
            {

                throw e;
                System.Windows.Forms.MessageBox.Show(e.ToString());
                return false;
            }
        }



    }
}
