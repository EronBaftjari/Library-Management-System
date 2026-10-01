using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibrarySYS
{
    public class LoanBooks
    {

        public int LoanID { get; set; }
        public int BookID { get; set; }


        public LoanBooks(int loanID, int bookID)
        {

            LoanID = loanID;
            BookID = bookID;

        }

        public LoanBooks() { 
        
        this.BookID = 0;
         this.LoanID = 0;

        }

        public override string ToString()
        {

            return "Book ID : " + BookID + "\t LoanID : " + LoanID;
        }

        public void LoanedBooks()
        {

            string sql = "INSERT INTO LoanBooks(LoanID,BookID,ReturnDate) VALUES(" + LoanID + "," + BookID + ", NULL)";

            string sql2 = "UPDATE BOOKS SET isAvailable = 'N' WHERE BookID = " + this.BookID;

            Database.ExecuteNonQuery(sql);
            Database.ExecuteNonQuery(sql2);

        }

        public void ReturnBooks()
        {

            string sql = "UPDATE LoanBooks SET ReturnDate = SYSDATE WHERE LoanID = " + this.LoanID + " AND BookID = " + this.BookID;

            string sql2 = "UPDATE Books SET isAvailable = 'Y' WHERE BookID = " + this.BookID;

            Database.ExecuteNonQuery(sql);
            Database.ExecuteNonQuery(sql2);



        }
        public static DataSet getYears()
        {

            string sqlQuery = "SELECT DISTINCT TO_CHAR(LoanDate,'YYYY') FROM LOANS ORDER BY TO_CHAR(LoanDate,'YYYY')";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet overDueLoans()
        {

            string sqlQuery = "SELECT l.LoanID,m.Forename,m.Surname,b.title,l.LoanDate,l.DueDate FROM Loans l" +
                    " INNER JOIN Members m ON l.MemberID = m.MemberID" +
                    " INNER JOIN LoanBooks lb ON l.LoanID = lb.LoanID" +
                    " INNER JOIN Books b ON lb.BookID = b.BookID" +
                    " WHERE lb.ReturnDate IS NULL AND l.DueDate < SYSDATE";

            return Database.ExecuteMultiRowQuery(sqlQuery);

        }

    }

}
