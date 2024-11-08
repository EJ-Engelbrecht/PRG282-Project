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
        FileHandler fileHandler = new FileHandler();
        DataTable table = new DataTable();
        void Display()
        {
        }
        public UpdateInfo()
        {
            InitializeComponent();
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            fileHandler.DataTableDisplay(table, dataGridView1);

        }

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
                    MessageBox.Show("No Student found with that ID");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not a valid Student ID: " + ex.Message);

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Update update = new Update();

            Student editStudent = new Student(int.Parse(studentIDtxt.Text), firstNametxt.Text, lastNametxt.Text, DateTime.Parse(DOBtxt.Text), emailtxt.Text, courseComboBox.Text, addresstxt.Text, celltxt.Text);

            try
            {
                update.updateStudent(editStudent);
                MessageBox.Show("Successfully Updated Student");
                fileHandler.Reader();
                table.Rows.Clear();
                foreach (Student student in fileHandler.students)
                {
                    table.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.DateOfBirth, student.Email, student.Course, student.Address, student.CellNum);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating: " + ex.Message);
            }
        }

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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            idInput.Text = "";
            foreach (Student student in fileHandler.students)
            {
                table.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.DateOfBirth, student.Email, student.Course, student.Address, student.CellNum);
            }
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
                MessageBox.Show("Something went wrong :/\n" + ex);
            }
            


            //UpdateInfo_Load(sender, e); // Need to put method to refresh the table
        }
    }
}
