namespace gym_management_system
{
    partial class ReportGenerate
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnMemberReport = new System.Windows.Forms.Button();
            this.btnStaffReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Take your reports here...";
            // 
            // btnMemberReport
            // 
            this.btnMemberReport.Location = new System.Drawing.Point(499, 223);
            this.btnMemberReport.Name = "btnMemberReport";
            this.btnMemberReport.Size = new System.Drawing.Size(152, 62);
            this.btnMemberReport.TabIndex = 2;
            this.btnMemberReport.Text = "Member Report";
            this.btnMemberReport.UseVisualStyleBackColor = true;
            this.btnMemberReport.Click += new System.EventHandler(this.btnMemberReport_Click);
            // 
            // btnStaffReport
            // 
            this.btnStaffReport.Location = new System.Drawing.Point(191, 223);
            this.btnStaffReport.Name = "btnStaffReport";
            this.btnStaffReport.Size = new System.Drawing.Size(134, 62);
            this.btnStaffReport.TabIndex = 3;
            this.btnStaffReport.Text = "Staff Report";
            this.btnStaffReport.UseVisualStyleBackColor = true;
            this.btnStaffReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReportGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStaffReport);
            this.Controls.Add(this.btnMemberReport);
            this.Controls.Add(this.label2);
            this.Name = "ReportGenerate";
            this.Text = "ReportGenerate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMemberReport;
        private System.Windows.Forms.Button btnStaffReport;
    }
}