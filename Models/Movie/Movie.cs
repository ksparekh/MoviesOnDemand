using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesOnDemand.Models
{
    public class Movie
    {
        public Movie(int iD, string title, DateTime releaseDate, decimal price, MovieCategory category, string description = "")
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Movie Title can't be empty.", nameof(title));
            }            

            this.ID = iD;
            this.Title = title;
            this.Description = description;
            this.ReleaseDate = releaseDate;
            this.Price = price;
            this.Category = category ?? throw new ArgumentNullException(nameof(category));
        }
        
        public int ID { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public MovieCategory Category { get; set; }

        public void SetDescription(string desc)
        {
            if (string.IsNullOrEmpty(desc))
            {
                throw new ArgumentException("Movie Description can't be empty.", nameof(desc));
            } 

            this.Description = desc;
        }
    }
}