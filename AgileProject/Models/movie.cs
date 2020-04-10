using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Model
{
    class Movie
    {
        public String movieId { get; set; }
        public String movieName { get; set; }
        public Int16 year { get; set; }
        public Int16 movieLength { get; set; }
        public String genre { get; set; }
        public Double purchasePrice { get; set; }
        public String movieDescription { get; set; }
        public String actors { get; set; }
        public String producers { get; set; }
        public String directors { get; set; }
        public String writers { get; set; }


        public Movie() { }

        public Movie(string movieId, string movieName, string genre, double purchasePrice)
        {
            this.movieId = movieId;
            this.movieName = movieName;
            this.genre = genre;
            this.purchasePrice = purchasePrice;
        }

        public Movie(string movieId, string movieName, short year, short movieLength, string genre, double purchasePrice, string movieDescription, string actors, string producers, string directors, string writers)
        {
            this.movieId = movieId;
            this.movieName = movieName;
            this.year = year;
            this.movieLength = movieLength;
            this.genre = genre;
            this.purchasePrice = purchasePrice;
            this.movieDescription = movieDescription;
            this.actors = actors;
            this.producers = producers;
            this.directors = directors;
            this.writers = writers;
        }

        public override string ToString()
        {
            return $"{{{nameof(movieId)}={movieId}, {nameof(movieName)}={movieName}, {nameof(year)}={year.ToString()}, {nameof(movieLength)}={movieLength.ToString()}, {nameof(genre)}={genre}, {nameof(purchasePrice)}={purchasePrice.ToString()}, {nameof(movieDescription)}={movieDescription}, {nameof(actors)}={actors}, {nameof(producers)}={producers}, {nameof(directors)}={directors}, {nameof(writers)}={writers}}}";
        }
    }
}
