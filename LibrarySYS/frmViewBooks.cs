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
    public partial class frmViewBooks : Form
    {
        public frmViewBooks()
        {
            InitializeComponent();
        }

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void grdBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmViewBooks_Load(object sender, EventArgs e)
        {
            grdBooks.DataSource = Books.ViewAllBooks().Tables[0];

            if (grdBooks.Rows.Count == 0) {

                MessageBox.Show("No Books Exist as Of Right now ");
                    grdBooks.Visible = false;
                btnExitNav.Select();
                return;
            }
        }
    }
}
