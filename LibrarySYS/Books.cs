using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public class Books
    {
        public int BookID { get; set; }
        public int GenreID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }

        public string IsAvailable { get; set; }



        public Books() {

            this.BookID = 0;
            this.GenreID = 0;
            this.Title = "";
            this.Author = "";
            this.ISBN = "";
            this.PublishedDate = DateTime.Now;
            this.IsAvailable = "N";


        }
        public Books(int bookID, int genreID, string title, string author, string isbn, DateTime publishedDate, string isAvailable) {

            BookID = bookID;
            GenreID = genreID;
            Title = title;
            ISBN = isbn;
            PublishedDate = publishedDate;
            Author = author;
            IsAvailable = isAvailable;


        }

        public override string ToString() {

            return "Book ID : " + BookID + "\tGenre ID : " + GenreID + "\tTitle : " + Title + "\t ISBN : " + ISBN + "\t Is Available : " + IsAvailable + "\t Author : " + Author;
        }

        public void AddBook() {

            string SQLQuery = "INSERT INTO Books Values (" +
                    BookID + "," +
                    GenreID + ",'" +
                    Title + "', '" +
                    Author + "', '" +
                    ISBN + "', TO_DATE('" + this.PublishedDate.ToString("dd-MM-yyyy") + "','DD-MM-YYYY'),'" +
                    IsAvailable + "')";

            Database.ExecuteNonQuery(SQLQuery);



        }

        public static int GetNextBookID() {

            string sqlQuery = "SELECT MAX (BookID) FROM Books";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int nextBookID;

            dr.Read();

            if (dr.IsDBNull(0))
            {

                nextBookID = 1;
            }
            else {
                nextBookID = dr.GetInt32(0) + 1;
            }
            dr.Close();
            return nextBookID;
        }

        public bool Validate_BooksISBN_Exists() {

            OracleConnection conn = Database.OpenConnection();

            string sqlQuery = "SELECT COUNT(*) FROM Books Where ISBN = '" + ISBN + "'" + "AND BookID !=" + BookID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            int rows = Convert.ToInt32(cmd.ExecuteScalar());

            if (rows > 0)
            {

                return true;
            }
            else
            {

                return false;
            }

        }

        public static Books getBook(int Id) {

            string sqlQuery = "SELECT * FROM BOOKS WHERE BookID = " + Id;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();

            int BookID = dr.GetInt32(0);
            int GenreID = dr.GetInt32(1);
            string Title = dr.GetString(2);
            string Author = dr.GetString(3);
            string ISBN = dr.GetString(4);
            DateTime PublishDate = dr.GetDateTime(5);
            string isAvailable = dr.GetString(6);

            return new Books(BookID, GenreID, Title, Author, ISBN, PublishDate, isAvailable);
        }

        public static DataSet FindBooks(String Title) {

            string sqlQuery = "SELECT BookID,GenreID,Title,ISBN,Author FROM BOOKS " + "WHERE Title LIKE '%" + Title + "%' AND isAvailable = 'Y' ORDER BY BookID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public void updateBooks() {

            string sqlQuery = "UPDATE Books SET Title ='" + this.Title + "'," + "Author ='" + this.Author + "'," + "PublishedDate = TO_DATE('" + this.PublishedDate.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), " +
                  "GenreID = " + this.GenreID + "WHERE BookID = " + this.BookID;
            Database.ExecuteNonQuery(sqlQuery);
        }




        public void deleteBook() {

            string sqlQuery = "UPDATE Books SET isAvailable = 'N' WHERE BookID = " + this.BookID;
            Database.ExecuteNonQuery(sqlQuery);
        }





    
    public static DataSet ViewAllBooks() {

            string sqlQuery = "SELECT * FROM BOOKS";
            return Database.ExecuteMultiRowQuery(sqlQuery);

        }

    }
}


