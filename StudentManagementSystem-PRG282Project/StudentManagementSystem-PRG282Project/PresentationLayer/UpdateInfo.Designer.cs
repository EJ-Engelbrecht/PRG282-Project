namespace StudentManagementSystem_PRG282Project.PresentationLayer
{
    partial class UpdateInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.idInput = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.celltxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.DOBtxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.studentIDtxt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(32, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchBtn.Location = new System.Drawing.Point(7, 294);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(119, 42);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // idInput
            // 
            this.idInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idInput.Location = new System.Drawing.Point(50, 240);
            this.idInput.MaxLength = 6;
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(129, 30);
            this.idInput.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idLabel.Location = new System.Drawing.Point(12, 195);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(218, 25);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "Search by Student ID";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(542, 337);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(129, 42);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.courseComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.celltxt);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.addresstxt);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblStudentId);
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.DOBtxt);
            this.groupBox1.Controls.Add(this.lastNametxt);
            this.groupBox1.Controls.Add(this.firstNametxt);
            this.groupBox1.Controls.Add(this.studentIDtxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(266, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 427);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddStudent.Location = new System.Drawing.Point(542, 263);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(129, 42);
            this.btnAddStudent.TabIndex = 21;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // courseComboBox
            // 
            this.courseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Items.AddRange(new object[] {
            "BCOMP",
            "BIT",
            "DIT"});
            this.courseComboBox.Location = new System.Drawing.Point(189, 217);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(323, 33);
            this.courseComboBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(82, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cellphone";
            // 
            // celltxt
            // 
            this.celltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.celltxt.Location = new System.Drawing.Point(189, 304);
            this.celltxt.Name = "celltxt";
            this.celltxt.Size = new System.Drawing.Size(323, 30);
            this.celltxt.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(98, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address";
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addresstxt.Location = new System.Drawing.Point(189, 262);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(323, 30);
            this.addresstxt.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(123, 354);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(65, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(77, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(107, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(77, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStudentId.Location = new System.Drawing.Point(79, 48);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(104, 25);
            this.lblStudentId.TabIndex = 6;
            this.lblStudentId.Text = "Student ID";
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailtxt.Location = new System.Drawing.Point(189, 347);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.ReadOnly = true;
            this.emailtxt.Size = new System.Drawing.Size(323, 30);
            this.emailtxt.TabIndex = 10;
            // 
            // DOBtxt
            // 
            this.DOBtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DOBtxt.Location = new System.Drawing.Point(189, 171);
            this.DOBtxt.Name = "DOBtxt";
            this.DOBtxt.Size = new System.Drawing.Size(323, 30);
            this.DOBtxt.TabIndex = 9;
            // 
            // lastNametxt
            // 
            this.lastNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lastNametxt.Location = new System.Drawing.Point(189, 129);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(323, 30);
            this.lastNametxt.TabIndex = 8;
            // 
            // firstNametxt
            // 
            this.firstNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstNametxt.Location = new System.Drawing.Point(189, 87);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(323, 30);
            this.firstNametxt.TabIndex = 7;
            // 
            // studentIDtxt
            // 
            this.studentIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.studentIDtxt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.studentIDtxt.Location = new System.Drawing.Point(189, 45);
            this.studentIDtxt.Name = "studentIDtxt";
            this.studentIDtxt.ReadOnly = true;
            this.studentIDtxt.Size = new System.Drawing.Size(323, 30);
            this.studentIDtxt.TabIndex = 6;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(132, 294);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(119, 42);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.Location = new System.Drawing.Point(7, 580);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(129, 42);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Return";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(987, 645);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(105, 384);
            this.Name = "UpdateInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateInfo";
            this.Load += new System.EventHandler(this.UpdateInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public  System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Label idLabel;
        public  System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        public  System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox DOBtxt;
        private System.Windows.Forms.TextBox lastNametxt;
        private System.Windows.Forms.TextBox firstNametxt;
        public  System.Windows.Forms.TextBox studentIDtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox celltxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button backBtn;
        public  System.Windows.Forms.ComboBox courseComboBox;
        public  System.Windows.Forms.Button btnAddStudent;
        public  System.Windows.Forms.Label lblEmail;
        public  System.Windows.Forms.Label lblStudentId;
    }
}