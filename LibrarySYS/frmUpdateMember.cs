using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmUpdateMember : Form
    {

        private Member member;
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        
       

       

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
          mainMenu.Show();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            txtNumberSearch.MaxLength = 10;
            grdMembers.Visible = false;

            txtForename.MaxLength = 20;
            txtCounty.MaxLength = 20;
            txtAddress.MaxLength = 40;
            txtCity.MaxLength = 20;
            txtSurname.MaxLength = 20;
            txtPhoneNumber.MaxLength = 10;
            txtPostCode.MaxLength = 7;


            txtNumberSearch.Select();
            dtpDOB.MaxDate = DateTime.Today.AddYears(-10);
            dtpDOB.Value = DateTime.Today.AddYears(-10);
           
            grdMembers.Visible=false;


          
        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0]. Value);

            member = Member.GetMember(Id);

            txtMemberID.Text = member.Memberid.ToString();
            txtForename.Text = member.Forename;
            txtSurname.Text = member.Surname;
            txtAddress.Text = member.Address;
            txtCity.Text = member.City;
            txtPhoneNumber.Text = member.Phonenumber;
            dtpDOB.Value = member.Dateofbirth;
            txtCounty.Text = member.County;
            txtPostCode.Text = member.Postcode;





        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtForename.Text))
            {
                MessageBox.Show("Forename must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone Number Must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address Line must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCounty.Text))
            {
                MessageBox.Show("County must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("City must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Select();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPostCode.Text))
            {
                MessageBox.Show("PostCode must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostCode.Select();
                return;
            }


            if (!string.IsNullOrWhiteSpace(txtForename.Text) &&

              !string.IsNullOrWhiteSpace(txtSurname.Text) &&

              !string.IsNullOrWhiteSpace(txtCounty.Text) &&

              !string.IsNullOrWhiteSpace(txtPhoneNumber.Text) &&

              dtpDOB.Value != null &&

              !string.IsNullOrWhiteSpace(txtAddress.Text) &&

              !string.IsNullOrWhiteSpace(txtCity.Text) &&

              !string.IsNullOrWhiteSpace(txtCounty.Text) &&

              !string.IsNullOrWhiteSpace(txtPostCode.Text))

            {
                if (txtPhoneNumber.Text.Length == 10 && txtPhoneNumber.Text.All(char.IsDigit))
                {
                    member.Memberid = Convert.ToInt32(txtMemberID.Text);
                    member.Forename = txtForename.Text;
                    member.Surname = txtSurname.Text;
                    member.Phonenumber = txtPhoneNumber.Text;
                    member.Address = txtAddress.Text;
                    member.City = txtCity.Text;
                    member.County = txtCounty.Text;
                    member.Postcode = txtPostCode.Text;
                    member.Dateofbirth = dtpDOB.Value;


                    if (member.Validate_MemberPhoneNumberExist()) {
                        MessageBox.Show("Invalid !! Phone Number Exists to Someone else ", "Phone Number Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhoneNumber.Focus();
                        return;
                    }

                    member.UpdateMember();

                    MessageBox.Show("Member Updated Succesfully", "Member Updated !");
                    txtForename.Text = "";
                    txtSurname.Text = "";
                    txtCounty.Text = "";
                    txtPhoneNumber.Text = "";
                    txtPostCode.Text = "";
                    txtCity.Text = "";
                    txtAddress.Text = "";
                    dtpDOB.MaxDate = DateTime.Today.AddYears(-10);
                    dtpDOB.Value = DateTime.Today.AddYears(-10);
                    txtMemberID.Text = "";

                    grdMembers.Visible = false;

                    txtNumberSearch.Text = "";
                    txtNumberSearch.Focus();
                }

                else
                {
                    MessageBox.Show("Invalid !! Phone Number must only have 10 Digit", "Invalid Phone Number");
                    txtPhoneNumber.Select();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid !!. Please Enter all Fields", "Invalid Member Credentials");
            }
           
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
                        MessageBox.Show("No Members Available to Update as None Exist yet ... " + "\n\n Please Contact Your Administrator");
                        txtNumberSearch.Focus();
                        return;
                    }
                    grdMembers.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid !! , Phone Number must be digits", "Error Empty !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else {
                MessageBox.Show("Invalid!! , The search Bar cannot remain Empty to Search","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void grdMembers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
