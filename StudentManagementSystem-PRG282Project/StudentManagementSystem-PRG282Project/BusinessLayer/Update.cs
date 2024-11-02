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
    public class Update
    {
        FileHandler fileHandler = new FileHandler();
        public void updateStudent(Student student)
        {



            string tempStudentTxt = Path.GetTempFileName();

            using (var sr = new StreamReader(fileHandler.path))
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

            File.Delete(fileHandler.path);
            File.Move(tempStudentTxt, fileHandler.path);


        }
    }
}
