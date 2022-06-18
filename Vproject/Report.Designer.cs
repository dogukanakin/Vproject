
namespace Vproject
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.btnStuOperations = new System.Windows.Forms.Button();
            this.btnTeaOperations = new System.Windows.Forms.Button();
            this.btnCouOperations = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStuOperations
            // 
            this.btnStuOperations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStuOperations.FlatAppearance.BorderSize = 0;
            this.btnStuOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStuOperations.Image = ((System.Drawing.Image)(resources.GetObject("btnStuOperations.Image")));
            this.btnStuOperations.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStuOperations.Location = new System.Drawing.Point(41, 69);
            this.btnStuOperations.Name = "btnStuOperations";
            this.btnStuOperations.Size = new System.Drawing.Size(184, 191);
            this.btnStuOperations.TabIndex = 0;
            this.btnStuOperations.Text = "Student Operations";
            this.btnStuOperations.UseVisualStyleBackColor = false;
            this.btnStuOperations.Click += new System.EventHandler(this.btnStuOperations_Click);
            // 
            // btnTeaOperations
            // 
            this.btnTeaOperations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeaOperations.FlatAppearance.BorderSize = 0;
            this.btnTeaOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeaOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeaOperations.Image = ((System.Drawing.Image)(resources.GetObject("btnTeaOperations.Image")));
            this.btnTeaOperations.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeaOperations.Location = new System.Drawing.Point(262, 69);
            this.btnTeaOperations.Name = "btnTeaOperations";
            this.btnTeaOperations.Size = new System.Drawing.Size(196, 191);
            this.btnTeaOperations.TabIndex = 1;
            this.btnTeaOperations.Text = "Teacher Operations";
            this.btnTeaOperations.UseVisualStyleBackColor = false;
            this.btnTeaOperations.Click += new System.EventHandler(this.btnTeaOperations_Click);
            // 
            // btnCouOperations
            // 
            this.btnCouOperations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCouOperations.FlatAppearance.BorderSize = 0;
            this.btnCouOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCouOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCouOperations.Image = ((System.Drawing.Image)(resources.GetObject("btnCouOperations.Image")));
            this.btnCouOperations.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCouOperations.Location = new System.Drawing.Point(502, 69);
            this.btnCouOperations.Name = "btnCouOperations";
            this.btnCouOperations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCouOperations.Size = new System.Drawing.Size(196, 191);
            this.btnCouOperations.TabIndex = 2;
            this.btnCouOperations.Text = "Course Operations";
            this.btnCouOperations.UseVisualStyleBackColor = false;
            this.btnCouOperations.Click += new System.EventHandler(this.btnCouOperations_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(574, 328);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 94);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCouOperations);
            this.Controls.Add(this.btnTeaOperations);
            this.Controls.Add(this.btnStuOperations);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStuOperations;
        private System.Windows.Forms.Button btnTeaOperations;
        private System.Windows.Forms.Button btnCouOperations;
        private System.Windows.Forms.Button btnBack;
    }
}