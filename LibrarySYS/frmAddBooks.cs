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
    public partial class frmAddBooks : Form
    {
        public frmAddBooks()
        {
            InitializeComponent();
        }
        private void frmAddBooks_Load(object sender, EventArgs e)
        {
            txtBookID.Text = Books.GetNextBookID().ToString("0000");

            txtTitle.Select();
            txtAuthor.MaxLength = 20;
            txtISBN.MaxLength = 10;
            txtTitle.MaxLength = 30;
            dtpPublishedDate.MaxDate = DateTime.Today;
            dtpPublishedDate.Value = DateTime.Today;

            DataSet ds = Genre.getGenres();
            cboGenre.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboGenre.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            
            }

        }
        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
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
                MessageBox.Show("Book Title must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtISBN.Select();
                return;
            }
            if (cboGenre.SelectedIndex==-1)
            {
                MessageBox.Show("Book Genre must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGenre.Select();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTitle.Text) &&

                !string.IsNullOrWhiteSpace(txtAuthor.Text) &&

                !string.IsNullOrWhiteSpace(txtISBN.Text) &&

                cboGenre.SelectedIndex != -1) 

            {


                if (txtISBN.Text.Length == 10 && txtISBN.Text.All(char.IsDigit)) {


                    Books aBook = new Books(Convert.ToInt32(txtBookID.Text),
                        Convert.ToInt32(cboGenre.Text.Substring(0,1)),
                        txtTitle.Text,
                        txtAuthor.Text,
                        txtISBN.Text,
                        dtpPublishedDate.Value,
                        "Y");

                    if (!aBook.Validate_BooksISBN_Exists())
                    {
                        aBook.AddBook();
                        MessageBox.Show("Book Succesfully Added ");
                        txtBookID.Text = Books.GetNextBookID().ToString("0000");
                        txtAuthor.Text = "";
                        cboGenre.SelectedIndex = -1;
                        txtISBN.Text = "";
                        txtTitle.Text = "";
                        dtpPublishedDate.MaxDate = DateTime.Today.AddYears(-10);
                        dtpPublishedDate.Value = DateTime.Today.AddYears(-10);
                        txtTitle.Select();

                    }
                    else {
                        MessageBox.Show("Books ISBN Already exists ", "Invalid ISBN  Details Eneterd ! ");
                        txtISBN.Select();
                    }
                }


                else
                {
                    MessageBox.Show("ISBN must have exactly 10 Digits Only", "Invalid ISBN  Details Eneterd ! ");
                    txtISBN.Select();
                }
            }
            else {
                MessageBox.Show("Invalid Details Enterd ! ", "Invalid Book Details ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
