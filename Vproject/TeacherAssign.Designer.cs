
namespace Vproject
{
    partial class TeacherAssign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherAssign));
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmBxCourse = new System.Windows.Forms.ComboBox();
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmBxTeacher = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtGridAssign = new System.Windows.Forms.DataGridView();
            this.cmBxId = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAssign)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacher.Location = new System.Drawing.Point(103, 404);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(130, 20);
            this.lblTeacher.TabIndex = 0;
            this.lblTeacher.Text = "Teacher Name:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourse.Location = new System.Drawing.Point(103, 450);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(122, 20);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course Name:";
            // 
            // cmBxCourse
            // 
            this.cmBxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxCourse.FormattingEnabled = true;
            this.cmBxCourse.Location = new System.Drawing.Point(287, 447);
            this.cmBxCourse.Name = "cmBxCourse";
            this.cmBxCourse.Size = new System.Drawing.Size(146, 28);
            this.cmBxCourse.TabIndex = 2;
            // 
            // pnlAssign
            // 
            this.pnlAssign.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlAssign.Location = new System.Drawing.Point(0, 1);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(800, 89);
            this.pnlAssign.TabIndex = 6;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAssign.Location = new System.Drawing.Point(287, 500);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(146, 49);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(648, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 90);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmBxTeacher
            // 
            this.cmBxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxTeacher.FormattingEnabled = true;
            this.cmBxTeacher.Location = new System.Drawing.Point(287, 401);
            this.cmBxTeacher.Name = "cmBxTeacher";
            this.cmBxTeacher.Size = new System.Drawing.Size(146, 28);
            this.cmBxTeacher.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(283, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 20);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Teacher List";
            // 
            // dtGridAssign
            // 
            this.dtGridAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAssign.Location = new System.Drawing.Point(12, 130);
            this.dtGridAssign.Name = "dtGridAssign";
            this.dtGridAssign.Size = new System.Drawing.Size(762, 207);
            this.dtGridAssign.TabIndex = 5;
            this.dtGridAssign.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAssign_CellEnter);
            // 
            // cmBxId
            // 
            this.cmBxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxId.FormattingEnabled = true;
            this.cmBxId.Location = new System.Drawing.Point(287, 354);
            this.cmBxId.Name = "cmBxId";
            this.cmBxId.Size = new System.Drawing.Size(146, 28);
            this.cmBxId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(103, 354);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(103, 20);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Teacher ID:";
            // 
            // TeacherAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtGridAssign);
            this.Controls.Add(this.cmBxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmBxTeacher);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.pnlAssign);
            this.Controls.Add(this.cmBxCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblTeacher);
            this.Name = "TeacherAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherAssign";
            this.Load += new System.EventHandler(this.TeacherAssign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAssign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmBxCourse;
        private System.Windows.Forms.Panel pnlAssign;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmBxTeacher;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dtGridAssign;
        private System.Windows.Forms.ComboBox cmBxId;
        private System.Windows.Forms.Label lblId;
    }
}