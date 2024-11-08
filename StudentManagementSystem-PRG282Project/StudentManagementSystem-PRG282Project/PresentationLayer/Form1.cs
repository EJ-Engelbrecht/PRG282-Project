using StudentManagementSystem_PRG282Project.BusinessLayer;
using StudentManagementSystem_PRG282Project.DataLayer;
using StudentManagementSystem_PRG282Project.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_PRG282Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.viewAllStudents = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.updateStudent = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.generateReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllStudents
            // 
            this.viewAllStudents.BackColor = System.Drawing.Color.SteelBlue;
            this.viewAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllStudents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewAllStudents.Location = new System.Drawing.Point(105, 226);
            this.viewAllStudents.Name = "viewAllStudents";
            this.viewAllStudents.Size = new System.Drawing.Size(126, 53);
            this.viewAllStudents.TabIndex = 0;
            this.viewAllStudents.Text = "View all students";
            this.viewAllStudents.UseVisualStyleBackColor = false;
            this.viewAllStudents.Click += new System.EventHandler(this.viewAllStudents_Click);
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addStudent.Location = new System.Drawing.Point(105, 308);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(126, 52);
            this.addStudent.TabIndex = 1;
            this.addStudent.Text = "Add student";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // updateStudent
            // 
            this.updateStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.updateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateStudent.Location = new System.Drawing.Point(105, 384);
            this.updateStudent.Name = "updateStudent";
            this.updateStudent.Size = new System.Drawing.Size(126, 50);
            this.updateStudent.TabIndex = 2;
            this.updateStudent.Text = "Update student";
            this.updateStudent.UseVisualStyleBackColor = false;
            this.updateStudent.Click += new System.EventHandler(this.updateStudent_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteStudent.Location = new System.Drawing.Point(105, 462);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(126, 50);
            this.deleteStudent.TabIndex = 3;
            this.deleteStudent.Text = "Delete student";
            this.deleteStudent.UseVisualStyleBackColor = false;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // generateReport
            // 
            this.generateReport.BackColor = System.Drawing.Color.SteelBlue;
            this.generateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateReport.Location = new System.Drawing.Point(105, 543);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(126, 48);
            this.generateReport.TabIndex = 4;
            this.generateReport.Text = "Summary report";
            this.generateReport.UseVisualStyleBackColor = false;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::StudentManagementSystem_PRG282Project.Properties.Resources.CustomerHappiness__4_;
            this.pictureBox1.Location = new System.Drawing.Point(679, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::StudentManagementSystem_PRG282Project.Properties.Resources.CustomerHappiness__1_;
            this.pictureBox2.Location = new System.Drawing.Point(246, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(403, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(928, 639);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.updateStudent);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.viewAllStudents);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Just to test connection to students.txt
            //FileHandler fh = new FileHandler();
            //fh.TestFile();
            //fh.Reader();
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm DF = new DeleteForm();
            DF.FormClosed += (s, args) => this.Show(); // Show the main form when DeleteForm is closed
            DF.Show(); // Open DeleteForm as a modal dialog
        }


        private void updateStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var updateInfoForm = new UpdateInfo();
            updateInfoForm.Closed += (s, args) => this.Show();
            updateInfoForm.btnAddStudent.Visible = false;
            updateInfoForm.Show();
        }

        private void viewAllStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            var viewAllForm= new ViewAllForm();
            viewAllForm.Closed += (s, args) => this.Show();
            viewAllForm.ShowDialog();
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Closed += (s, args) => this.Show();
            summaryForm.ShowDialog();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateInfo updateInfo = new UpdateInfo();
            updateInfo.updateBtn.Visible = false;
            updateInfo.studentIDtxt.Visible = false;
            updateInfo.lblStudentId.Visible = false;
            updateInfo.emailtxt.Visible = false;
            updateInfo.lblEmail.Visible = false;
            updateInfo.Closed += (s, args) => this.Show();

            updateInfo.Show();
        }

        //private void viewAllStudents_Click(object sender, EventArgs e)
        //{

        //}
    }
}
