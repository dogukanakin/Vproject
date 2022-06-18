
namespace Vproject
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnCourseCreation = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmBxCourse = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmBxId = new System.Windows.Forms.ComboBox();
            this.dtGridPayment = new System.Windows.Forms.DataGridView();
            this.cmBxAmount = new System.Windows.Forms.ComboBox();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.cmbTaksit = new System.Windows.Forms.ComboBox();
            this.lblAylik = new System.Windows.Forms.Label();
            this.txtBxTutar = new System.Windows.Forms.TextBox();
            this.btnTaksit = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cmBxStudentName = new System.Windows.Forms.ComboBox();
            this.pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPayment)).BeginInit();
            this.SuspendLayout();
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
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPayment.Controls.Add(this.btnReport);
            this.pnlPayment.Controls.Add(this.btnPayment);
            this.pnlPayment.Controls.Add(this.btnAssignment);
            this.pnlPayment.Controls.Add(this.btnCourseCreation);
            this.pnlPayment.Controls.Add(this.btnTeacher);
            this.pnlPayment.Controls.Add(this.btnStudent);
            this.pnlPayment.Location = new System.Drawing.Point(2, -1);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(797, 127);
            this.pnlPayment.TabIndex = 17;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(16, 177);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(94, 20);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Student Id";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourse.Location = new System.Drawing.Point(16, 279);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(66, 20);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.Location = new System.Drawing.Point(16, 321);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 20);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // cmBxCourse
            // 
            this.cmBxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxCourse.FormattingEnabled = true;
            this.cmBxCourse.Location = new System.Drawing.Point(205, 276);
            this.cmBxCourse.Name = "cmBxCourse";
            this.cmBxCourse.Size = new System.Drawing.Size(200, 28);
            this.cmBxCourse.TabIndex = 9;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPay.Location = new System.Drawing.Point(311, 462);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(94, 74);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(651, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 78);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmBxId
            // 
            this.cmBxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxId.FormattingEnabled = true;
            this.cmBxId.Location = new System.Drawing.Point(205, 177);
            this.cmBxId.Name = "cmBxId";
            this.cmBxId.Size = new System.Drawing.Size(200, 28);
            this.cmBxId.TabIndex = 6;
            // 
            // dtGridPayment
            // 
            this.dtGridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPayment.Location = new System.Drawing.Point(442, 177);
            this.dtGridPayment.Name = "dtGridPayment";
            this.dtGridPayment.Size = new System.Drawing.Size(336, 207);
            this.dtGridPayment.TabIndex = 15;
            this.dtGridPayment.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridPayment_CellEnter);
            // 
            // cmBxAmount
            // 
            this.cmBxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxAmount.FormattingEnabled = true;
            this.cmBxAmount.Location = new System.Drawing.Point(205, 318);
            this.cmBxAmount.Name = "cmBxAmount";
            this.cmBxAmount.Size = new System.Drawing.Size(200, 28);
            this.cmBxAmount.TabIndex = 10;
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksit.Location = new System.Drawing.Point(16, 371);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(109, 20);
            this.lblTaksit.TabIndex = 3;
            this.lblTaksit.Text = "Taksit Sayısı";
            // 
            // cmbTaksit
            // 
            this.cmbTaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTaksit.FormattingEnabled = true;
            this.cmbTaksit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbTaksit.Location = new System.Drawing.Point(205, 361);
            this.cmbTaksit.Name = "cmbTaksit";
            this.cmbTaksit.Size = new System.Drawing.Size(200, 28);
            this.cmbTaksit.TabIndex = 11;
            // 
            // lblAylik
            // 
            this.lblAylik.AutoSize = true;
            this.lblAylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylik.Location = new System.Drawing.Point(16, 416);
            this.lblAylik.Name = "lblAylik";
            this.lblAylik.Size = new System.Drawing.Size(166, 20);
            this.lblAylik.TabIndex = 3;
            this.lblAylik.Text = "Aylık Ödeme Miktarı";
            // 
            // txtBxTutar
            // 
            this.txtBxTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxTutar.Location = new System.Drawing.Point(205, 410);
            this.txtBxTutar.Name = "txtBxTutar";
            this.txtBxTutar.Size = new System.Drawing.Size(200, 26);
            this.txtBxTutar.TabIndex = 12;
            // 
            // btnTaksit
            // 
            this.btnTaksit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaksit.FlatAppearance.BorderSize = 0;
            this.btnTaksit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaksit.Location = new System.Drawing.Point(205, 462);
            this.btnTaksit.Name = "btnTaksit";
            this.btnTaksit.Size = new System.Drawing.Size(94, 74);
            this.btnTaksit.TabIndex = 12;
            this.btnTaksit.Text = "Calculate";
            this.btnTaksit.UseVisualStyleBackColor = false;
            this.btnTaksit.Click += new System.EventHandler(this.btnTaksit_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.Location = new System.Drawing.Point(16, 235);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(124, 20);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Student Name";
            // 
            // cmBxStudentName
            // 
            this.cmBxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxStudentName.FormattingEnabled = true;
            this.cmBxStudentName.Location = new System.Drawing.Point(205, 227);
            this.cmBxStudentName.Name = "cmBxStudentName";
            this.cmBxStudentName.Size = new System.Drawing.Size(200, 28);
            this.cmBxStudentName.TabIndex = 7;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.txtBxTutar);
            this.Controls.Add(this.dtGridPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTaksit);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cmBxStudentName);
            this.Controls.Add(this.cmBxId);
            this.Controls.Add(this.cmbTaksit);
            this.Controls.Add(this.cmBxAmount);
            this.Controls.Add(this.lblAylik);
            this.Controls.Add(this.lblTaksit);
            this.Controls.Add(this.cmBxCourse);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pnlPayment);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.pnlPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnCourseCreation;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmBxCourse;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmBxId;
        private System.Windows.Forms.DataGridView dtGridPayment;
        private System.Windows.Forms.ComboBox cmBxAmount;
        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.ComboBox cmbTaksit;
        private System.Windows.Forms.Label lblAylik;
        private System.Windows.Forms.TextBox txtBxTutar;
        private System.Windows.Forms.Button btnTaksit;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.ComboBox cmBxStudentName;
    }
}