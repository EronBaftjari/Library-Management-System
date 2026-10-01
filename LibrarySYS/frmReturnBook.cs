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
    public partial class frmReturnBook : Form
    {
        public frmReturnBook()
        {
            InitializeComponent();
        }

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {

            txtMemberforename.MaxLength = 30;
            txtMemberID.MaxLength = 10;
           grdBooks.Visible = false;
            grdMembers.Visible = false;
            btnReturnBook.Visible = false;
            lblMemberID.Visible = false;
            btnViewLoans.Visible = false;
            txtMemberID.Visible=false;
            txtMemberID.ReadOnly = true;
           
       
        }
      

        private void grdMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value);
            txtMemberID.Text = Id.ToString();
        }

        private void txtMemberforename_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblSearchMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemberforename.Text))
            {
                MessageBox.Show("Phone Number Must be Enterd to Explicity Search Members", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberforename.Select();
                return;
            }

            foreach (char c in txtMemberforename.Text)
            {

                if (char.IsDigit(c))
                {
                    grdMembers.DataSource = Member.FindMembers(txtMemberforename.Text).Tables[0];


                    if (grdMembers.Rows.Count == 0) {
                        MessageBox.Show("No Members Exist based on the Phone Number enterd", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMemberforename.Select();
                        return;

                    }
                    lblMemberID.Visible=true;
                    grdMembers.Visible = true;
                    btnViewLoans.Visible = true;
                    txtMemberID.Visible = true;
                }
                else {
                    MessageBox.Show("Forename Must be only in letters Search Members", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberforename.Select();
                    return;

                }
            }
          


        }

        private void btnViewLoans_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemberID.Text))
            {
                MessageBox.Show("Member ID cannot Remain Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberID.Select();
                return;
            }

            if (txtMemberID.Text.All(char.IsDigit))
            {
                
                grdBooks.DataSource = Loans.ViewCurrentMembersLoans(Convert.ToInt32(txtMemberID.Text)).Tables[0];

                if (grdBooks.Rows.Count == 0) {

                    MessageBox.Show("Member Currently has no Current Loans", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                   
                }
                grdBooks.Visible = true;
                btnReturnBook.Visible = true;
                grdBooks.Focus();

            }
            else {
                MessageBox.Show("Member ID Must be only with Numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            List<int> ReturnBooks = new List<int>();
           int LoanID = 0;
            //I cant get it to Work where u can add a book that u want to return and then go search for a other Book so for now We will just have to search them 

            int count = 0;
            foreach (DataGridViewRow rows in grdBooks.Rows)
            {
                if (rows.Cells["Return"].Value + "" == "True")
                    count++;
                int BookID = Convert.ToInt32(rows.Cells["BookID"].Value);
              
                ReturnBooks.Add(BookID);

                LoanID= Convert.ToInt32(rows.Cells["LoanID"].Value);


            }




            if (count <= 0)
            {
                MessageBox.Show("Must Select At least 1 Book to Return Errorr ... " + "\n\n Error", "Error No Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

                

                foreach (int returningBook in ReturnBooks) {

                    LoanBooks returnBooks = new LoanBooks(LoanID, returningBook);

                    returnBooks.ReturnBooks();

                
                }

                MessageBox.Show(count + " Books have Been returned ", "Books Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (DataGridViewRow rows in grdBooks.Rows)
                {
                    rows.Cells["Return"].Value = false;
                        
                }
                grdBooks.Visible=false;
                grdMembers.Visible=false;
                txtMemberforename.Text="";
                txtMemberforename.Focus();
                txtMemberID.Text = "";
                btnReturnBook.Visible=false;
                lblMemberID.Visible=false;
                btnViewLoans.Visible=false;
                txtMemberID.Visible=false;  
            }
        }

        private void grdBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

