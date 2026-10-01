using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

      

     

      

      
      

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(Database.connectionString);
                conn.Open();
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contact Your Administrador ","DataBase Unfortunatly not Working",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }

        
        }

        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddMember addMember = new frmAddMember();
            addMember.Show();
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember updateMember = new frmUpdateMember();
            updateMember.Show();
        }

        private void mnuDeleteMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteMember deleteMember = new frmDeleteMember();
            deleteMember.Show();
        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddBooks addBook = new frmAddBooks();
            addBook.Show();
        }

        private void mnuUpdateBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateBooks updateBook = new frmUpdateBooks();
            updateBook.Show();
        }

        private void mnuDeleteBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteBooks deleteBook = new frmDeleteBooks();
            deleteBook.Show();
        }

        private void mnuLoanBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoanBooks loanBooks = new frmLoanBooks();
            loanBooks.Show();
        }

        private void btnExitAPP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u Sure u want to Exit the Application", "Exit APP", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes) {
                Application.Exit();
            
            }
        }

        private void mnuReturnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnBook returnBook = new frmReturnBook();
            returnBook.Show();
        }

        private void mnuPopularBooksReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPopularBooksReport popularBooks = new frmPopularBooksReport();
            popularBooks.Show();
        }

        private void mnuOverDueLoans_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOverDueLoans overDue = new frmOverDueLoans();
            overDue.Show();
        }

        private void overDueLoansToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmOverDueLoans dueLoans = new frmOverDueLoans();
            dueLoans.Show();
        }

        private void memberJoinRateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberJoinRateReport memberJoinRate = new frmMemberJoinRateReport();
            memberJoinRate.Show();
        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewMembers viewMembers = new frmViewMembers();
            viewMembers.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewBooks viewBooks = new frmViewBooks();
            viewBooks.Show();
        }
    }
}
