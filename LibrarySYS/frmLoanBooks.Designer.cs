
namespace LibrarySYS
{
    partial class frmLoanBooks
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
            this.lblLoanBooks = new System.Windows.Forms.Label();
            this.btnLoanBook = new System.Windows.Forms.Button();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.txtMemberforename = new System.Windows.Forms.TextBox();
            this.lblSearchMemberByPhoneNumber = new System.Windows.Forms.Label();
            this.lblSearchBookByISBN = new System.Windows.Forms.Label();
            this.txtTitlesearch = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnSeaarchBookTitle = new System.Windows.Forms.Button();
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.Loan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitNav
            // 
            this.btnExitNav.Location = new System.Drawing.Point(12, 12);
            this.btnExitNav.Name = "btnExitNav";
            this.btnExitNav.Size = new System.Drawing.Size(109, 31);
            this.btnExitNav.TabIndex = 1;
            this.btnExitNav.Text = "Exit";
            this.btnExitNav.UseVisualStyleBackColor = true;
            this.btnExitNav.Click += new System.EventHandler(this.btnExitNav_Click);
            // 
            // lblLoanBooks
            // 
            this.lblLoanBooks.AutoSize = true;
            this.lblLoanBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanBooks.Location = new System.Drawing.Point(261, 12);
            this.lblLoanBooks.Name = "lblLoanBooks";
            this.lblLoanBooks.Size = new System.Drawing.Size(199, 39);
            this.lblLoanBooks.TabIndex = 6;
            this.lblLoanBooks.Text = "Loan Books";
            // 
            // btnLoanBook
            // 
            this.btnLoanBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanBook.Location = new System.Drawing.Point(383, 528);
            this.btnLoanBook.Name = "btnLoanBook";
            this.btnLoanBook.Size = new System.Drawing.Size(244, 48);
            this.btnLoanBook.TabIndex = 36;
            this.btnLoanBook.Text = "Confirm Loan";
            this.btnLoanBook.UseVisualStyleBackColor = true;
            this.btnLoanBook.Click += new System.EventHandler(this.btnLoanBook_Click);
            // 
            // lblMemberID
            // 
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(57, 472);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(103, 29);
            this.lblMemberID.TabIndex = 39;
            this.lblMemberID.Text = "MemberID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(184, 472);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(150, 20);
            this.txtMemberID.TabIndex = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grdMembers
            // 
            this.grdMembers.AllowUserToAddRows = false;
            this.grdMembers.AllowUserToDeleteRows = false;
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembers.Location = new System.Drawing.Point(44, 164);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.ReadOnly = true;
            this.grdMembers.Size = new System.Drawing.Size(565, 302);
            this.grdMembers.TabIndex = 44;
            this.grdMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellContentClick);
            // 
            // txtMemberforename
            // 
            this.txtMemberforename.Location = new System.Drawing.Point(383, 65);
            this.txtMemberforename.Name = "txtMemberforename";
            this.txtMemberforename.Size = new System.Drawing.Size(150, 20);
            this.txtMemberforename.TabIndex = 45;
            // 
            // lblSearchMemberByPhoneNumber
            // 
            this.lblSearchMemberByPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMemberByPhoneNumber.Location = new System.Drawing.Point(39, 59);
            this.lblSearchMemberByPhoneNumber.Name = "lblSearchMemberByPhoneNumber";
            this.lblSearchMemberByPhoneNumber.Size = new System.Drawing.Size(338, 34);
            this.lblSearchMemberByPhoneNumber.TabIndex = 46;
            this.lblSearchMemberByPhoneNumber.Text = "Search Member By Phone Number";
            this.lblSearchMemberByPhoneNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSearchBookByISBN
            // 
            this.lblSearchBookByISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBookByISBN.Location = new System.Drawing.Point(670, 65);
            this.lblSearchBookByISBN.Name = "lblSearchBookByISBN";
            this.lblSearchBookByISBN.Size = new System.Drawing.Size(338, 34);
            this.lblSearchBookByISBN.TabIndex = 47;
            this.lblSearchBookByISBN.Text = "Search Book By Title";
            // 
            // txtTitlesearch
            // 
            this.txtTitlesearch.Location = new System.Drawing.Point(916, 65);
            this.txtTitlesearch.Name = "txtTitlesearch";
            this.txtTitlesearch.Size = new System.Drawing.Size(150, 20);
            this.txtTitlesearch.TabIndex = 48;
            this.txtTitlesearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(383, 101);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(147, 30);
            this.btnSearchMember.TabIndex = 49;
            this.btnSearchMember.Text = "Search Member";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnSeaarchBookTitle
            // 
            this.btnSeaarchBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeaarchBookTitle.Location = new System.Drawing.Point(916, 101);
            this.btnSeaarchBookTitle.Name = "btnSeaarchBookTitle";
            this.btnSeaarchBookTitle.Size = new System.Drawing.Size(147, 30);
            this.btnSeaarchBookTitle.TabIndex = 50;
            this.btnSeaarchBookTitle.Text = "Search Book";
            this.btnSeaarchBookTitle.UseVisualStyleBackColor = true;
            this.btnSeaarchBookTitle.Click += new System.EventHandler(this.btnSeaarchBookTitle_Click);
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToAddRows = false;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loan});
            this.grdBooks.Location = new System.Drawing.Point(695, 188);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.Size = new System.Drawing.Size(477, 262);
            this.grdBooks.TabIndex = 51;
            this.grdBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBooks_CellContentClick_1);
            // 
            // Loan
            // 
            this.Loan.HeaderText = "Loan";
            this.Loan.Name = "Loan";
            // 
            // frmLoanBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 640);
            this.Controls.Add(this.grdBooks);
            this.Controls.Add(this.btnSeaarchBookTitle);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.txtTitlesearch);
            this.Controls.Add(this.lblSearchBookByISBN);
            this.Controls.Add(this.lblSearchMemberByPhoneNumber);
            this.Controls.Add(this.txtMemberforename);
            this.Controls.Add(this.grdMembers);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.btnLoanBook);
            this.Controls.Add(this.lblLoanBooks);
            this.Controls.Add(this.btnExitNav);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLoanBooks";
            this.Text = "frmLoanBooks";
            this.Load += new System.EventHandler(this.frmLoanBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitNav;
        private System.Windows.Forms.Label lblLoanBooks;
        private System.Windows.Forms.Button btnLoanBook;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.TextBox txtMemberforename;
        private System.Windows.Forms.Label lblSearchMemberByPhoneNumber;
        private System.Windows.Forms.Label lblSearchBookByISBN;
        private System.Windows.Forms.TextBox txtTitlesearch;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnSeaarchBookTitle;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Loan;
    }
}