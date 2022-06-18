
namespace Vproject
{
    partial class RegistrationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPanel));
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.btnCourseCreation = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.pnlRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRegistration.Controls.Add(this.btnReport);
            this.pnlRegistration.Controls.Add(this.btnPayment);
            this.pnlRegistration.Controls.Add(this.btnAssignment);
            this.pnlRegistration.Controls.Add(this.btnCourseCreation);
            this.pnlRegistration.Controls.Add(this.btnTeacher);
            this.pnlRegistration.Controls.Add(this.btnStudent);
            this.pnlRegistration.Location = new System.Drawing.Point(2, 0);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(797, 127);
            this.pnlRegistration.TabIndex = 6;
            this.pnlRegistration.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(582, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(113, 127);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.Location = new System.Drawing.Point(469, 0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(113, 127);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnAssignment
            // 
            this.btnAssignment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAssignment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAssignment.FlatAppearance.BorderSize = 0;
            this.btnAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAssignment.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignment.Image")));
            this.btnAssignment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAssignment.Location = new System.Drawing.Point(356, 0);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(113, 127);
            this.btnAssignment.TabIndex = 3;
            this.btnAssignment.Text = "Course Assignment";
            this.btnAssignment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssignment.UseVisualStyleBackColor = false;
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);
            // 
            // btnCourseCreation
            // 
            this.btnCourseCreation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCourseCreation.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCourseCreation.FlatAppearance.BorderSize = 0;
            this.btnCourseCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCourseCreation.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseCreation.Image")));
            this.btnCourseCreation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCourseCreation.Location = new System.Drawing.Point(237, 0);
            this.btnCourseCreation.Name = "btnCourseCreation";
            this.btnCourseCreation.Size = new System.Drawing.Size(119, 127);
            this.btnCourseCreation.TabIndex = 2;
            this.btnCourseCreation.Text = "Course Creation";
            this.btnCourseCreation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCourseCreation.UseVisualStyleBackColor = false;
            this.btnCourseCreation.Click += new System.EventHandler(this.btnCourseCreation_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeacher.Location = new System.Drawing.Point(118, 0);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(119, 127);
            this.btnTeacher.TabIndex = 1;
            this.btnTeacher.Text = "Teacher Registration";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudent.Location = new System.Drawing.Point(0, 0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(118, 127);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Student Registration";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // picBoxMain
            // 
            this.picBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMain.Image")));
            this.picBoxMain.Location = new System.Drawing.Point(2, 133);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(797, 429);
            this.picBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMain.TabIndex = 1;
            this.picBoxMain.TabStop = false;
            this.picBoxMain.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RegistrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.picBoxMain);
            this.Controls.Add(this.pnlRegistration);
            this.Name = "RegistrationPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationPanel";
            this.pnlRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnCourseCreation;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.PictureBox picBoxMain;
    }
}