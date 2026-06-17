namespace gym_management_system
{
    partial class ReportGenerate
    {
        
        private System.ComponentModel.IContainer components = null;

        
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.btnGenerate.Location = new System.Drawing.Point(292, 308);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 46);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate ";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "ReportGenerate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;

    }
}