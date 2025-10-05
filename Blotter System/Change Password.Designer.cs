namespace Blotter_System
{
    partial class wndwChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wndwChangePassword));
            this.btnChange = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.checkOldPass = new System.Windows.Forms.CheckBox();
            this.checkNewPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(206, 79);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(66, 26);
            this.btnChange.TabIndex = 33;
            this.btnChange.Text = "&Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(138, 79);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 26);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(94, 42);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(178, 20);
            this.txtNewPassword.TabIndex = 31;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(94, 12);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(178, 20);
            this.txtOldPassword.TabIndex = 30;
            this.txtOldPassword.TextChanged += new System.EventHandler(this.txtOldPassword_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewPassword.Location = new System.Drawing.Point(5, 45);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 29;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOldPassword.Location = new System.Drawing.Point(11, 15);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(75, 13);
            this.lblOldPassword.TabIndex = 28;
            this.lblOldPassword.Text = "Old Password:";
            // 
            // checkOldPass
            // 
            this.checkOldPass.AutoSize = true;
            this.checkOldPass.Location = new System.Drawing.Point(278, 15);
            this.checkOldPass.Name = "checkOldPass";
            this.checkOldPass.Size = new System.Drawing.Size(15, 14);
            this.checkOldPass.TabIndex = 34;
            this.checkOldPass.UseVisualStyleBackColor = true;
            this.checkOldPass.CheckedChanged += new System.EventHandler(this.checkOldPass_CheckedChanged);
            // 
            // checkNewPass
            // 
            this.checkNewPass.AutoSize = true;
            this.checkNewPass.Location = new System.Drawing.Point(278, 45);
            this.checkNewPass.Name = "checkNewPass";
            this.checkNewPass.Size = new System.Drawing.Size(15, 14);
            this.checkNewPass.TabIndex = 35;
            this.checkNewPass.UseVisualStyleBackColor = true;
            this.checkNewPass.CheckedChanged += new System.EventHandler(this.checkNewPass_CheckedChanged);
            // 
            // wndwChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 113);
            this.Controls.Add(this.checkNewPass);
            this.Controls.Add(this.checkOldPass);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wndwChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.wndwChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.CheckBox checkOldPass;
        private System.Windows.Forms.CheckBox checkNewPass;
    }
}