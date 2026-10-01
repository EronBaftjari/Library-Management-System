namespace LibrarySYS
{
    partial class frmViewBooks
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
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.lblViewBooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitNav
            // 
            this.btnExitNav.Location = new System.Drawing.Point(12, 12);
            this.btnExitNav.Name = "btnExitNav";
            this.btnExitNav.Size = new System.Drawing.Size(97, 30);
            this.btnExitNav.TabIndex = 18;
            this.btnExitNav.Text = "Exit";
            this.btnExitNav.UseVisualStyleBackColor = true;
            this.btnExitNav.Click += new System.EventHandler(this.btnExitNav_Click);
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToAddRows = false;
            this.grdBooks.AllowUserToDeleteRows = false;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Location = new System.Drawing.Point(87, 115);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.ReadOnly = true;
            this.grdBooks.Size = new System.Drawing.Size(719, 351);
            this.grdBooks.TabIndex = 43;
            this.grdBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBooks_CellContentClick);
            // 
            // lblViewBooks
            // 
            this.lblViewBooks.AutoSize = true;
            this.lblViewBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBooks.Location = new System.Drawing.Point(300, 43);
            this.lblViewBooks.Name = "lblViewBooks";
            this.lblViewBooks.Size = new System.Drawing.Size(193, 31);
            this.lblViewBooks.TabIndex = 44;
            this.lblViewBooks.Text = "View All Books\r\n";
            // 
            // frmViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 516);
            this.Controls.Add(this.lblViewBooks);
            this.Controls.Add(this.grdBooks);
            this.Controls.Add(this.btnExitNav);
            this.Name = "frmViewBooks";
            this.Text = "frmViewBooks";
            this.Load += new System.EventHandler(this.frmViewBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitNav;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.Label lblViewBooks;
    }
}