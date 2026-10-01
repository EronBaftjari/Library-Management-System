namespace LibrarySYS
{
    partial class frmViewMembers
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
            this.btnExitNav = new System.Windows.Forms.Button();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.lblViewAllMembers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitNav
            // 
            this.btnExitNav.Location = new System.Drawing.Point(12, 23);
            this.btnExitNav.Name = "btnExitNav";
            this.btnExitNav.Size = new System.Drawing.Size(97, 30);
            this.btnExitNav.TabIndex = 17;
            this.btnExitNav.Text = "Exit";
            this.btnExitNav.UseVisualStyleBackColor = true;
            this.btnExitNav.Click += new System.EventHandler(this.btnExitNav_Click);
            // 
            // grdMembers
            // 
            this.grdMembers.AllowUserToAddRows = false;
            this.grdMembers.AllowUserToDeleteRows = false;
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembers.Location = new System.Drawing.Point(109, 98);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.ReadOnly = true;
            this.grdMembers.Size = new System.Drawing.Size(710, 397);
            this.grdMembers.TabIndex = 21;
            this.grdMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellContentClick);
            // 
            // lblViewAllMembers
            // 
            this.lblViewAllMembers.AutoSize = true;
            this.lblViewAllMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAllMembers.Location = new System.Drawing.Point(324, 23);
            this.lblViewAllMembers.Name = "lblViewAllMembers";
            this.lblViewAllMembers.Size = new System.Drawing.Size(193, 62);
            this.lblViewAllMembers.TabIndex = 25;
            this.lblViewAllMembers.Text = "View All Books\r\n\r\n";
            // 
            // frmViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 560);
            this.Controls.Add(this.lblViewAllMembers);
            this.Controls.Add(this.grdMembers);
            this.Controls.Add(this.btnExitNav);
            this.Name = "frmViewMembers";
            this.Text = "frmViewMembers";
            this.Load += new System.EventHandler(this.frmViewMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitNav;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.Label lblViewAllMembers;
    }
}