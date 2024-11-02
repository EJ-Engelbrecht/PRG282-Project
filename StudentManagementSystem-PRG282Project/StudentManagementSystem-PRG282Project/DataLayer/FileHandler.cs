using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data;

namespace StudentManagementSystem_PRG282Project.DataLayer
{
    internal class FileHandler
    {
        public string path = @"students.txt";
        public List<Student> students = new List<Student>();
        


        public void TestFile()
        {
            if (File.Exists(path))
            {
                MessageBox.Show("I exist");
            }
        }

        public void Reader()
        {
            students = new List<Student>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lines = line.Split(',');
                        Student StudentRead = new Student(int.Parse(lines[0]), lines[1], lines[2], DateTime.Parse(lines[3]), lines[4], lines[5], lines[6], lines[7]);
                        students.Add(StudentRead);
                        
                    }

                }
            }
        }

        //public void DataTableDisplay(DataGridView datagridview1)
        //{
        //    DataTable table = new DataTable();

        //    using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        //    {
        //        using (StreamReader sr = new StreamReader(fs))
        //        {
        //            string line;
        //            bool columnsAdded = false;

        //            while ((line = sr.ReadLine()) != null)
        //            {
        //                string[] LineArr = line.Split(',');
        //                if (columnsAdded == false)
        //                {
        //                    table.Columns.Add("Student ID");
        //                    table.Columns.Add("First Name");
        //                    table.Columns.Add("Last Name");
        //                    table.Columns.Add("Date Of Birth");
        //                    table.Columns.Add("Email");
        //                    table.Columns.Add("Course");
        //                    table.Columns.Add("Address");
        //                    table.Columns.Add("Cellphone No.");
        //                    columnsAdded = true;
        //                }

        //                table.Rows.Add(LineArr);
        //            }

        //        }
        //    }
        //    datagridview1.DataSource = table;
        //}

        public void DataTableDisplay(DataTable table, DataGridView dataGridView)
        {
            Reader();
            table.Columns.Add("StudentID", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Date of Birth", typeof(DateTime));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Course", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("CellNum", typeof(string));
            foreach (Student student in students)
            {
                table.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.DateOfBirth, student.Email, student.Course, student.Address, student.CellNum);
            }
            dataGridView.DataSource = table;
        }


    }
}
