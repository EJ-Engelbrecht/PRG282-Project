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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();

        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            Summary summary = new Summary();

            int totalStudents;
            double avgAge;

            summary.CreateSummary(out totalStudents, out avgAge);

            totalLbl.Text = $"Total Students: {totalStudents}";
            avgAgeLbl.Text = $"Average Age: {avgAge:F2}";

            summary.WriteToSummaryFile();
        }
    }
}
