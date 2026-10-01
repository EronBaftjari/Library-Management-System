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
    public partial class frmDeleteMember : Form
    {
        public frmDeleteMember()
        {
            InitializeComponent();
        }

       

        

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

       

        private void frmDeleteMember_Load(object sender, EventArgs e)
        {
             
           grdMembers.Visible = false;

          

            }
        

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {




            if ((!string.IsNullOrWhiteSpace(txtMemberID.Text)) && txtMemberID.Text.All(char.IsDigit))
            {
                Member MemberToDelete = new Member();

                int MemberID = Convert.ToInt32(txtMemberID.Text);

                MemberToDelete.Memberid = MemberID;

                MemberToDelete.deleteMember();


                

                MessageBox.Show("Member Succesfly Deleted !", "Delete Member Confirmation",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMemberID.Text = "";
                txtNumberSearch.Text = "";
                txtNumberSearch.Focus();
                grdMembers.Visible=false;
                
            }
            else {
                MessageBox.Show("Pleaase Enter MemberID", "Error Invalid Credentials Entered ");
            }
            
        }

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            int Id = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value);
            txtMemberID.Text =Id.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtNumberSearch.Text)))
            {

                if (txtNumberSearch.Text.All(char.IsDigit))
                {

                    

                    grdMembers.DataSource = Member.FindMembers(txtNumberSearch.Text).Tables[0];

                    if (grdMembers.Rows.Count == 0)
                    {

                        MessageBox.Show("Member Not Found", "Empty !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumberSearch.Focus();
                        return;

                    }
                    else
                    {
                        grdMembers.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid !! , Phone Number must be digits", "Error Empty !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Invalid!! , The search Bar cannot remain Empty to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
