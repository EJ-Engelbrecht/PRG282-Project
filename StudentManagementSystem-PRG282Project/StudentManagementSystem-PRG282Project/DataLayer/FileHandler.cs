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
        //public path to students.txt
        public string path = @"students.txt";

        //Public List of Object Student 
        public List<Student> students = new List<Student>();

        //===================================================================
        //Populating List students
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

        //===================================================================
        //Deleting a Student
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

        //===================================================================

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

        //===================================================================
        //Updating a Student's Details
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

        //===================================================================

        //===================================================================
        //Writing Summary File
        public void WriteToSummaryFile() //put in fh
        {
         string path = @"summary.txt";
         Summary summary = new Summary();
           
            Reader();


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

        //===================================================================

        //===================================================================
        //Checking if id is unique
        //This method gets the current highest student number for the same and year 
        public int GetMax(char course)
        {
            int max = 1;
            int date = DateTime.Now.Year-1964;
            Reader();
            foreach (Student student in students)
            {
                int year = Convert.ToInt32(student.StudentID.ToString().Substring(0, 2));
                Console.WriteLine(year);
                //Checks if the date and course are the same (aka the first 3 digits of the studentID)
                char Digit3= student.StudentID.ToString()[2];
                Console.WriteLine(Digit3);
                if ( Digit3 == course && year==date) 
                {
                    //Get the highest number from the last 3 digits
                    int temp = student.StudentID - (year * 10000) - (Convert.ToInt32(Digit3.ToString()) * 1000);
                    max = Math.Max(max, temp);
                    Console.WriteLine("Student"+student.StudentID);
                    Console.WriteLine("Max"+ max);
                    Console.WriteLine("Temp"+temp);
                }
            }

            return max+1;
        }


    }
}
