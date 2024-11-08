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
        FileHandler fh= new FileHandler();  
        public SummaryForm()
        {
            InitializeComponent();

        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            Summary summary = new Summary();

            fh.Reader();
           string output= summary.CreateSummary(fh.students);

            totalLbl.Text = output;

            fh.WriteToSummaryFile();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
