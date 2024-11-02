using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace StudentManagementSystem_PRG282Project.DataLayer
{
    internal class FileHandler
    {
        string path = @"students.txt";
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
            //Test Display
            foreach (var item in students)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}
