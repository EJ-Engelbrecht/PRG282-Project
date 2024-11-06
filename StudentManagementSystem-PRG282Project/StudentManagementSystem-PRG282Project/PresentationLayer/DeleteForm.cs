﻿using StudentManagementSystem_PRG282Project.BusinessLayer;
using StudentManagementSystem_PRG282Project.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_PRG282Project.PresentationLayer
{
    public partial class DeleteForm : Form
    {
        FileHandler fh = new FileHandler();
        DeleteButton Delete = new DeleteButton();
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete a student?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Delete.DeleteRecordFromFile(dataGridView1.CurrentRow.Index, dataGridView1);
                MessageBox.Show("Student has been removed.");

            }
            else
            {
                MessageBox.Show("Canceled Deletion");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close DeleteForm
        }

        DataTable table = new DataTable();
        private void DeleteForm_Load(object sender, EventArgs e)
        {
            fh.DataTableDisplay(table,dataGridView1);
        }
    }
}
