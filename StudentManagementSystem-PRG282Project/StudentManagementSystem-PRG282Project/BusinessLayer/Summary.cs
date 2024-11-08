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
          
       
        public Summary()
        {
        }
        public string CreateSummary( List<Student> students)//Values are passed back to the caller ///add list here
        {
         
            return $"Total students: {students.Count()} Average age: {students.Average(s => DateTime.Now.Year - s.DateOfBirth.Year)}"; 
        }

     
    }
}

