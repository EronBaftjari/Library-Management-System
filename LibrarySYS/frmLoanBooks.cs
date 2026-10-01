using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmLoanBooks : Form
    {
        public frmLoanBooks()
        {
            InitializeComponent();
        }

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void frmLoanBooks_Load(object sender, EventArgs e)
        {
            txtMemberforename.MaxLength = 30;
            txtTitlesearch.MaxLength = 30;
            btnLoanBook.Visible = false;
            grdMembers.Visible = false;
            grdBooks.Visible = false;
            txtMemberID.ReadOnly = true;
            
        
           
 
          

          

        }

        private void grdMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int currentRow = grdMembers.CurrentCell.RowIndex;


            int Id = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value);
            txtMemberID.Text = Id.ToString();

            //txtMemberID.Text = grdMembers.Rows[currentRow].Cells["MemberID"].Value.ToString();
        }

        private void grdBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int currentRow = grdBooks.CurrentCell.RowIndex;

            //txtBookID.Text = grdBooks.Rows[currentRow].Cells["BookID"].Value.ToString();
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            //And also here i cant get it to work where i search for a book add it in my inventory and then search again as it breaks my list so for now we will have to just manuelly search them 
            //or during the presentation we can remove it just make alll books available for the time being when testing my database 
            List<int> LoanBooks = new List<int>();
            int count = 0;
            foreach (DataGridViewRow rows in grdBooks.Rows) {
                if (rows.Cells["Loan"].Value + "" == "True")
                    count++;
                int BookID = Convert.ToInt32(rows.Cells["BookID"].Value);

                LoanBooks.Add(BookID);
            }
            if (count <= 0)
            {
                MessageBox.Show("Must Select At least 1 Book to Loan Errorr ... " + "\n\n Error", "Error No Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count > 5) {
                MessageBox.Show("Can Only Loan Maxium Of 5 Books at a time ... " + "\n\n Error", "Error Loaning Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (txtMemberID.Text != "")
            {
                //foreach (int bookid in LoanBooks)
                //{
                   // MessageBox.Show(bookid.ToString());
               // }
                //TEST Going Through issue with my Data Grid view as i want to filter out books when loaning them and adding them to my list but my list gets cleared when i filter my data grid view/
                //But if all comes to worse ill have to use my loan book and return book with no Book Filters as when i dont filter my data grid the list works with the checkboxes 

                int loanid = Loans.GetNextLoanID();
                int MemberID = Convert.ToInt32(txtMemberID.Text);

                Loans loan = new Loans(loanid, MemberID);

                loan.BooksLoaned();

                foreach (int bookid in LoanBooks) {
                
                    LoanBooks LB = new LoanBooks(loanid, bookid);

                    LB.LoanedBooks();
                    
                }

                MessageBox.Show(count + " Book Succesfully loaned to Member ID of " + txtMemberID.Text, "Succesful Loan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMemberID.Text = "";
                txtTitlesearch.Text = "";
                txtMemberforename.Text = "";
                grdBooks.Visible = false;
                grdMembers.Visible = false;
                btnLoanBook.Visible = false;
                LoanBooks.Clear();

                //int LoanID = Loans.GetNextLoanID();

                //MessageBox.Show(LoanID.ToString());
              
            }
            else
            {
                MessageBox.Show("Error Please fill in All Fields", "UnSuccesful Loan", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemberforename.Text))
            {
                MessageBox.Show("Forename Must be Enterd to Explicity Search Members", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberforename.Select();
                return;
            }

            foreach (char c in txtMemberforename.Text) {

                if (char.IsDigit(c))
                {

                    grdMembers.DataSource = Member.FindMembers(txtMemberforename.Text).Tables[0];
                    if (grdMembers.Rows.Count == 0) {

                        MessageBox.Show("No Members Exist based on the PhoneNumber", " Filter Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtMemberforename.Select();
                        
                        return;
                    }
                    grdMembers.Visible = true;
                    
                }
                else {
                    MessageBox.Show("Phone Number Must be in digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberforename.Select();
                    return;
                }
            }
        

            }

        private void btnSeaarchBookTitle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitlesearch.Text))
            {
                MessageBox.Show("Book Title  Must be Enterd to Explicity Search Books", " Filter Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitlesearch.Select();
               
                return;
            }
            grdBooks.DataSource = Books.FindBooks(txtTitlesearch.Text).Tables[0];
            if (grdBooks.Rows.Count == 0) {

                MessageBox.Show("No Books Found Based on the Title ", " Filter Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitlesearch.Select();

                return;
            }
            grdBooks.Visible = true;
           btnLoanBook.Visible=true;
        }

        private void grdBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        }
    

