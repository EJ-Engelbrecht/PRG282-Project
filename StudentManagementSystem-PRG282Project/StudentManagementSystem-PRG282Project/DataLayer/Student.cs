using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_PRG282Project.DataLayer
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Address { get; set; }
        public string CellNum { get; set; }

        public Student(int studentID, string firstname, string lastname, DateTime dateofbirth, string email, string course, string address, string cellnum) 
        {
            StudentID = studentID;
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
            Email = email;
            Course = course;
            Address = address;
            CellNum = cellnum;
        }

        public override string ToString()
        {
            return $"Student ID: {StudentID}\nFirst Name: {FirstName}Last Name: {LastName}\nDate of Birth: {DateOfBirth}\nEmail: {Email}\nCourse: {Course}\nAddress: {Address}\nCell Number: {CellNum}";

        }

        public string txtString()
        {
            return $"{StudentID},{FirstName},{LastName},{DateOfBirth},{Email},{Course},{Address},{CellNum}";
        }
    }
}
