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
    public partial class ViewAllForm : Form
    {
        public ViewAllForm()
        {
            InitializeComponent();
        }

        FileHandler fs = new FileHandler();
        DataTable dt = new DataTable();

        //use the display method from the filehandler class

        public void LoadStudentData()
        {
            fs.DataTableDisplay(dt, dataGridView1);
        }

        private void ViewAllForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }
    }
}
