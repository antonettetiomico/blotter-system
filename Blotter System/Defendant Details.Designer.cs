namespace Blotter_System
{
    partial class wndwDefendant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wndwDefendant));
            this.btnBack = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgDefendants = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDefendants)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(588, 295);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 26);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(80, 12);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(567, 20);
            this.txtLName.TabIndex = 1;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 13);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Last Name:";
            // 
            // dgDefendants
            // 
            this.dgDefendants.AllowUserToAddRows = false;
            this.dgDefendants.AllowUserToDeleteRows = false;
            this.dgDefendants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDefendants.Location = new System.Drawing.Point(12, 38);
            this.dgDefendants.Name = "dgDefendants";
            this.dgDefendants.ReadOnly = true;
            this.dgDefendants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDefendants.Size = new System.Drawing.Size(635, 248);
            this.dgDefendants.TabIndex = 13;
            // 
            // wndwDefendant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 330);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgDefendants);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wndwDefendant";
            this.Text = "Defendant Details";
            this.Load += new System.EventHandler(this.wndwDefendant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDefendants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgDefendants;
    }
}