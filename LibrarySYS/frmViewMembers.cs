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
    public partial class frmViewMembers : Form
    {
        public frmViewMembers()
        {
            InitializeComponent();
        }

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void grdMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmViewMembers_Load(object sender, EventArgs e)
        {
            

            grdMembers.DataSource = Member.ViewAllMembers().Tables[0];
            if (grdMembers.Rows.Count == 0) {

                MessageBox.Show("No Members Exist Yet");
                grdMembers.Visible = false;
                btnExitNav.Select();
                return;


            }
        }
    }
}
