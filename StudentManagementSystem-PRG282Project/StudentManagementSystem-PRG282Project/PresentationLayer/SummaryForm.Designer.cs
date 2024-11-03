namespace StudentManagementSystem_PRG282Project.PresentationLayer
{
    partial class SummaryForm
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
            this.totalLbl = new System.Windows.Forms.Label();
            this.avgAgeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(53, 65);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(91, 29);
            this.totalLbl.TabIndex = 0;
            this.totalLbl.Text = "totalLbl";
            // 
            // avgAgeLbl
            // 
            this.avgAgeLbl.AutoSize = true;
            this.avgAgeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgAgeLbl.Location = new System.Drawing.Point(53, 131);
            this.avgAgeLbl.Name = "avgAgeLbl";
            this.avgAgeLbl.Size = new System.Drawing.Size(84, 29);
            this.avgAgeLbl.TabIndex = 1;
            this.avgAgeLbl.Text = "avgLbl";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avgAgeLbl);
            this.Controls.Add(this.totalLbl);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label avgAgeLbl;
    }
}