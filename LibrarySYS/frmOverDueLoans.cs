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
    public partial class frmOverDueLoans : Form
    {
        public frmOverDueLoans()
        {
            InitializeComponent();
        }

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void frmOverDueLoans_Load(object sender, EventArgs e)
        {
    grdOverDueLoans.DataSource = LoanBooks.overDueLoans().Tables[0];

            if (grdOverDueLoans.Rows.Count == 0) {

                MessageBox.Show("There Are no Over Due Loans");
                grdOverDueLoans.Visible = false;
                return;
            
            }
        }
    }
}
