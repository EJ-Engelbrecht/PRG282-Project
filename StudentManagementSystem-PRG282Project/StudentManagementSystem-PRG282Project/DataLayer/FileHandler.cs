using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentManagementSystem_PRG282Project.DataLayer
{
    internal class FileHandler
    {
        string path = @"students.txt";

        public void TestFile()
        {
            if (File.Exists(path))
            {
                MessageBox.Show("I exist");
            }
        }
    }
}
