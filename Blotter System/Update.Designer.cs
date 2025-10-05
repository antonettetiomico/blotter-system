namespace Blotter_System
{
    partial class wndwUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wndwUpdate));
            this.txtCompNo = new System.Windows.Forms.TextBox();
            this.lblCompNo = new System.Windows.Forms.Label();
            this.rbtUnderObv = new System.Windows.Forms.RadioButton();
            this.rbtCleared = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCompNo
            // 
            this.txtCompNo.Location = new System.Drawing.Point(88, 12);
            this.txtCompNo.Name = "txtCompNo";
            this.txtCompNo.Size = new System.Drawing.Size(134, 20);
            this.txtCompNo.TabIndex = 0;
            this.txtCompNo.TextChanged += new System.EventHandler(this.txtCompNo_TextChanged);
            // 
            // lblCompNo
            // 
            this.lblCompNo.AutoSize = true;
            this.lblCompNo.Location = new System.Drawing.Point(12, 15);
            this.lblCompNo.Name = "lblCompNo";
            this.lblCompNo.Size = new System.Drawing.Size(70, 13);
            this.lblCompNo.TabIndex = 1;
            this.lblCompNo.Text = "Complain No:";
            // 
            // rbtUnderObv
            // 
            this.rbtUnderObv.AutoSize = true;
            this.rbtUnderObv.Location = new System.Drawing.Point(88, 38);
            this.rbtUnderObv.Name = "rbtUnderObv";
            this.rbtUnderObv.Size = new System.Drawing.Size(114, 17);
            this.rbtUnderObv.TabIndex = 2;
            this.rbtUnderObv.TabStop = true;
            this.rbtUnderObv.Text = "Under Observation";
            this.rbtUnderObv.UseVisualStyleBackColor = true;
            this.rbtUnderObv.CheckedChanged += new System.EventHandler(this.rbtUnderObv_CheckedChanged);
            // 
            // rbtCleared
            // 
            this.rbtCleared.AutoSize = true;
            this.rbtCleared.Location = new System.Drawing.Point(88, 61);
            this.rbtCleared.Name = "rbtCleared";
            this.rbtCleared.Size = new System.Drawing.Size(61, 17);
            this.rbtCleared.TabIndex = 3;
            this.rbtCleared.TabStop = true;
            this.rbtCleared.Text = "Cleared";
            this.rbtCleared.UseVisualStyleBackColor = true;
            this.rbtCleared.CheckedChanged += new System.EventHandler(this.rbtCleared_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 26);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(88, 94);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 26);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // wndwUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 131);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbtCleared);
            this.Controls.Add(this.rbtUnderObv);
            this.Controls.Add(this.lblCompNo);
            this.Controls.Add(this.txtCompNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wndwUpdate";
            this.Text = "Update Data";
            this.Load += new System.EventHandler(this.wndwUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompNo;
        private System.Windows.Forms.Label lblCompNo;
        private System.Windows.Forms.RadioButton rbtUnderObv;
        private System.Windows.Forms.RadioButton rbtCleared;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}