using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }


public Genre(int genreID,string genreName) {


        GenreID=genreID;
        GenreName=genreName;
        }

        public static DataSet getGenres() {

            String sqlQuery = "SELECT * FROM Genres ORDER BY GenreID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}
