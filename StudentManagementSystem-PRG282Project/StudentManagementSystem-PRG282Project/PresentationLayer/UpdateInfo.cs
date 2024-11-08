using StudentManagementSystem_PRG282Project.BusinessLayer;
using StudentManagementSystem_PRG282Project.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_PRG282Project.PresentationLayer
{
    public partial class UpdateInfo : Form
    {
        //New FileHandler Object And DataTabkle object
        FileHandler fileHandler = new FileHandler();
        DataTable table = new DataTable();
        public UpdateInfo()
        {
            InitializeComponent();
        }

        //When form is loaded, initailize the datatable and adds the values from the text file
        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            fileHandler.DataTableDisplay(table, dataGridView1);

        }

        //When user clicks the search button, checks the input to ensure it is a valid input, then loops through the existing students, which are stored in the Student list. If a matching Student ID is found, prints the student to the datatable. Works event with incomplete IDs, '60...' etc to check a larger search. Error Message shows if input is invalid or no student was found.
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                table.Rows.Clear();

                int idSearch = int.Parse(idInput.Text);

                bool found = false;
                foreach (Student student in fileHandler.students)
                {
                    if (student.StudentID.ToString().StartsWith(idSearch.ToString()) && idInput.Text != null)
                    {
                        table.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.DateOfBirth, student.Email, student.Course, student.Address, student.CellNum);
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show($"No student found with that ID", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Not a valid Student ID: {ex.Message}", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //When the user clicks the update button, checks whether a row was selected from the datatable, then whatever information is currently in the input boxes, will overwrite the existing information for the selected student. Error messages show incase of no selected student, or an Exception is caught.
        private void updateBtn_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            try
            {
                if (row != null)
                {

                    Student editStudent = new Student(int.Parse(studentIDtxt.Text), firstNametxt.Text, lastNametxt.Text, DateTime.Parse(DOBtxt.Text), emailtxt.Text, courseComboBox.Text, addresstxt.Text, celltxt.Text);

                    fileHandler.updateStudent(editStudent);

                    MessageBox.Show($"Successfully updated Student", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fileHandler.Reader();
                    table.Rows.Clear();
                    ShowTable();
                }
                else
                {
                    MessageBox.Show($"Error while Updating: Please Select A Student From The Table", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while Updating {ex.Message}", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to write the datatable selected cell to the input boes to allow the user to change any information.
        int indexRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            if (row != null)
            {
                studentIDtxt.Text = row.Cells[0].Value.ToString();
                firstNametxt.Text = row.Cells[1].Value.ToString();
                lastNametxt.Text = row.Cells[2].Value.ToString();
                DOBtxt.Text = row.Cells[3].Value.ToString();
                emailtxt.Text = row.Cells[4].Value.ToString();
                courseComboBox.Text = row.Cells[5].Value.ToString();
                addresstxt.Text = row.Cells[6].Value.ToString();
                celltxt.Text = row.Cells[7].Value.ToString();

            }
        }

        //Method to clear and reset the search
        private void clearBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            idInput.Text = "";
            ShowTable();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Student.NewID(courseComboBox.Text);// still need to add check for text file
                string email = Student.NewEmail(Id);
                Validation v = new Validation();
                bool ans = v.ValidateStudent(firstNametxt.Text, lastNametxt.Text, DOBtxt.Text, courseComboBox.Text, addresstxt.Text, celltxt.Text);

                if (ans)
                {
                    Student NewStudent = new Student(Id, firstNametxt.Text, lastNametxt.Text, DateTime.Parse(DOBtxt.Text), email, courseComboBox.Text, addresstxt.Text, celltxt.Text);


                    fileHandler.AddStudent(NewStudent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: \n{ex.Message}", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //UpdateInfo_Load(sender, e); // Need to put method to refresh the table
        }

        //Method to write the exisiting Students to the datatable.
        public void ShowTable()
        {
            foreach (Student student in fileHandler.students)
            {
                table.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.DateOfBirth, student.Email, student.Course, student.Address, student.CellNum);
            }
        }
    }
}
