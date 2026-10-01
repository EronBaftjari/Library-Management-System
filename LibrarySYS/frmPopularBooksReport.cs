using System;
using System.Collections;
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
    public partial class frmPopularBooksReport : Form
    {
        public frmPopularBooksReport()
        {
            InitializeComponent();
        }

        private void btnExitNav_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void frmPopularBooksReport_Load(object sender, EventArgs e)
        {

            chtPopularBooksAnylysis.Visible = false;

            DataSet ds1 = LoanBooks.getYears();
            cboPopularBooksYear.Items.Clear();
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                cboPopularBooksYear.Items.Add(ds1.Tables[0].Rows[i][0].ToString());

            }
       



        }

        



        

        private void btnShowPopularBooks_Click(object sender, EventArgs e)
        {

            int year = Convert.ToInt32(cboPopularBooksYear.SelectedItem);



            string query = "SELECT b.Title,Count(lb.BookID) FROM LoanBooks lb" + " INNER JOIN Loans l on lb.LoanID = l.LoanID" +
                " INNER JOIN Books B on lb.BookID = b.BookID " + "WHERE TO_CHAR(l.LoanDate, 'YYYY')  = '" + year + "' GROUP BY b.Title  FETCH FIRST 5 ROWS ONLY";
            DataSet ds = Database.ExecuteMultiRowQuery(query);


            //Took Help From the Document u Gave and integrated this

            string[] BookTitle = new string[ds.Tables[0].Rows.Count];
            int[] LoanCount = new int[ds.Tables[0].Rows.Count];


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                BookTitle[i] = ds.Tables[0].Rows[i][0].ToString();

                LoanCount[i] = Convert.ToInt32(ds.Tables[0].Rows[i][1]);

            }
            // i copied the document u gave 
            chtPopularBooksAnylysis.Series[0].Points.DataBindXY(BookTitle, LoanCount);

            chtPopularBooksAnylysis.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtPopularBooksAnylysis.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chtPopularBooksAnylysis.Series[0].LegendText = "Most Popular Books";


            if (cboPopularBooksYear.SelectedIndex != null)
            {
                if (ds.Tables[0].Rows.Count == 0)
                {
                    chtPopularBooksAnylysis.Series[0].Points.Clear();
                   chtPopularBooksAnylysis.Visible = false;
                    MessageBox.Show("No Member Join Data is found ");
                    cboPopularBooksYear.Select();
                    return;
                }
                    chtPopularBooksAnylysis.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Please Choose a Year it cannot remain Empty");
            }
        }

       
    }
}
