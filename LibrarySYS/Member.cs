using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibrarySYS
{
    public class Member
    {
        //Properties of the class

        public int Memberid { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Phonenumber { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Active { get; set; }




        public Member()
        {
            this.Memberid = 0;
            this.Forename = "";
            this.Surname = "";
            this.Address = "";
            this.Dateofbirth = DateTime.Now;
            this.Phonenumber = "";
            this.County = "";
            this.City = "";
            this.Postcode = "";
            this.Active = "N";


        }
        public Member(int MemberID, string forename, string surname, string address, DateTime dateofbirth, string phonenumber, string county, string city, string postcode, string active)
        {
            Memberid = MemberID;
            Forename = forename;
            Surname = surname;
            Address = address;
            Dateofbirth = dateofbirth;
            Phonenumber = phonenumber;
            County = county;
            City = city;
            Postcode = postcode;
            Active = active;

        }
        public override string ToString()

        {
            return "Member ID: " + Memberid + "\tForename " + Forename + "\tSurname: " + Surname +
               "\nAddress: " + Address + "\nDate of Birth: " + Dateofbirth + "\tPhone Number: " + Phonenumber +
               "\tCounty : " + County + "\n City : " + City + "\n PostCode : " + Postcode + "\n Active : " + Active;
        }

        public void addMember()
        {

            string sql = "INSERT INTO MEMBERS  Values (" +
                    this.Memberid + ",'" +
                    this.Forename + "','" +
                    this.Surname + "', TO_DATE('" + this.Dateofbirth.ToString("dd-MM-yyyy") + "','DD-MM-YYYY'),'" +
                    this.Phonenumber + "','" +
                    this.Address + "','" +
                    this.County + "','" +
                    this.City + "','" +
                    this.Postcode + "','" +
                    this.Active + "',SYSDATE)";

            Database.ExecuteNonQuery(sql);




        }

        public void deleteMember()
        {

            string sqlQuery = "UPDATE MEMBERS SET Active = 'N' WHERE MemberID = " + this.Memberid;

            Database.ExecuteNonQuery(sqlQuery);

        }

        public void UpdateMember()
        {

            string sqlQuery = "UPDATE MEMBERS SET Forename = '" + this.Forename + "'," +
                              "Surname ='" + this.Surname + "'," + "DateOfBirth = TO_DATE('" + this.Dateofbirth.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), " +
                              "PhoneNumber = '" + this.Phonenumber + "'," + "Address = '" + this.Address + "'," + "County = '" + this.County + "'," +
                              "City = '" + this.City + "'," + "PostCode = '" + this.Postcode + "'  WHERE MemberID = " + this.Memberid;

            Database.ExecuteNonQuery(sqlQuery);



        }

        public static int GetNextMemberID()
        {

            string sqlQuery = "SELECT MAX (MemberID) FROM MEMBERS";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int nextMemID;

            dr.Read();

            if (dr.IsDBNull(0))
            {

                nextMemID = 1;
            }
            else
            {

                nextMemID = dr.GetInt32(0) + 1;
            }

            dr.Close();

            return nextMemID;

        }

    

        public static DataSet FindMembers(String PhoneNumber)
        {

            string sqlQuery = "SELECT MemberID, Forename,Surname,PhoneNumber,Address FROM MEMBERS " + "WHERE PhoneNumber LIKE '%" + PhoneNumber + "%' AND Active = 'Y' ORDER BY PhoneNumber";

            return Database.ExecuteMultiRowQuery(sqlQuery);

        }

        public static Member GetMember(int id)
        {

            string SqlQuery = "SELECT * FROM MEMBERS WHERE MemberID = " + id;

            OracleDataReader dr = Database.ExecuteSingleRowQuery(SqlQuery);

            dr.Read();

            int MemberID = dr.GetInt32(0);
            string forename = dr.GetString(1);
            string surename = dr.GetString(2);
            DateTime DateOfBirth = dr.GetDateTime(3);
            string phoneNumber = dr.GetString(4);
            string Address = dr.GetString(5);
            string county = dr.GetString(6);
            string city = dr.GetString(7);
            string postCode = dr.GetString(8);
            string active = dr.GetString(9);

            return new Member(MemberID, forename, surename, Address, DateOfBirth, phoneNumber, county, city, postCode, active);



        }

        public bool Validate_MemberPhoneNumberExist()
        {
            OracleConnection conn = Database.OpenConnection();

            string SqlQuery = "SELECT COUNT(*) FROM MEMBERS Where PhoneNumber = '" + this.Phonenumber + "'" + "AND MemberID != " + this.Memberid;

            OracleCommand cmd = new OracleCommand(SqlQuery, conn);

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

        public static DataSet getJoinRate()
        {

            string sqlQuery = "SELECT DISTINCT TO_CHAR(JoinDate,'YYYY') FROM Members ORDER BY TO_CHAR(JoinDate,'YYYY')";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static DataSet ViewAllMembers()
        {
            
            string sqlQuery = "SELECT * FROM Members";

            return Database.ExecuteMultiRowQuery(sqlQuery);

        }

    }
}