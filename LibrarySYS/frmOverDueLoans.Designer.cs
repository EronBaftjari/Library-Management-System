
namespace LibrarySYS
{
    partial class frmOverDueLoans
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
            this.lblOverDueLoans = new System.Windows.Forms.Label();
            this.grdOverDueLoans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdOverDueLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitNav
            // 
            this.btnExitNav.Location = new System.Drawing.Point(12, 12);
            this.btnExitNav.Name = "btnExitNav";
            this.btnExitNav.Size = new System.Drawing.Size(109, 31);
            this.btnExitNav.TabIndex = 2;
            this.btnExitNav.Text = "Exit";
            this.btnExitNav.UseVisualStyleBackColor = true;
            this.btnExitNav.Click += new System.EventHandler(this.btnExitNav_Click);
            // 
            // lblOverDueLoans
            // 
            this.lblOverDueLoans.AutoSize = true;
            this.lblOverDueLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverDueLoans.Location = new System.Drawing.Point(283, 27);
            this.lblOverDueLoans.Name = "lblOverDueLoans";
            this.lblOverDueLoans.Size = new System.Drawing.Size(168, 25);
            this.lblOverDueLoans.TabIndex = 6;
            this.lblOverDueLoans.Text = "Over Due Loans\r\n";
            // 
            // grdOverDueLoans
            // 
            this.grdOverDueLoans.AllowUserToAddRows = false;
            this.grdOverDueLoans.AllowUserToDeleteRows = false;
            this.grdOverDueLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOverDueLoans.Location = new System.Drawing.Point(165, 98);
            this.grdOverDueLoans.Name = "grdOverDueLoans";
            this.grdOverDueLoans.ReadOnly = true;
            this.grdOverDueLoans.Size = new System.Drawing.Size(406, 271);
            this.grdOverDueLoans.TabIndex = 43;
            // 
            // frmOverDueLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdOverDueLoans);
            this.Controls.Add(this.lblOverDueLoans);
            this.Controls.Add(this.btnExitNav);
            this.Name = "frmOverDueLoans";
            this.Text = "frmOverDueLoans";
            this.Load += new System.EventHandler(this.frmOverDueLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOverDueLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitNav;
        private System.Windows.Forms.Label lblOverDueLoans;
        private System.Windows.Forms.DataGridView grdOverDueLoans;
    }
}