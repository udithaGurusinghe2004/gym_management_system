namespace gym_management_system
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtpasswd = new System.Windows.Forms.TextBox();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closecirclebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(248, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.label2.Location = new System.Drawing.Point(248, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.label3.Location = new System.Drawing.Point(248, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(455, 205);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(334, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtpasswd
            // 
            this.txtpasswd.BackColor = System.Drawing.Color.Silver;
            this.txtpasswd.Location = new System.Drawing.Point(455, 241);
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.Size = new System.Drawing.Size(334, 22);
            this.txtpasswd.TabIndex = 4;
            // 
            // cmbrole
            // 
            this.cmbrole.BackColor = System.Drawing.Color.Silver;
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "owner",
            "coach"});
            this.cmbrole.Location = new System.Drawing.Point(455, 273);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(334, 24);
            this.cmbrole.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(333, 348);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(153, 37);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Create";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(571, 348);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(150, 37);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.label4.Location = new System.Drawing.Point(389, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Register New User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(795, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 57);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // closecirclebtn
            // 
            this.closecirclebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closecirclebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closecirclebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closecirclebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closecirclebtn.FillColor = System.Drawing.Color.Red;
            this.closecirclebtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closecirclebtn.ForeColor = System.Drawing.Color.White;
            this.closecirclebtn.Location = new System.Drawing.Point(974, 0);
            this.closecirclebtn.Name = "closecirclebtn";
            this.closecirclebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closecirclebtn.Size = new System.Drawing.Size(33, 30);
            this.closecirclebtn.TabIndex = 11;
            this.closecirclebtn.Text = "x";
            this.closecirclebtn.TextFormatNoPrefix = true;
            this.closecirclebtn.Click += new System.EventHandler(this.closecirclebtn_Click);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1007, 553);
            this.Controls.Add(this.closecirclebtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.txtpasswd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtpasswd;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton closecirclebtn;
    }
}

