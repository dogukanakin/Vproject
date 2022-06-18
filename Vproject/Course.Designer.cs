
namespace Vproject
{
    partial class Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.btnCourseCreation = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBxCourse = new System.Windows.Forms.TextBox();
            this.txtBxFee = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseFee = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.dtTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.pnlCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCreate
            // 
            this.pnlCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCreate.Controls.Add(this.btnReport);
            this.pnlCreate.Controls.Add(this.btnPayment);
            this.pnlCreate.Controls.Add(this.btnAssignment);
            this.pnlCreate.Controls.Add(this.btnCourseCreation);
            this.pnlCreate.Controls.Add(this.btnTeacher);
            this.pnlCreate.Controls.Add(this.btnStudent);
            this.pnlCreate.Location = new System.Drawing.Point(2, 16);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(797, 127);
            this.pnlCreate.TabIndex = 13;
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(636, 455);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 82);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(212, 455);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(177, 49);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBxCourse
            // 
            this.txtBxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxCourse.Location = new System.Drawing.Point(212, 253);
            this.txtBxCourse.Name = "txtBxCourse";
            this.txtBxCourse.Size = new System.Drawing.Size(177, 26);
            this.txtBxCourse.TabIndex = 7;
            // 
            // txtBxFee
            // 
            this.txtBxFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxFee.Location = new System.Drawing.Point(212, 304);
            this.txtBxFee.Name = "txtBxFee";
            this.txtBxFee.Size = new System.Drawing.Size(177, 26);
            this.txtBxFee.TabIndex = 8;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourseName.Location = new System.Drawing.Point(30, 253);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(122, 20);
            this.lblCourseName.TabIndex = 14;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseFee
            // 
            this.lblCourseFee.AutoSize = true;
            this.lblCourseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourseFee.Location = new System.Drawing.Point(30, 304);
            this.lblCourseFee.Name = "lblCourseFee";
            this.lblCourseFee.Size = new System.Drawing.Size(40, 20);
            this.lblCourseFee.TabIndex = 15;
            this.lblCourseFee.Text = "Fee";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStart.Location = new System.Drawing.Point(30, 355);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(145, 20);
            this.lblStart.TabIndex = 15;
            this.lblStart.Text = "CourseStartDate";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.Location = new System.Drawing.Point(30, 402);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(153, 20);
            this.lblFinish.TabIndex = 15;
            this.lblFinish.Text = "CourseFinishDate";
            // 
            // dtTimeStart
            // 
            this.dtTimeStart.Location = new System.Drawing.Point(212, 354);
            this.dtTimeStart.Name = "dtTimeStart";
            this.dtTimeStart.Size = new System.Drawing.Size(177, 20);
            this.dtTimeStart.TabIndex = 9;
            // 
            // dtTimeFinish
            // 
            this.dtTimeFinish.Location = new System.Drawing.Point(212, 402);
            this.dtTimeFinish.Name = "dtTimeFinish";
            this.dtTimeFinish.Size = new System.Drawing.Size(177, 20);
            this.dtTimeFinish.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 176);
            this.dataGridView1.TabIndex = 21;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(30, 199);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(82, 20);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "CourseId";
            // 
            // txtBxId
            // 
            this.txtBxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxId.Location = new System.Drawing.Point(212, 199);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.Size = new System.Drawing.Size(177, 26);
            this.txtBxId.TabIndex = 6;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtTimeFinish);
            this.Controls.Add(this.dtTimeStart);
            this.Controls.Add(this.pnlCreate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBxCourse);
            this.Controls.Add(this.txtBxId);
            this.Controls.Add(this.txtBxFee);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblCourseFee);
            this.Name = "Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course2_Load);
            this.pnlCreate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnCourseCreation;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBxCourse;
        private System.Windows.Forms.TextBox txtBxFee;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseFee;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.DateTimePicker dtTimeStart;
        private System.Windows.Forms.DateTimePicker dtTimeFinish;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtBxId;
    }
}