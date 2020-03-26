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
    class MovieDAO
    {

        /// <summary>
        ///  Get Connection String from Configuration
        /// </summary>
        private readonly string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        /// <summary>
        /// Get all basic movie data from the database.
        /// </summary>
        /// <returns>A list of Movie objects</returns>
        public List<Movie> GetAllMovieList()
        {
            List<Movie> list = new List<Movie>();
            MySqlCommand comm = new MySqlCommand("SELECT MOVIE_ID, MOVIE_NAME, GENRE, PURCHASE_PRICE FROM MOVIE");
            this.getMovieListData(ref comm, ref list);
            return list;
        }

        /// <summary>
        /// Get all movies of a specific genre from the database
        /// </summary>
        /// <param name="genre">Movie Genre String</param>
        /// <returns>A list of Movie objects</returns>
        public List<Movie> GetGenreMoviesList(String genre)
        {
            List<Movie> list = new List<Movie>();
            MySqlCommand comm = new MySqlCommand("SELECT MOVIE_ID, MOVIE_NAME, GENRE, PURCHASE_PRICE FROM MOVIE WHERE GENRE = @GENRE");
            comm.Parameters.AddWithValue("@GENRE", genre);
            this.getMovieListData(ref comm, ref list);
            return list;
        }

        /// <summary>
        /// Get all data of a movie
        /// </summary>
        /// <param name="movieID">ID String of a movie</param>
        /// <returns>Return: Movie object that contains all data of a movie</returns>
        public Movie GetMovieData(String movieID)
        {
            Movie m = new Movie();

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand comm = new MySqlCommand("SELECT * FROM MOIVE WHERE MOVIE_ID = @MOVIEID", conn);
            comm.Parameters.AddWithValue("@MOVIEID", movieID);
            
            try
            {
                conn.Open();
                MySqlDataReader reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    m.movieId = reader.GetString("movie_id");
                    m.movieName = reader.GetString("movie_name");
                    m.year = reader.GetInt16("year");
                    m.movieLength = reader.GetInt16("movie_length");
                    m.genre = reader.GetString("genre");
                    m.purchasePrice = reader.GetDouble("purchase_price");
                    m.movieDescription = reader.GetString("movie_description") ;
                    m.actors = reader.IsDBNull(reader.GetOrdinal("actors")) ? "" : reader.GetString("actors") ;
                    m.producers = reader.IsDBNull(reader.GetOrdinal("producers")) ? "" : reader.GetString("producers");
                    m.directors = reader.IsDBNull(reader.GetOrdinal("directors")) ? "" : reader.GetString("directors");
                    m.writers = reader.IsDBNull(reader.GetOrdinal("writers")) ? "" : reader.GetString("writers");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m;
        }

        /// <summary>
        /// Get all movie genres from the database
        /// </summary>
        /// <returns>A String list contains all the genres</returns>
        public List<String> GetGenreStringList()
        {
            List<String> list = new List<String>();
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlDataReader reader = new MySqlCommand("SELECT DISTINCT(GENRE) FROM MOVIE", conn).ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader.GetString("genre"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return list;
        }

        /// <summary>
        /// Retrieve basic movie data from the database for listing purpose
        /// </summary>
        /// <param name="comm">MySql Command for retrieving movie data</param>
        /// <param name="list">Movie object list for storing movie data</param>
        private void getMovieListData(ref MySqlCommand comm, ref List<Movie> list)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
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
        }
    }
}