namespace LibrarySYS
{
    partial class frmReturnBook
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtMemberforename = new System.Windows.Forms.TextBox();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.lblReturnBook = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnViewLoans = new System.Windows.Forms.Button();
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.btnExitNav = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(140, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(239, 18);
            this.lblSearch.TabIndex = 43;
            this.lblSearch.Text = "Search Member By Phone Number";
            // 
            // txtMemberforename
            // 
            this.txtMemberforename.Location = new System.Drawing.Point(165, 40);
            this.txtMemberforename.Name = "txtMemberforename";
            this.txtMemberforename.Size = new System.Drawing.Size(150, 20);
            this.txtMemberforename.TabIndex = 46;
            this.txtMemberforename.TextChanged += new System.EventHandler(this.txtMemberforename_TextChanged);
            // 
            // grdMembers
            // 
            this.grdMembers.AllowUserToAddRows = false;
            this.grdMembers.AllowUserToDeleteRows = false;
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembers.Location = new System.Drawing.Point(12, 114);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.ReadOnly = true;
            this.grdMembers.Size = new System.Drawing.Size(450, 262);
            this.grdMembers.TabIndex = 47;
            this.grdMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellContentClick);
            // 
            // lblReturnBook
            // 
            this.lblReturnBook.AutoSize = true;
            this.lblReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBook.Location = new System.Drawing.Point(452, 11);
            this.lblReturnBook.Name = "lblReturnBook";
            this.lblReturnBook.Size = new System.Drawing.Size(179, 31);
            this.lblReturnBook.TabIndex = 48;
            this.lblReturnBook.Text = "Return Books";
            // 
            // lblMemberID
            // 
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(26, 420);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(103, 29);
            this.lblMemberID.TabIndex = 49;
            this.lblMemberID.Text = "MemberID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(150, 420);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(150, 20);
            this.txtMemberID.TabIndex = 50;
            // 
            // btnViewLoans
            // 
            this.btnViewLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLoans.Location = new System.Drawing.Point(116, 470);
            this.btnViewLoans.Name = "btnViewLoans";
            this.btnViewLoans.Size = new System.Drawing.Size(147, 30);
            this.btnViewLoans.TabIndex = 51;
            this.btnViewLoans.Text = "View Loans";
            this.btnViewLoans.UseVisualStyleBackColor = true;
            this.btnViewLoans.Click += new System.EventHandler(this.btnViewLoans_Click);
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToAddRows = false;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Return});
            this.grdBooks.Location = new System.Drawing.Point(524, 114);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.Size = new System.Drawing.Size(630, 297);
            this.grdBooks.TabIndex = 52;
            this.grdBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBooks_CellContentClick);
            // 
            // btnExitNav
            // 
            this.btnExitNav.Location = new System.Drawing.Point(12, 12);
            this.btnExitNav.Name = "btnExitNav";
            this.btnExitNav.Size = new System.Drawing.Size(111, 30);
            this.btnExitNav.TabIndex = 53;
            this.btnExitNav.Text = "Exit";
            this.btnExitNav.UseVisualStyleBackColor = true;
            this.btnExitNav.Click += new System.EventHandler(this.btnExitNav_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(168, 78);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(147, 30);
            this.btnSearchMember.TabIndex = 54;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.lblSearchMember_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Location = new System.Drawing.Point(623, 494);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(147, 30);
            this.btnReturnBook.TabIndex = 55;
            this.btnReturnBook.Text = "Return Books";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // Return
            // 
            this.Return.HeaderText = "Return";
            this.Return.Name = "Return";
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 572);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.btnExitNav);
            this.Controls.Add(this.grdBooks);
            this.Controls.Add(this.btnViewLoans);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblReturnBook);
            this.Controls.Add(this.grdMembers);
            this.Controls.Add(this.txtMemberforename);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmReturnBook";
            this.Text = "frmReturnBook";
            this.Load += new System.EventHandler(this.frmReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtMemberforename;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.Label lblReturnBook;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Button btnViewLoans;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.Button btnExitNav;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Return;
    }
}