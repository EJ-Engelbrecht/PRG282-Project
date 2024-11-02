﻿using StudentManagementSystem_PRG282Project.BusinessLayer;
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
            fileHandler.Reader();
            table.Columns.Add("StudentID", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Date of Birth", typeof(DateTime));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Course", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("CellNum", typeof(string));
            foreach (Student student in fileHandler.students)
            {
                table.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.DateOfBirth, student.Email, student.Course, student.Address, student.CellNum);
            }
            dataGridView1.DataSource = table;

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int idSearch = int.Parse(idInput.Text);

                bool found = false;
                foreach (Student student in fileHandler.students)
                {
                    if (student.StudentID == idSearch)
                    {
                        table.Rows.Clear();
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

            Student editStudent = new Student(int.Parse(studentIDtxt.Text), firstNametxt.Text, lastNametxt.Text, DateTime.Parse(DOBtxt.Text), emailtxt.Text, coursetxt.Text, addresstxt.Text, celltxt.Text);

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
                coursetxt.Text = row.Cells[5].Value.ToString();
                addresstxt.Text = row.Cells[6].Value.ToString();
                celltxt.Text = row.Cells[7].Value.ToString();

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            foreach (Student student in fileHandler.students)
            {
                table.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.DateOfBirth, student.Email, student.Course, student.Address, student.CellNum);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
    }
}