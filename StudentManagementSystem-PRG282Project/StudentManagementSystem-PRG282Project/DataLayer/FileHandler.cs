using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data;
using StudentManagementSystem_PRG282Project.BusinessLayer;

namespace StudentManagementSystem_PRG282Project.DataLayer
{
    internal class FileHandler
    {
        public string path = @"students.txt";
        public  List<Student> students = new List<Student>();
        
     

        public void TestFile()
        {
            if (File.Exists(path))
            {
                MessageBox.Show($"File Exists", "File", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //===================================================================
        //Adding a new student
        public void AddStudent(Student student)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Append))
                {
                    using (StreamWriter sr = new StreamWriter(fs))
                    {
                        string StudentInfo = student.txtString();

                        sr.WriteLine(StudentInfo);


                    }

                }
                MessageBox.Show("Student added Successfully", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        //===================================================================


        //Delete Form Code
        public void DeleteRecordFromFile(int rowIndex, DataGridView datagridview1)
        {
            if (rowIndex < 0 || rowIndex >= datagridview1.Rows.Count)
            {
                MessageBox.Show($"Invalid row selected", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tempStudentTxt = Path.GetTempFileName();

            try
            {
                using (var sr = new StreamReader(path))
                using (var sw = new StreamWriter(tempStudentTxt))
                {
                    int rowcounter = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (rowcounter != rowIndex)
                        {
                            sw.WriteLine(line);
                        }
                        rowcounter++;
                    }
                }

                File.Delete(path);
                File.Move(tempStudentTxt, path);
                datagridview1.Rows.RemoveAt(rowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured {ex.Message}", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        public void DataTableDisplay(DataGridView datagridview1)
        {
            DataTable table = new DataTable();

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
        }

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

<<<<<<< Updated upstream
        public void updateStudent(Student student)
        {



            string tempStudentTxt = Path.GetTempFileName();

            using (var sr = new StreamReader(path))
            using (var sw = new StreamWriter(tempStudentTxt))
            {
                int rowcounter = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(',');
                    if (int.Parse(items[0]) != student.StudentID)
                    {
                        sw.WriteLine(line);
                    }
                    else
                    {
                        sw.WriteLine(student.txtString());
                    }
                    rowcounter++;
                }
            }

            File.Delete(path);
            File.Move(tempStudentTxt, path);


        }

=======
        public void WriteToSummaryFile() //put in fh
        {
         string path = @"summary.txt";
         Summary summary = new Summary();
           
            Reader();
>>>>>>> Stashed changes

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(summary.CreateSummary(students)); ///returns a string with total and average
                }
                MessageBox.Show("Summary report written successfully", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to summary file {ex.Message}", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
