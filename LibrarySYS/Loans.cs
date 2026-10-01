using LibrarySYS;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    public class Loans
    {

        public int LoanID { get; set; }



        public int MemberID { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime DueDate { get; set; }


        public Loans()
        {


            this.LoanID = 0;
            this.MemberID = 0;
            this.LoanDate = DateTime.Now;
            this.DueDate = DateTime.Now;


        }
        public Loans(int loanID, int memberID)
        {
            LoanID = loanID;

            MemberID = memberID;


        }

      

        public override string ToString()
        {
            return "LoanID : " + LoanID + "\tMemberID: " + MemberID + "\tLoanDate : " + LoanDate + "\t DueDate : " + DueDate;
        }

        public static int GetNextLoanID()
        {

            string sqlQuery = "SELECT MAX (LoanID) FROM Loans";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int nextLoanID;

            dr.Read();

            if (dr.IsDBNull(0))
            {

                nextLoanID = 1;

            }
            else
            {

                nextLoanID = dr.GetInt32(0) + 1;
            }

            dr.Close();

            return nextLoanID;
        }

        public void BooksLoaned()
        {

            string SQLquery = "INSERT INTO Loans (LoanID,MemberID) VALUES(" + this.LoanID + "," + this.MemberID + ")";

            Database.ExecuteNonQuery(SQLquery);

        }

        public static DataSet ViewCurrentMembersLoans(int MemberID)
        {


            string sqlQuery = "SELECT Loans.LoanID,Loans.MemberID,Loans.LoanDate,Loans.DueDate,LoanBooks.BookID,Books.Title,LoanBooks.ReturnDate " +
                "FROM LOANS INNER JOIN LoanBooks ON Loans.LoanID = LoanBooks.LoanID " +
                "INNER JOIN Books on LoanBooks.BookID = Books.BookID " +
                "WHERE Loans.MemberID = " + MemberID  + " AND LoanBooks.ReturnDate IS NULL ";



            return Database.ExecuteMultiRowQuery(sqlQuery);


        }

       
    }
}

