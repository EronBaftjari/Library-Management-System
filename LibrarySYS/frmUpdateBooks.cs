using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmUpdateBooks : Form
    {
        private Books books;
        public frmUpdateBooks()
        {
            InitializeComponent();
        }
        //this is my test for GIT
        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void frmUpdateBooks_Load(object sender, EventArgs e)
        {
            dtpPublishdate.MaxDate = DateTime.Today;
            dtpPublishdate.Value = DateTime.Today;


            txtTitle.Select();
            txtAuthor.MaxLength = 20;
            txtISBN.MaxLength = 10;
            txtTitle.MaxLength = 30;
            txtBookID.ReadOnly = true;

            grdBooks.Visible = false;
           
        }

        private void grdBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          



            int Id = Convert.ToInt32(grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[0].Value);

            books = Books.getBook(Id);

            txtBookID.Text = books.BookID.ToString();
            txtAuthor.Text = books.Author.ToString();
            txtISBN.Text = books.ISBN.ToString();
            txtTitle.Text = books.Title.ToString();
            dtpPublishdate.Value = books.PublishedDate;

            DataSet ds = Genre.getGenres();
            int GenreIndex = 0;
            cboGenree.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {

                cboGenree.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);

                if (ds.Tables[0].Rows[i][0].Equals(books.GenreID)) {
                    GenreIndex = i;
                }
            }
            cboGenree.SelectedIndex = GenreIndex;

      

        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Book Title must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Book Author must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Book ISBN must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtISBN.Select();
                return;
            }
            if (cboGenree.SelectedIndex == -1)
            {
                MessageBox.Show("Book Genre must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGenree.Select();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTitle.Text) &&

                !string.IsNullOrWhiteSpace(txtAuthor.Text) &&

                !string.IsNullOrWhiteSpace(txtISBN.Text) &&

                !string.IsNullOrWhiteSpace(txtBookID.Text) &&

                cboGenree.SelectedIndex != -1)

            {


                if (txtISBN.Text.Length == 10 && txtISBN.Text.All(char.IsDigit))
                {
                    books.BookID = Convert.ToInt32(txtBookID.Text);
                   books.Author = txtAuthor.Text;
                    books.ISBN = txtISBN.Text;
                    books.PublishedDate = dtpPublishdate.Value;
                    books.GenreID = Convert.ToInt32(cboGenree.Text.Substring(0, 2));
                    books.Title = txtTitle.Text;

                    if (books.Validate_BooksISBN_Exists()) {
                        MessageBox.Show("ISBN already exists ", " Error in Updating Book  Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtISBN.Select();
                        return;
                    }

                    books.updateBooks();


                    MessageBox.Show("Book Succesfully Updated ","Update Details",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtAuthor.Text = "";
                    cboGenree.SelectedIndex = -1;
                    txtISBN.Text = "";
                    txtTitle.Text = "";
                    dtpPublishdate.Value = DateTime.Today;
                    txtBookID.Text = "";
                    txtTitlee.Select();

                    grdBooks.Visible = false;
                }


                else
                {
                    MessageBox.Show("ISBN must have exactly 10 Digits Only", "Invalid ISBN  Details Eneterd ! ");
                }
            }
            else
            {
                MessageBox.Show("Must Fill in All text Boxes ! ", "Invalid Book Details ");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitlee.Text))
            {

                MessageBox.Show("Please Enter Title if u want to search Book ", "Unsuccesfull Search", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
            else {

                grdBooks.DataSource = Books.FindBooks(txtTitlee.Text).Tables[0];
                if (grdBooks.Rows.Count == 0) {

                    MessageBox.Show("No Results with the Search of the Title ", "Unsuccesfull Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitlee.Select();
                    return;
                }
                grdBooks.Visible = true;
            }
                txtTitlee.Text = "";
           
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void lblBookID_Click(object sender, EventArgs e)
        {

        }

        private void dtpPublishdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
