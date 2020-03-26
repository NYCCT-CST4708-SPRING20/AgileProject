using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileProject.DAO
{
    class CCDAO
    {
        /// <summary>
        ///  Get Connection String from Configuration
        /// </summary>
        private readonly string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        /// <summary>
        /// Save payment information for the next purchases.
        /// </summary>
        /// <param name="accountID">id of the account</param>
        /// <param name="ccNum">credit card number</param>
        /// <param name="date">creadit card expire date</param>
        /// <param name="name">name of the credit card holder</param>
        /// <param name="code">security code</param>
        /// <param name="street1">address of the billing address</param>
        /// <param name="street2">optional address of the billing address</param>
        /// <param name="city">city of the billing address</param>
        /// <param name="state">state of the billing address</param>
        /// <param name="postalCode">postal code of the billing address</param>
        public void SaveCC(int accountID, long ccNum, int date, String name, Int16 code, String street1, String street2, String city, String state, int postalCode)
        {
            MySqlCommand comm = new MySqlCommand("INSERT INTO CCARD(ACCOUNT_ID, CC_NUMBER, CC_EXP_DATE, CC_NAME, SECURITY_CODE, STREET_1, STREET_2, CITY, STATE, POSTAL_CODE) "
                                               + " VALUES (@ACCOUNTID, @CCNUM, @CCEXP, @CCNAME, @CODE, @ST1, @ST2, @CITY, @STATE, @ZIPCODE)");
            comm.Parameters.AddWithValue("@ACCOUNTID", accountID);
            comm.Parameters.AddWithValue("@CCNUM", ccNum);
            comm.Parameters.AddWithValue("@CCEXP", date);
            comm.Parameters.AddWithValue("@CCNAME", name);
            comm.Parameters.AddWithValue("@CODE", code);
            comm.Parameters.AddWithValue("@ST1", street1);
            comm.Parameters.AddWithValue("@ST2", street2);
            comm.Parameters.AddWithValue("@CITY", city);
            comm.Parameters.AddWithValue("@STATE", state);
            comm.Parameters.AddWithValue("@ZIPCODE", postalCode);
            UpdateCC(ref comm);
        }

        /// <summary>
        /// Remove the saved payment information
        /// </summary>
        /// <param name="accountID">account id of the user</param>
        public void RemoveCC(int accountID)
        {
            MySqlCommand comm = new MySqlCommand("DELETE FROM CCARD WHERE ACCOUNT_ID = @ACCOUNTID");
            comm.Parameters.AddWithValue("@ACCOUNTID", accountID);
            UpdateCC(ref comm);
        }

        /// <summary>
        /// Update function for the credit card database
        /// </summary>
        /// <param name="comm">SQL statement for the credit card database</param>
        private void UpdateCC(ref MySqlCommand comm)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            comm.Connection = conn;
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

        /// <summary>
        /// check is there a saved payment method for the account
        /// </summary>
        /// <param name="accountID">account id of the user</param>
        /// <returns>true/false of the saved payment method</returns>
        public Boolean IsSaved(int accountID)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand comm = new MySqlCommand("SELECT COUNT(*) FROM CCARD WHERE ACCOUNT_ID = @ACCOUNTID", conn);
            comm.Parameters.AddWithValue("@ACCOUNTID", accountID);

            Boolean saved = false;

            try
            {
                conn.Open();
                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    saved = reader.GetInt16(0) == 1 ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            return saved;
        }
    }
}
