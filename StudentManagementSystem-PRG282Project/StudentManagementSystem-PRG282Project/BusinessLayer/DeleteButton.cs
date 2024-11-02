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
    public class DeleteButton
    {
        FileHandler fh = new FileHandler();

        public void DeleteRecordFromFile(int rowIndex, DataGridView datagridview1)
        {
            if (rowIndex < 0 || rowIndex >= datagridview1.Rows.Count)
            {
                MessageBox.Show("Invalid row selected.");
                return;
            }

            string tempStudentTxt = Path.GetTempFileName();

            using (var sr = new StreamReader(fh.path))
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

            File.Delete(fh.path);
            File.Move(tempStudentTxt, fh.path);
            datagridview1.Rows.RemoveAt(rowIndex);
        }

    }
}
