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
    public partial class frmDeleteBooks : Form
    {
        public frmDeleteBooks()
        {
            InitializeComponent();
        }

        private void btnManageBooksNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show(); ;
        }

        private void lblDeleteMember_Click(object sender, EventArgs e)
        {

        }

        private void frmDeleteBooks_Load(object sender, EventArgs e)
        {
           

         
            grdBooks.Visible = false;
        }

        private void grdBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         

            int id = Convert.ToInt32(grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[0].Value);

            txtBookID.Text = id.ToString();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text != "")
            {
              

                Books book = new Books();
                int BookID = Convert.ToInt32(txtBookID.Text);
                book.BookID = BookID;
                book.deleteBook();

                MessageBox.Show("Book is now Deleted", "Succesfull Delete");
                txtSearch.Select();
                grdBooks.Visible = false;
                txtSearch.Text = "";
                txtBookID.Text = "";
            }
            else {

                MessageBox.Show("Invalid Data , Please Choose A valid BookID to delete", " Invalid ... Delete Book");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Invalid Must enter Search Bar to Search for Books");
            }
            else { 
                grdBooks.DataSource= Books.FindBooks(txtSearch.Text).Tables[0];
                if (grdBooks.Rows.Count == 0) {
                    MessageBox.Show("No Books Exist based on the Search");
                    txtSearch.Select();
                    return;
                }
            grdBooks.Visible=true;
            }
        }
    }
}
