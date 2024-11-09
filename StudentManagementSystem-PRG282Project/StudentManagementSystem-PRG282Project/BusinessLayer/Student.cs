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

        public static int NewID(string course)
        {
            int max = 1;
            string year = Convert.ToString(DateTime.Now.Year - 1964);
            FileHandler fhl = new FileHandler();
            switch (course)
            {
                case "BCOMP": 
                    year += "1" ;
                    max = fhl.GetMax('1');
                    break;

                case "BIT":
                    year += "2";
                    max = fhl.GetMax('2');
                    break;

                case "DIT":
                    year += "3";
                    max = fhl.GetMax('3');
                    break;
            }

            // potentially get the last line of  the text file
            if (max < 10)
            {
                year += "00" + Convert.ToString(max);
            }
            else if (max < 99)
            {
                year += "0" + Convert.ToString(max);

            }
            else
            {
                year += Convert.ToString(max);
            }

            return Convert.ToInt32(year);

        }

        public static string NewEmail(int studentId)
        {
            string email = Convert.ToString(studentId)+ "@student.belgiumcampus.ac.za";
            return email;
        }

    }
}
