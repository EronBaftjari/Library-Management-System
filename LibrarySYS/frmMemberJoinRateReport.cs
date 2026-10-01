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
    public partial class frmMemberJoinRateReport : Form
    {
        public frmMemberJoinRateReport()
        {
            InitializeComponent();
        }

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu MainMenu = new frmMainMenu();
            MainMenu.Show();
        }

        private void frmMemberJoinRateReport_Load(object sender, EventArgs e)
        {

            chtMemberJoinRate.Visible = false;
            DataSet ds1 = LoanBooks.getYears();
            cboMemberJoinRate.Items.Clear();
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                cboMemberJoinRate.Items.Add(ds1.Tables[0].Rows[i][0].ToString());

            }
            cboMemberJoinRate.SelectedIndex = -1;

   

        }

        private void grdMemberJoins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        
        }

        private void btnAnylise_Click(object sender, EventArgs e)
        {
            if (cboMemberJoinRate.SelectedIndex == -1) {
                MessageBox.Show("Please choose a Year");
                cboMemberJoinRate.Select();
                return;
            }
       
            

            int year = Convert.ToInt32(cboMemberJoinRate.SelectedItem);


            string query = "SELECT COUNT(*), TO_CHAR(JoinDate,'MM') FROM MEMBERS WHERE TO_CHAR(JoinDate,'YYYY') = '" + year + "'" + " GROUP BY TO_CHAR(JoinDate,'MM') " + "ORDER BY TO_CHAR(JoinDate,'MM')";

            DataSet ds = Database.ExecuteMultiRowQuery(query);

            string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUNE", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

            int[] totals = new int[12];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                int COUNT = Convert.ToInt32(ds.Tables[0].Rows[i][0]);

                int monthIndex = Convert.ToInt32(ds.Tables[0].Rows[i][1]) - 1;

                totals[monthIndex] = COUNT;

            }
            chtMemberJoinRate.Series[0].Points.DataBindXY(months, totals);

            chtMemberJoinRate.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtMemberJoinRate.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chtMemberJoinRate.Series[0].LegendText = "Member Join rate";

            if (ds.Tables[0].Rows.Count == 0) {
                chtMemberJoinRate.Series[0].Points.Clear();
                chtMemberJoinRate.Visible= false;
                MessageBox.Show("No Member Join Data is found ");
                cboMemberJoinRate.Select();
                return;
            }
            chtMemberJoinRate.Visible = true;
        }

      
    }
}
