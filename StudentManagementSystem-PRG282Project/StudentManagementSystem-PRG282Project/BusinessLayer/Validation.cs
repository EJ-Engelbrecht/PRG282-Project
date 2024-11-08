using StudentManagementSystem_PRG282Project.DataLayer;
using StudentManagementSystem_PRG282Project.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagementSystem_PRG282Project.BusinessLayer
{
    internal class Validation
    {
        public bool ValidateStudent(string name, string surname, string dob, string course, string address, string cellno)
        {
            if (ValidName(name, "name") && ValidName(surname, "surname") && ValidDob(dob) && ValidCourse(course) && ValidAddress(address) && ValidCellno(cellno))
            {
                return true;
            }
            else { return false; }
        }

        public bool ValidName(string name, string firstOrLast)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$"; // Regular Expression Function to validate the name
            if (Regex.IsMatch(name, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{name} is an invalid {firstOrLast} (Ensure {firstOrLast} begins with a capital letter and contains only letters)", //Text on the message box
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Styling for the MessageBox

                return false;
            }
        }

        public bool ValidDob(string dob)
        {
            DateTime dateOb = new DateTime();

            string pattern = "^([0-9]{4}[/](0[1-9]|[1][0-2]){1}[/](0[1-9]|[12][0-9]|3[01]){1})$"; // Regular Expression Function to validate the date format
            if (Regex.IsMatch(dob, pattern))
            {
                dateOb = DateTime.Parse(dob);
            }
            else
            {
                MessageBox.Show($"{dob} is an invalid date (Ensure the format is yyyy/mm/dd)", //Text on the message box
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Styling for the MessageBox

                return false;
            }
            int age = DateTime.Now.Year-dateOb.Year;
            if (age >= 16 && age<=65)
            {
                return true ;
            }
            else
            {
                MessageBox.Show($"The student is {age} this year and does not meet the age requirement (between 16 and 65)", //The student must be between the ages of 16 and 65
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Styling for the MessageBox

                return false;
            }


        }

        public bool ValidCourse(string course)
        {
            UpdateInfo updateInfo = new UpdateInfo();
            if (updateInfo.courseComboBox.Items.Contains(course))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{course} is not a valid course. Please select a valid course", //The student must be between the ages of 16 and 65
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Styling for the MessageBox

                return false;
            }
        }

        public bool ValidAddress(string address)
        {
            if (address != null && address != string.Empty)
            {
                return true ;
            }
            else
            {
                MessageBox.Show("Pleas fill in an address", //Text on the message box
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Styling for the MessageBox

                return false;
            }

        }

        public bool ValidCellno(string cell)
        {
            string pattern = "^(\\+27|0)[0-9]{9}$"; // Regular Expression Function to validate the cell phone digits
            if (Regex.IsMatch(cell, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{cell} is an invalid South African number (only enter +27 followed by 9 digits or 0 followed by 9 digits)", //Only has validation for South African numbers
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Styling for the MessageBox

                return false;
            }
        }


    }
}
