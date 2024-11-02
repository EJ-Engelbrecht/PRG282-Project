using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_PRG282Project.DataLayer
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string CellNum { get; set; }

        public Student(int studentID, string firstname, string lastname, DateTime dateofbirth, string email, string course, string cellnum) 
        {
            StudentID = studentID;
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
            Email = email;
            Course = course;
            CellNum = cellnum;
        }
    }
}
