using AgileProject.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileProject.DAO
{
    class MyListDAO
    {

        /// <summary>
        ///  Get Connection String from Configuration
        /// </summary>
        private readonly string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        /// <summary>
        /// Get user's movie list
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public List<Movie> GetMyList(int accountID)
        {
            List<Movie> list = new List<Movie>();

            MySqlConnection conn = new MySqlConnection();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT MOVIE_ID, MOVIE_NAME, GENRE, PURCHASE_PRICE FROM MOVIE "
                            + " WHERE MOVID_ID IN (SELECT MOVIE_ID FROM MYLIST WHERE ACCOUNT_ID = @ACCOUNTID)";
            comm.Parameters.AddWithValue("@ACCOUNTID", accountID);

            try
            {
                conn.Open();
                comm.Connection = conn;
                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new Movie(
                                reader.GetString("movie_id"),
                                reader.GetString("movie_name"),
                                reader.GetString("genre"),
                                reader.GetDouble("purchase_price")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            return null;
        }

        /// <summary>
        /// Add a movie to user's movie list
        /// </summary>
        /// <param name="accountID">account id of the user</param>
        /// <param name="movieID">movie id of a movie</param>
        public void AddToList(int accountID, String movieID)
        {
            MySqlCommand comm = new MySqlCommand("INSERT INTO MYLIST VALUES (@ACCOUNTID, @MOVIEID)");
            comm.Parameters.AddWithValue("@ACCOUNTID", accountID);
            comm.Parameters.AddWithValue("@MOVIEID", movieID);
            UpdateMyList(ref comm);
        }

        /// <summary>
        /// Remove a movie from user's movie list
        /// </summary>
        /// <param name="accountID">account id of the user</param>
        /// <param name="movieID">movie id of a movie</param>
        public void DelFromList(int accountID, String movieID)
        {
            MySqlCommand comm = new MySqlCommand("DELETE FROM MYLIST WHERE ACCOUNT_ID = @ACCOUNT AND MOVIE_ID = @MOVIEID");
            comm.Parameters.AddWithValue("@ACCOUNTID", accountID);
            comm.Parameters.AddWithValue("@MOVIEID", movieID);
            UpdateMyList(ref comm);
        }

        /// <summary>
        /// Update function of the MyList Database
        /// </summary>
        /// <param name="comm">SQL statement for the MyList Database</param>
        private void UpdateMyList(ref MySqlCommand comm)
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
        /// Check is the movie already contained in user's list
        /// </summary>
        /// <param name="accountID">account id of the user</param>
        /// <param name="movieID">movie id of a movie</param>
        /// <returns>true/false of the movie is in the list</returns>
        public Boolean Contains(int accountID, String movieID)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand comm = new MySqlCommand("SELECT COUNT(*) FROM MYLIST WHERE ACCOUNT_ID = @ACCOUNTID AND MOVIE_ID = @MOVIEID", conn);
            comm.Parameters.AddWithValue("@ACCOUNTID", accountID);
            comm.Parameters.AddWithValue("@MOVIEID", movieID);

            Boolean contained = false;

            try
            {
                conn.Open();
                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    contained = reader.GetInt16(0) == 1 ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            return contained;
        }
    }
}
