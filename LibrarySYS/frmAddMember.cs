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
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void lblAddMember_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddmem_Click(object sender, EventArgs e)
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

               

                !string.IsNullOrWhiteSpace(txtAddress.Text) &&

                !string.IsNullOrWhiteSpace(txtCity.Text) &&

                !string.IsNullOrWhiteSpace(txtCounty.Text) &&

                !string.IsNullOrWhiteSpace(txtPostCode.Text))


                 

            {   if (txtPhoneNumber.Text.Length == 10 && txtPhoneNumber.Text.All(char.IsDigit))
                {


                    Member NewMember = new Member(Convert.ToInt32(txtMemberID.Text),
                        txtForename.Text,
                        txtSurname.Text,
                        txtAddress.Text,
                        dtpDOB.Value,
                        txtPhoneNumber.Text,
                        txtCounty.Text,
                        txtCity.Text,
                        txtPostCode.Text,
                        "Y");

                    if (NewMember.Validate_MemberPhoneNumberExist()) {
                        MessageBox.Show("Invalid !! Phone Number Exists", "Phone Number Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhoneNumber.Focus();
                        return;
                    }
                        NewMember.addMember();

                    MessageBox.Show("Member Added Succesfully", "Member Added !");

                    txtMemberID.Text = Member.GetNextMemberID().ToString("00000");
                    txtForename.Text = "";
                    txtSurname.Text = "";
                    txtCounty.Text = "";
                    txtPhoneNumber.Text = "";
                    txtPostCode.Text = "";
                    txtCity.Text = "";
                    txtAddress.Text = "";
                    dtpDOB.MaxDate = DateTime.Today.AddYears(-10);
                    dtpDOB.Value = DateTime.Today.AddYears(-10);

                }

                else
                {
                    MessageBox.Show("Invalid !! Phone Number must only have 10 Digit", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Select();
                }
            }
            else {
                MessageBox.Show("Invalid !!. Please Enter all Fields", "Invalid Member Credentials",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
         





        }

       

        private void btnUpdateMemberNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember updateMember = new frmUpdateMember();
            updateMember.Show();
        }

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
      
        }

        private void vbvbToolStripMenuItem1_Click(object sender, EventArgs e)
        {
       
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            txtMemberID.Text = Member.GetNextMemberID().ToString("00000");

            txtForename.MaxLength = 20;
            txtCounty.MaxLength = 20;
            txtAddress.MaxLength = 40;
            txtCity.MaxLength = 20;
            txtSurname.MaxLength = 20;
            txtPhoneNumber.MaxLength = 10;
            txtPostCode.MaxLength = 7;


            txtForename.Select();
            dtpDOB.MaxDate = DateTime.Today.AddYears(-10);
            dtpDOB.Value = DateTime.Today.AddYears(-10);

            
        }
     

    

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
