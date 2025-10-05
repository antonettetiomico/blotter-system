namespace Blotter_System
{
    partial class wndwChangeUsername
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wndwChangeUsername));
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtOldUsername = new System.Windows.Forms.TextBox();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblOldUsername = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(97, 41);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(178, 20);
            this.txtNewUsername.TabIndex = 25;
            this.txtNewUsername.TextChanged += new System.EventHandler(this.txtNewUsername_TextChanged);
            // 
            // txtOldUsername
            // 
            this.txtOldUsername.Location = new System.Drawing.Point(97, 11);
            this.txtOldUsername.Name = "txtOldUsername";
            this.txtOldUsername.Size = new System.Drawing.Size(178, 20);
            this.txtOldUsername.TabIndex = 24;
            this.txtOldUsername.TextChanged += new System.EventHandler(this.txtOldUsername_TextChanged);
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewUsername.Location = new System.Drawing.Point(8, 44);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(83, 13);
            this.lblNewUsername.TabIndex = 23;
            this.lblNewUsername.Text = "New Username:";
            // 
            // lblOldUsername
            // 
            this.lblOldUsername.AutoSize = true;
            this.lblOldUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOldUsername.Location = new System.Drawing.Point(14, 14);
            this.lblOldUsername.Name = "lblOldUsername";
            this.lblOldUsername.Size = new System.Drawing.Size(77, 13);
            this.lblOldUsername.TabIndex = 22;
            this.lblOldUsername.Text = "Old Username:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(209, 78);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(66, 26);
            this.btnChange.TabIndex = 27;
            this.btnChange.Text = "&Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(141, 78);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 26);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // wndwChangeUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 116);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.txtOldUsername);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.lblOldUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wndwChangeUsername";
            this.Text = "Change Username";
            this.Load += new System.EventHandler(this.wndwChangeUsername_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtOldUsername;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblOldUsername;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnBack;
    }
}