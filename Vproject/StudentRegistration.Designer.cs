
namespace Vproject
{
    partial class StudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistration));
            this.pnlReg = new System.Windows.Forms.Panel();
            this.cmBxGender = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.rchTxAddress = new System.Windows.Forms.RichTextBox();
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.txtBxContact = new System.Windows.Forms.TextBox();
            this.txtBxFaculty = new System.Windows.Forms.TextBox();
            this.txtBxMail = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.btnCourseCreation = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.dtGridStudent = new System.Windows.Forms.DataGridView();
            this.pnlReg.SuspendLayout();
            this.pnlNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReg
            // 
            this.pnlReg.Controls.Add(this.cmBxGender);
            this.pnlReg.Controls.Add(this.btnUpdate);
            this.pnlReg.Controls.Add(this.btnSave);
            this.pnlReg.Controls.Add(this.btnBack);
            this.pnlReg.Controls.Add(this.dtTimeBirth);
            this.pnlReg.Controls.Add(this.rchTxAddress);
            this.pnlReg.Controls.Add(this.txtBxId);
            this.pnlReg.Controls.Add(this.txtBxContact);
            this.pnlReg.Controls.Add(this.txtBxFaculty);
            this.pnlReg.Controls.Add(this.txtBxMail);
            this.pnlReg.Controls.Add(this.txtBxName);
            this.pnlReg.Controls.Add(this.lblAddress);
            this.pnlReg.Controls.Add(this.lblFaculty);
            this.pnlReg.Controls.Add(this.lblGender);
            this.pnlReg.Controls.Add(this.lblDate);
            this.pnlReg.Controls.Add(this.lblId);
            this.pnlReg.Controls.Add(this.lblContact);
            this.pnlReg.Controls.Add(this.lblMail);
            this.pnlReg.Controls.Add(this.lblName);
            this.pnlReg.Location = new System.Drawing.Point(0, 125);
            this.pnlReg.Name = "pnlReg";
            this.pnlReg.Size = new System.Drawing.Size(797, 398);
            this.pnlReg.TabIndex = 2;
            // 
            // cmBxGender
            // 
            this.cmBxGender.FormattingEnabled = true;
            this.cmBxGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmBxGender.Location = new System.Drawing.Point(469, 43);
            this.cmBxGender.Name = "cmBxGender";
            this.cmBxGender.Size = new System.Drawing.Size(216, 21);
            this.cmBxGender.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(467, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 69);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(582, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 67);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(691, 305);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 81);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtTimeBirth
            // 
            this.dtTimeBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTimeBirth.Location = new System.Drawing.Point(170, 236);
            this.dtTimeBirth.Name = "dtTimeBirth";
            this.dtTimeBirth.Size = new System.Drawing.Size(169, 26);
            this.dtTimeBirth.TabIndex = 10;
            // 
            // rchTxAddress
            // 
            this.rchTxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchTxAddress.Location = new System.Drawing.Point(469, 143);
            this.rchTxAddress.Name = "rchTxAddress";
            this.rchTxAddress.Size = new System.Drawing.Size(217, 96);
            this.rchTxAddress.TabIndex = 13;
            this.rchTxAddress.Text = "";
            // 
            // txtBxId
            // 
            this.txtBxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxId.Location = new System.Drawing.Point(169, 46);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.Size = new System.Drawing.Size(169, 26);
            this.txtBxId.TabIndex = 6;
            // 
            // txtBxContact
            // 
            this.txtBxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxContact.Location = new System.Drawing.Point(170, 197);
            this.txtBxContact.Name = "txtBxContact";
            this.txtBxContact.Size = new System.Drawing.Size(169, 26);
            this.txtBxContact.TabIndex = 9;
            // 
            // txtBxFaculty
            // 
            this.txtBxFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxFaculty.Location = new System.Drawing.Point(469, 93);
            this.txtBxFaculty.Name = "txtBxFaculty";
            this.txtBxFaculty.Size = new System.Drawing.Size(216, 26);
            this.txtBxFaculty.TabIndex = 12;
            // 
            // txtBxMail
            // 
            this.txtBxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxMail.Location = new System.Drawing.Point(170, 151);
            this.txtBxMail.Name = "txtBxMail";
            this.txtBxMail.Size = new System.Drawing.Size(169, 26);
            this.txtBxMail.TabIndex = 8;
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxName.Location = new System.Drawing.Point(170, 100);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(168, 26);
            this.txtBxName.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(372, 143);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaculty.Location = new System.Drawing.Point(372, 93);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(67, 20);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Faculty";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.Location = new System.Drawing.Point(375, 46);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(21, 242);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(112, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date of Birth";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(21, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContact.Location = new System.Drawing.Point(21, 201);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(139, 20);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Contact Number";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(21, 151);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(112, 20);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(21, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name";
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlNavbar.Controls.Add(this.btnReport);
            this.pnlNavbar.Controls.Add(this.btnPayment);
            this.pnlNavbar.Controls.Add(this.btnAssignment);
            this.pnlNavbar.Controls.Add(this.btnCourseCreation);
            this.pnlNavbar.Controls.Add(this.btnTeacher);
            this.pnlNavbar.Controls.Add(this.btnStudent);
            this.pnlNavbar.Location = new System.Drawing.Point(0, 1);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(797, 126);
            this.pnlNavbar.TabIndex = 18;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.Location = new System.Drawing.Point(582, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(113, 126);
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
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPayment.Location = new System.Drawing.Point(469, 0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(113, 126);
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
            this.btnAssignment.Size = new System.Drawing.Size(113, 126);
            this.btnAssignment.TabIndex = 3;
            this.btnAssignment.Text = "Course Assignment";
            this.btnAssignment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssignment.UseVisualStyleBackColor = false;
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
            this.btnCourseCreation.Size = new System.Drawing.Size(119, 126);
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
            this.btnTeacher.Size = new System.Drawing.Size(119, 126);
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
            this.btnStudent.Size = new System.Drawing.Size(118, 126);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Student Registration";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // dtGridStudent
            // 
            this.dtGridStudent.AllowUserToAddRows = false;
            this.dtGridStudent.AllowUserToDeleteRows = false;
            this.dtGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridStudent.Location = new System.Drawing.Point(0, 529);
            this.dtGridStudent.Name = "dtGridStudent";
            this.dtGridStudent.ReadOnly = true;
            this.dtGridStudent.Size = new System.Drawing.Size(769, 161);
            this.dtGridStudent.TabIndex = 17;
            this.dtGridStudent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridStudent_CellEnter);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 702);
            this.Controls.Add(this.dtGridStudent);
            this.Controls.Add(this.pnlReg);
            this.Controls.Add(this.pnlNavbar);
            this.Name = "StudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            this.pnlReg.ResumeLayout(false);
            this.pnlReg.PerformLayout();
            this.pnlNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReg;
        private System.Windows.Forms.DateTimePicker dtTimeBirth;
        private System.Windows.Forms.RichTextBox rchTxAddress;
        private System.Windows.Forms.TextBox txtBxId;
        private System.Windows.Forms.TextBox txtBxContact;
        private System.Windows.Forms.TextBox txtBxMail;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnCourseCreation;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtGridStudent;
        private System.Windows.Forms.TextBox txtBxFaculty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmBxGender;
    }
}