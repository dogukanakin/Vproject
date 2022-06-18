
namespace Vproject
{
    partial class StudentAssign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAssign));
            this.btnAssign = new System.Windows.Forms.Button();
            this.pnlStuAssign = new System.Windows.Forms.Panel();
            this.cmBxCourse = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmBxStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBxId = new System.Windows.Forms.ComboBox();
            this.dtGridAssign = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBxCoursePrice = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAssign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAssign.Location = new System.Drawing.Point(193, 543);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(134, 50);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // pnlStuAssign
            // 
            this.pnlStuAssign.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlStuAssign.Location = new System.Drawing.Point(1, 2);
            this.pnlStuAssign.Name = "pnlStuAssign";
            this.pnlStuAssign.Size = new System.Drawing.Size(809, 89);
            this.pnlStuAssign.TabIndex = 11;
            // 
            // cmBxCourse
            // 
            this.cmBxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxCourse.FormattingEnabled = true;
            this.cmBxCourse.Location = new System.Drawing.Point(193, 449);
            this.cmBxCourse.Name = "cmBxCourse";
            this.cmBxCourse.Size = new System.Drawing.Size(134, 28);
            this.cmBxCourse.TabIndex = 2;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudent.Location = new System.Drawing.Point(24, 403);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(129, 20);
            this.lblStudent.TabIndex = 5;
            this.lblStudent.Text = "Student Name:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourse.Location = new System.Drawing.Point(24, 454);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(122, 20);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course Name:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(668, 515);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 78);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmBxStudent
            // 
            this.cmBxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxStudent.FormattingEnabled = true;
            this.cmBxStudent.Location = new System.Drawing.Point(193, 403);
            this.cmBxStudent.Name = "cmBxStudent";
            this.cmBxStudent.Size = new System.Drawing.Size(134, 28);
            this.cmBxStudent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID:";
            // 
            // cmBxId
            // 
            this.cmBxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxId.FormattingEnabled = true;
            this.cmBxId.Location = new System.Drawing.Point(193, 350);
            this.cmBxId.Name = "cmBxId";
            this.cmBxId.Size = new System.Drawing.Size(134, 28);
            this.cmBxId.TabIndex = 0;
            // 
            // dtGridAssign
            // 
            this.dtGridAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAssign.Location = new System.Drawing.Point(28, 130);
            this.dtGridAssign.Name = "dtGridAssign";
            this.dtGridAssign.Size = new System.Drawing.Size(760, 192);
            this.dtGridAssign.TabIndex = 14;
            this.dtGridAssign.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAssign_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(255, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Student List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course Price:";
            // 
            // cmBxCoursePrice
            // 
            this.cmBxCoursePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxCoursePrice.FormattingEnabled = true;
            this.cmBxCoursePrice.Location = new System.Drawing.Point(193, 495);
            this.cmBxCoursePrice.Name = "cmBxCoursePrice";
            this.cmBxCoursePrice.Size = new System.Drawing.Size(134, 28);
            this.cmBxCoursePrice.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // StudentAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGridAssign);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.pnlStuAssign);
            this.Controls.Add(this.cmBxId);
            this.Controls.Add(this.cmBxStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBxCoursePrice);
            this.Controls.Add(this.cmBxCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblCourse);
            this.Name = "StudentAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAssign";
            this.Load += new System.EventHandler(this.StudentAssign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAssign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Panel pnlStuAssign;
        private System.Windows.Forms.ComboBox cmBxCourse;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmBxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBxId;
        private System.Windows.Forms.DataGridView dtGridAssign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBxCoursePrice;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}