using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileProject.DAO
{
    class Order
    {
        /// <summary>
        ///  Get Connection String from Configuration
        /// </summary>
        private readonly string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        /// <summary>
        /// New Order of the movie
        /// </summary>
        /// <param name="accountID">account id of the user</param>
        /// <param name="movieID">movie id of the movie</param>
        /// <param name="ccNum">credit card number</param>
        /// <param name="expDate">creadit card expire date</param>
        /// <param name="name">name of the credit card holder</param>
        /// <param name="street1">address of the billing address</param>
        /// <param name="street2">optional address of the billing address</param>
        /// <param name="city">city of the billing address</param>
        /// <param name="state">state of the billing address</param>
        /// <param name="postalCode">postal code of the billing address</param>
        public void NewOrder(int accountID, String movieID, long ccNum, int expDate, String name, String street1, String street2, String city, String state, int postalCode)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand comm = new MySqlCommand("INSERT INTO ORDER(ACCOUNT_ID, MOVIE_ID, ORDER_DATE, CC_NUMBER, CC_EXP_DATE, CC_NAME, STREET_1, STREET_2, CITY, STATE, POSTAL_CODE) "
                                               + " VALUES (@ACCOUNTID, @MOVIEID, @DATE, @CCNUM, @CCEXP, @CCNAME, @ST1, @ST2, @CITY, @STATE, @ZIPCODE)", conn);
            comm.Parameters.AddWithValue("@ACCOUNTID", accountID);
            comm.Parameters.AddWithValue("@MOVIEID", movieID);
            comm.Parameters.AddWithValue("@DATE", DateTime.Now.ToString("YYYY-MM-DD hh:mm:ss"));
            comm.Parameters.AddWithValue("@CCNUM", ccNum);
            comm.Parameters.AddWithValue("@CCEXP", expDate);
            comm.Parameters.AddWithValue("@CCNAME", name);
            comm.Parameters.AddWithValue("@ST1", street1);
            comm.Parameters.AddWithValue("@ST2", street2);
            comm.Parameters.AddWithValue("@CITY", city);
            comm.Parameters.AddWithValue("@STATE", state);
            comm.Parameters.AddWithValue("@ZIPCODE", postalCode);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
