using StudentManagementSystem_PRG282Project.DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_PRG282Project.BusinessLayer
{
    public class Summary
    {
        private List<Student> students;  
        private string path = @"summary.txt";
        public Summary()
        {
            LoadStudents(); 
        }

        private void LoadStudents()
        {
            FileHandler handler = new FileHandler();
            handler.Reader(); 
            students = handler.students; // Assign to the student list
        }

        public void CreateSummary(out int totalStudents, out double avgAge)
        {
            totalStudents=students.Count;

            avgAge = totalStudents > 0 ? students.Average(s => DateTime.Now.Year - s.DateOfBirth.Year) : 0; 
        }

        //save the summary to summary.txt file
        public void WriteToSummaryFile()
        {
            int totalStudents;
            double avgAge;

            CreateSummary(out  totalStudents, out avgAge);

            string content = $"Total Students: {totalStudents}{Environment.NewLine}Average Age: {avgAge:F2}";

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(content);
                }
                MessageBox.Show("Summary report written successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to summary file: {ex.Message}");
            }
        }
    }
}

