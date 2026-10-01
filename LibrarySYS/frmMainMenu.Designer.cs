
namespace LibrarySYS
{
    partial class frmMainMenu
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
            this.lblLibrarySystem = new System.Windows.Forms.Label();
            this.btnExitAPP = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuManageMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoanBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.overDueLoansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPopularBooksReport = new System.Windows.Forms.ToolStripMenuItem();
            this.memberJoinRateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.viewMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLibrarySystem
            // 
            this.lblLibrarySystem.AutoSize = true;
            this.lblLibrarySystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarySystem.Location = new System.Drawing.Point(174, 69);
            this.lblLibrarySystem.Name = "lblLibrarySystem";
            this.lblLibrarySystem.Size = new System.Drawing.Size(328, 25);
            this.lblLibrarySystem.TabIndex = 5;
            this.lblLibrarySystem.Text = "Welcome to the Library System !!";
            // 
            // btnExitAPP
            // 
            this.btnExitAPP.Location = new System.Drawing.Point(525, 0);
            this.btnExitAPP.Name = "btnExitAPP";
            this.btnExitAPP.Size = new System.Drawing.Size(120, 30);
            this.btnExitAPP.TabIndex = 23;
            this.btnExitAPP.Text = " Exit Application";
            this.btnExitAPP.UseVisualStyleBackColor = true;
            this.btnExitAPP.Click += new System.EventHandler(this.btnExitAPP_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuManageMembers
            // 
            this.mnuManageMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMember,
            this.mnuUpdateMember,
            this.mnuDeleteMember,
            this.viewMembersToolStripMenuItem});
            this.mnuManageMembers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuManageMembers.Name = "mnuManageMembers";
            this.mnuManageMembers.Size = new System.Drawing.Size(148, 25);
            this.mnuManageMembers.Text = "Manage Members";
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(193, 26);
            this.mnuAddMember.Text = "Add Member";
            this.mnuAddMember.Click += new System.EventHandler(this.mnuAddMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(193, 26);
            this.mnuUpdateMember.Text = "Update Member";
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
            // 
            // mnuDeleteMember
            // 
            this.mnuDeleteMember.Name = "mnuDeleteMember";
            this.mnuDeleteMember.Size = new System.Drawing.Size(193, 26);
            this.mnuDeleteMember.Text = "Delete Member";
            this.mnuDeleteMember.Click += new System.EventHandler(this.mnuDeleteMember_Click);
            // 
            // mnuManageBooks
            // 
            this.mnuManageBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.mnuUpdateBook,
            this.mnuDeleteBook,
            this.viewBooksToolStripMenuItem});
            this.mnuManageBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuManageBooks.Name = "mnuManageBooks";
            this.mnuManageBooks.Size = new System.Drawing.Size(124, 25);
            this.mnuManageBooks.Text = "Manage Books";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(169, 26);
            this.mnuAddBook.Text = "Add Book";
            this.mnuAddBook.Click += new System.EventHandler(this.mnuAddBook_Click);
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(169, 26);
            this.mnuUpdateBook.Text = "Update Book";
            this.mnuUpdateBook.Click += new System.EventHandler(this.mnuUpdateBook_Click);
            // 
            // mnuDeleteBook
            // 
            this.mnuDeleteBook.Name = "mnuDeleteBook";
            this.mnuDeleteBook.Size = new System.Drawing.Size(169, 26);
            this.mnuDeleteBook.Text = "Delete Book";
            this.mnuDeleteBook.Click += new System.EventHandler(this.mnuDeleteBook_Click);
            // 
            // mnuManageLoans
            // 
            this.mnuManageLoans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoanBook,
            this.mnuReturnBook,
            this.overDueLoansToolStripMenuItem});
            this.mnuManageLoans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuManageLoans.Name = "mnuManageLoans";
            this.mnuManageLoans.Size = new System.Drawing.Size(123, 25);
            this.mnuManageLoans.Text = "Manage Loans";
            // 
            // mnuLoanBook
            // 
            this.mnuLoanBook.Name = "mnuLoanBook";
            this.mnuLoanBook.Size = new System.Drawing.Size(187, 26);
            this.mnuLoanBook.Text = "Loan Book";
            this.mnuLoanBook.Click += new System.EventHandler(this.mnuLoanBook_Click);
            // 
            // mnuReturnBook
            // 
            this.mnuReturnBook.Name = "mnuReturnBook";
            this.mnuReturnBook.Size = new System.Drawing.Size(187, 26);
            this.mnuReturnBook.Text = "Return Book";
            this.mnuReturnBook.Click += new System.EventHandler(this.mnuReturnBook_Click);
            // 
            // overDueLoansToolStripMenuItem
            // 
            this.overDueLoansToolStripMenuItem.Name = "overDueLoansToolStripMenuItem";
            this.overDueLoansToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.overDueLoansToolStripMenuItem.Text = "OverDue Loans";
            this.overDueLoansToolStripMenuItem.Click += new System.EventHandler(this.overDueLoansToolStripMenuItem_Click);
            // 
            // mnuDataAnalysis
            // 
            this.mnuDataAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPopularBooksReport,
            this.memberJoinRateReportToolStripMenuItem});
            this.mnuDataAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDataAnalysis.Name = "mnuDataAnalysis";
            this.mnuDataAnalysis.Size = new System.Drawing.Size(68, 25);
            this.mnuDataAnalysis.Text = "Admin";
            // 
            // mnuPopularBooksReport
            // 
            this.mnuPopularBooksReport.Name = "mnuPopularBooksReport";
            this.mnuPopularBooksReport.Size = new System.Drawing.Size(257, 26);
            this.mnuPopularBooksReport.Text = "Popular Books Report";
            this.mnuPopularBooksReport.Click += new System.EventHandler(this.mnuPopularBooksReport_Click);
            // 
            // memberJoinRateReportToolStripMenuItem
            // 
            this.memberJoinRateReportToolStripMenuItem.Name = "memberJoinRateReportToolStripMenuItem";
            this.memberJoinRateReportToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.memberJoinRateReportToolStripMenuItem.Text = "Member Join Rate Report";
            this.memberJoinRateReportToolStripMenuItem.Click += new System.EventHandler(this.memberJoinRateReportToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageMembers,
            this.mnuManageBooks,
            this.mnuManageLoans,
            this.mnuDataAnalysis});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 29);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // viewMembersToolStripMenuItem
            // 
            this.viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            this.viewMembersToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.viewMembersToolStripMenuItem.Text = "View Members";
            this.viewMembersToolStripMenuItem.Click += new System.EventHandler(this.viewMembersToolStripMenuItem_Click);
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.viewBooksToolStripMenuItem.Text = "View Books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitAPP);
            this.Controls.Add(this.lblLibrarySystem);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLibrarySystem;
        private System.Windows.Forms.Button btnExitAPP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuManageMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteMember;
        private System.Windows.Forms.ToolStripMenuItem mnuManageBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteBook;
        private System.Windows.Forms.ToolStripMenuItem mnuManageLoans;
        private System.Windows.Forms.ToolStripMenuItem mnuLoanBook;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnBook;
        private System.Windows.Forms.ToolStripMenuItem overDueLoansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDataAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuPopularBooksReport;
        private System.Windows.Forms.ToolStripMenuItem memberJoinRateReportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem viewMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
    }
}